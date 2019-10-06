import scrollDisable from './helpers';

const header = {
	$header: $('.header'),
	$navToggle: $('.js-nav-toggle'),
	navToggleOpenedClass: 'nav-toggle--opened',
	$navigation: $('.js-nav'),
	navigationOpenedClass: 'nav--opened',

	init: function() {
		this.navigationToggle();
	},

	navigationToggle: function() {
		this.$navToggle.on('click', () => {
			if(!this.$navToggle.hasClass(this.navToggleOpenedClass)) {
				this.$navToggle.addClass(this.navToggleOpenedClass);
				this.$navigation.addClass(this.navigationOpenedClass);
				scrollDisable.disableScroll();
			} else {
				this.$navToggle.removeClass(this.navToggleOpenedClass);
				this.$navigation.removeClass(this.navigationOpenedClass);
				scrollDisable.enableScroll();
			}
		});
	}
};

export default header;
