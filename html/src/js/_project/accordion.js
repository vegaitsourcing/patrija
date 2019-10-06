const accordion = {
	$accBtn: $('.js-acc-btn'),
	accBtnActive: 'faq__accordion-btn--active',

	init: function() {
		this.bindEvents();
	},

	bindEvents: function() {
		const _this = this;
		this.$accBtn.each(function() {
			$(this).on('click', function() {
				if($(this).hasClass(_this.accBtnActive)) {
					$(this).removeClass(_this.accBtnActive);
					$(this).next().stop().slideUp('fast');
				} else {
					_this.$accBtn.next().stop().slideUp('fast');
					$(this).next().stop().slideDown('fast');
					_this.$accBtn.removeClass(_this.accBtnActive);
					$(this).addClass(_this.accBtnActive);
				}
			});
		});
	}
};

export default accordion;
