const accordion = {
	accBtnActive: 'faq__accordion-btn--active',

	init: function() {
		this.bindEvents();
	},

	bindEvents: function() {
		const _this = this;
		$('.js-acc-btn').each(function() {
			const $btn = $(this);
			$btn.on('click', () => {
				if($btn.hasClass(_this.accBtnActive)) {
					$btn.removeClass(_this.accBtnActive);
					$btn.next().stop().slideUp('fast');
				} else {
					$('.js-acc-btn').next().stop().slideUp('fast');
					$btn.next().stop().slideDown('fast');
					$('.js-acc-btn').removeClass(_this.accBtnActive);
					$btn.addClass(_this.accBtnActive);
				}
			});
		});
	}
};

export default accordion;
