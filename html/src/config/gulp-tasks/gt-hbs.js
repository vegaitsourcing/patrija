const gulp = require('gulp');
const runSequence = require('run-sequence');
const path = require('path');
const fs = require('fs');
const tap = require('gulp-tap');
const gulpif = require('gulp-if');
const print = require('gulp-print').default;
const handlebars = require('gulp-compile-handlebars');
const hbsHelpers = require('./gt-hbs-helpers');
const prettify = require('gulp-html-prettify');
const rename = require('gulp-rename');
const clean = require('gulp-clean');
const globalVars = require('./_global-vars');

/*----------------------------------------------------------------------------------------------
	HBS
 ----------------------------------------------------------------------------------------------*/
function checkForIncludedJson(object) {
	// loop through all properties down the object's tree
	for (const prop in object) {
		if (object.hasOwnProperty(prop)) {
			const innerObject = JSON.parse(JSON.stringify(object[prop]));
			const propIncl = '>>';

			if (innerObject[propIncl]) {
				const inclData = JSON.parse(fs.readFileSync(`./src/html/${innerObject[propIncl]}`));
				// check if component has included json
				checkForIncludedJson(inclData);
				object[prop] = inclData;
			}

			// check if object has properties that will override data from JSON
			for (const p in innerObject) {
				if (innerObject.hasOwnProperty(p) && p !== '>>') {
					object[prop][p] = innerObject[p];

					// check if inner prop has included json
					if (typeof innerObject[p] === 'object') {
						checkForIncludedJson(innerObject);
					}

					object[prop][p] = innerObject[p];
				}
			}
		}
	}

	return object;
}

// build
gulp.task('hbs-build', () => {
	runSequence('hbs-prep', 'hbs');
});

// delete all html files from dist
gulp.task('html-clean', () => {
	return gulp.src('dist/**/*.html', {read: false})
		.pipe(clean());
});

// prepare modules
gulp.task('hbs-prep', () => {
	return gulp.src(['./src/html/modules/**/*.hbs', './src/html/shared/**/*.hbs'])
		.pipe(tap((file) => {
			const src = './src/' + path.relative('./src/', file.path).split(path.sep).slice(0, -1).join('/');
			globalVars.partialSRCs.push(src);
		}));
});

// parse hbs files
gulp.task('hbs', () => {
	// set options from prepared vars
	const options = {
		ignorePartials: true,
		batch: globalVars.partialSRCs,
		helpers: hbsHelpers
	};

	return gulp.src(globalVars.pagesSRCs)
		.pipe(tap((file) => {
			const jsonPath = './src/' + path.relative('./src/', file.path).split(path.sep).slice(0, -1).join('/') + '/data.json';
			const dataObject = JSON.parse(fs.readFileSync(jsonPath));
			dataObject.data = checkForIncludedJson(dataObject.data);

			// parse files
			gulp.src(file.path)
				.pipe(handlebars(dataObject, options))
				.pipe(rename({
					basename: dataObject.template,
					extname: '.html'
				}))
				// eslint-disable-next-line camelcase
				.pipe(gulpif(globalVars.stageBuild, prettify({indent_char: '	', indent_size: 1})))
				.pipe(print())
				.pipe(gulp.dest('dist'));
		}));
});
