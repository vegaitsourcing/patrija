const path = require('path');

module.exports = {
	entry: {
		'global': './src/js/global.js'
	},
	output: {
		path: path.join(__dirname, './dist/js/'),
		filename: '[name].js'
	},
	module: {
		loaders: [
			{
				test: path.join(__dirname),
				loader: 'babel-loader'
			}
		]
	}
};
