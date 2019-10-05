const newsSlider = {
	selector: $('.js-news-slider'),

	init: function() {
		$('.js-news-slider').slick({
			infinite: true,
			slidesToShow: 3,
			slidesToScroll: 1
		});
	}
};

$(window).on('load', () => {
	newsSlider.init();
});

export default newsSlider;
