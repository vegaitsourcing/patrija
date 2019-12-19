import scrollDisable from './helpers';

const peoplePopup = {
	$popup: $('.js-popup'),
	popupOpenedClass: 'popup-overlay--opened',

	init: function() {
		if(!$('.popup-overlay').length) {
			return;
		}
		this.openVolunteerPopup();
		this.openMemberPopup();
		this.bindClosePopupEvents();
	},

	openVolunteerPopup: function() {
		$(document).on('click', '.js-volunteer-popup', (e) => {
			if(!$('.volunteer-popup').hasClass(this.popupOpenedClass)) {
				$('.volunteer-popup').stop().fadeIn(500).addClass(this.popupOpenedClass);
			}
			scrollDisable.disableScroll();
			e.preventDefault();
		});
	},

	openMemberPopup: function() {
		$(document).on('click', '.js-member-popup', (e) => {
			if(!$('.member-popup').hasClass(this.popupOpenedClass)) {
				$('.member-popup').stop().fadeIn(500).addClass(this.popupOpenedClass);
			}
			scrollDisable.disableScroll();
			e.preventDefault();
		});
	},

	bindClosePopupEvents: function() {
		const _this = this;
		// Close popup on click on X, overlay and Escape key
		$('.js-close-popup').on('click', () => {
			_this.closePopup();
		});

		$('.popup-overlay').on('click', function(e) {
			if(e.target.parentElement.classList.contains('js-close-popup') || e.target !== this) return;
			_this.closePopup();
		});

		$(document).off('keydown').on('keydown', (e) => {
			if (e.which !== 27) {
				return;
			}
			_this.closePopup();
		});
	},

	closePopup: function() {
		$('.popup-overlay').stop().fadeOut(500).removeClass(this.popupOpenedClass);
		$('.form__error-message').hide();
		$('.form__input').each(function() {
			$(this).val('');
		});
		scrollDisable.enableScroll();
	}
};

export default peoplePopup;
