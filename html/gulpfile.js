const gulp = require('gulp');
const clean = require('gulp-clean');
const runSequence = require('run-sequence');
const fs = require('fs');
const globalVars = require('./src/config/gulp-tasks/_global-vars');

// get web folder path
gulp.task('get-web-folder', () => {
	const getDirectories = source => fs.readdirSync(source).filter(name => name.indexOf('.Web') > -1)[0];
	const result = getDirectories('../');
	if(result) globalVars.webFolder = `../${result}`;

	return true;
});

// copy favicon
gulp.task('copy-favicon', () => {
	fs.readdirSync('./src/favicon').forEach(file => {
		if(globalVars.webFolder) {
			fs.copyFileSync(`./src/favicon/${file}`, `${globalVars.webFolder}/${file}`);
		}
		fs.copyFileSync(`./src/favicon/${file}`, `./dist/${file}`);
	});

	return true;
});

// build all files
gulp.task('build-dev', () => {
	globalVars.createDistFolder();
	globalVars.stageBuild = false;
	globalVars.productionBuild = false;
	runSequence('get-web-folder', 'hbs-prep', 'hbs', 'iconfont', 'css', 'js', 'assets', 'copy-favicon');
});

gulp.task('build-stage', () => {
	globalVars.createDistFolder();
	globalVars.stageBuild = true;
	globalVars.productionBuild = false;
	fs.copyFileSync('robots.txt', 'dist/robots.txt');
	runSequence('get-web-folder', 'html-clean', 'hbs-prep', 'hbs', 'iconfont', 'css', 'js', 'assets', 'copy-favicon');
});

gulp.task('build-prod', () => {
	globalVars.createDistFolder();
	globalVars.stageBuild = true;
	globalVars.productionBuild = true;
	runSequence('get-web-folder', 'html-clean', 'hbs-prep', 'hbs', 'iconfont', 'css', 'js', 'assets', 'copy-favicon');
});

// delete dist folder
gulp.task('reset-dev', () => {
	return gulp.src('dist', {read: false})
		.pipe(clean());
});

// start dev tasks
gulp.task('default', () => {
	globalVars.createDistFolder();
	globalVars.productionBuild = false;
	globalVars.stageBuild = false;
	runSequence('get-web-folder', 'hbs-prep', 'hbs', 'css', 'js', 'watch');
});

// import gulp tasks
require('require-dir')('./src/config/gulp-tasks');
