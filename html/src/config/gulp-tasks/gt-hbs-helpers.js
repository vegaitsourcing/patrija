const handlebars = require('gulp-compile-handlebars');
const globalVars = require('./_global-vars');

module.exports = {
	testWrap: (context, options) => {
		return new handlebars.Handlebars.SafeString(
			`<div class="test-wrap">
			${options.fn(context)}
			</div>`
		);
	},

	ifEquals: function(arg1, arg2, options) {
		return (arg1 === arg2) ? options.fn(this) : options.inverse(this);
	},

	compare: function(v1, operator, v2) {
		switch (operator) {
			case '==': return v1 === v2;
			case '===': return v1 === v2;
			case '!=': return v1 !== v2;
			case '!==': return v1 !== v2;
			case '<': return v1 < v2;
			case '<=': return v1 <= v2;
			case '>': return v1 > v2;
			case '>=': return v1 >= v2;
			case '&&': return v1 && v2;
			case '||': return v1 || v2;
			default: throw new Error('helper {{compare}}: invalid operator ' + operator);
		}
	},

	isProduction: function() {
		return globalVars.productionBuild;
	}
};
