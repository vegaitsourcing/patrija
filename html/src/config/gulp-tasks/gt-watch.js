const gulp = require('gulp');
const	path = require('path');
const	fs = require('fs');
const	globalVars = require('./_global-vars');

/*----------------------------------------------------------------------------------------------
	Watch
 ----------------------------------------------------------------------------------------------*/
gulp.task('watch', () => {
	// watch .scss files
	gulp.watch(['src/scss/**/*.scss', 'src/html/**/**/*.scss'], ['css', 'sasslint']);

	// watch .js files
	gulp.watch('src/js/**/*.js', ['js']);

	// watch .hbs and .json files
	gulp.watch(['src/html/**/*.hbs', 'src/html/**/*.json'], e => {
		const src = path.relative('./src/', e.path);
		const type = src.split('\\').slice(1, -2).toString();
		const name = src.split('\\').slice(2, -1).toString();

		if (type === 'templates') {
			globalVars.pagesSRCs = [`./src/html/templates/${name}/template.hbs`];
			gulp.start('hbs-build');
		} else {
			const promises = [];

			// get page
			const getPage = cur => {
				return new Promise((resolve) => {
					globalVars.rf(`src/html/templates/${cur}/template.hbs`, () => {
						resolve(`./src/html/templates/${cur}/template.hbs`);
					});
				});
			};

			// scan folders
			fs.readdirSync('src/html/templates').forEach(cur => {
				promises.push(getPage(cur));
			});

			// run hbs-build when all reading is done
			Promise.all(promises)
				.then(values => {
					globalVars.pagesSRCs = values.filter(cur => cur !== null);
					gulp.start('hbs-build');
				})
				.catch(error => {
					console.log(error);
				});
		}
	});
});
