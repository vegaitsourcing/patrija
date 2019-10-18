const load = {
	$newspage: $('.js-newspage'),
	$newspageId: $('.js-newspage').data('page-id'),
	$restBlogArticlesContainer: $('.js-rest_articles_container'),
	$restBlogArticlesControllerUrl: $('.js-rest_articles_container').data('url-controller'),

	init: function() {
		const _this = this;
		if (!$('.js-newspage').length) {
			return;
		}
		let i = 0;
		$('.js-load-btn').each(function() {
			$(this).data('order-number', i);
			i++;
		});

		$(document).on('click', '.featured-news__load-more', function() {
			_this.loadAllFeatureBlogArticles($(this).data('order-number'));
			$(this).hide();
		});

		$(document).on('click', '.articles__load-more', function() {
			_this.loadAllTwoColumnArticles($(this).data('order-number'));
			$(this).hide();
		});

		$(document).on('click', '.news-list__load-more', function() {
			_this.loadAllThreeColumnArticles($(this).data('order-number'));
			$(this).hide();
		});


	},

	loadAllFeatureBlogArticles: function(ordernumber) {
		const _this = this;
		$.get($('.js-newspage').data('url-controller'), {
			newsPageId: $('.js-newspage').data('page-id'),
			numberArticlesOnLoad: $('.js-rest_articles_container').data('on-load-number'),
			partial: '_BlogsArticlesListing',
			orderNumber: ordernumber
		}, (response) => {
			$('.js-rest_articles_container').append(response);
		});
	},

	loadAllTwoColumnArticles: function(ordernumber) {
		const _this = this;
		$.get($('.js-newspage').data('url-controller'), {
			newsPageId: $('.js-newspage').data('page-id'),
			numberArticlesOnLoad: $('.js-three_column_article_container').data('on-load-number'),
			partial: '_TwoColumnsArticlesListing',
			orderNumber: ordernumber
		}, (response) => {
			$('.js-three_column_article_container').append(response);
		});
	},

	loadAllThreeColumnArticles: function(ordernumber) {
		const _this = this;
		$.get($('.js-newspage').data('url-controller'), {
			newsPageId: $('.js-newspage').data('page-id'),
			numberArticlesOnLoad: $('.js-two_column_article_container').data('on-load-number'),
			partial: '_ThreeColumnsArticlesListing',
			orderNumber: ordernumber
		}, (response) => {
			$('.js-two_column_article_container').append(response);
		});
	},

};

export default load;
