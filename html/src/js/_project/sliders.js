const sliders = {
	$newsSlider: $('.js-news-slider'),
	$testimonialsSlider: $('.js-testimonials-slider'),
	$gallerySlider: $('.js-gallery-slider'),

	init: function() {
		this.newsSliderInit();
		this.testimonialsSliderInit();
		this.gallerySliderInit();
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
	},

	gallerySliderInit: function() {
		this.$gallerySlider.slick({
			infinite: true,
			slidesPerRow: 3,
			rows: 2
		});
	}
};

export default sliders;
