const newsSlider = {
	selector: $('.js-news-slider'),

	init: function() {
		this.selector.slick({
			infinite: true,
			slidesToShow: 3,
			slidesToScroll: 1
		});
	}
};

export default newsSlider;
