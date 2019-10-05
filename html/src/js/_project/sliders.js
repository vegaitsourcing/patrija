const sliders = {
	init: function() {
		this.newsSliderInit();
		this.testimonialsSliderInit();
		this.gallerySliderInit();
	},

	newsSliderInit: function() {
		$('.js-news-slider').slick({
			infinite: true,
			slidesToShow: 3,
			slidesToScroll: 1
		});
	},

	testimonialsSliderInit: function() {
		$('.js-testimonials-slider').slick({
			infinite: true,
			slidesToShow: 1,
			slidesToScroll: 1
		});
	},

	gallerySliderInit: function() {
		$('.js-gallery-slider').slick({
			infinite: true,
			slidesPerRow: 3,
			rows: 2
		});
	}
};

export default sliders;
