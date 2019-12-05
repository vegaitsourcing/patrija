const shave = {
	init: function() {
		const newsItem = $('.news-list__text');
		const newsSliderItem = $('.news-slider__text');
		const maxHeight = 50;

		newsItem.shave(maxHeight);
		newsSliderItem.shave(maxHeight);
	}
};

export default shave;
