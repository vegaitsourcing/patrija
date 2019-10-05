const sliders = {
	$newsSlider: $('.js-news-slider'),
	$testimonialsSlider: $('.js-testimonials-slider'),

	init: function() {
		this.newsSliderInit();
		this.testimonialsSliderInit();
	},

	newsSliderInit: function() {
		this.$newsSlider.slick({
			infinite: true,
			slidesToShow: 3,
			slidesToScroll: 1
		});
	},

	testimonialsSliderInit: function() {
		this.$testimonialsSlider.slick({
			infinite: true,
			slidesToShow: 1,
			slidesToScroll: 1
		});
	}
};

export default sliders;
