const shave = {
	init: function() {
		const selector = $('.news-list__text');
		const maxHeight = 50;

		selector.shave(maxHeight);
	}
};

export default shave;
