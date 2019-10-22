const load = {
	$newspage: $('.js-newspage'),
	$newspageId: $('.js-newspage').data('page-id'),
	$restBlogArticlesContainer: $('.js-rest_articles_container'),
	$restBlogArticlesControllerUrl: $('.js-newspage').data('url-controller'),
	$numberOfFeatureArticlesOnLoad: $('.js-rest_articles_container').data('on-load-number'),
	$numberOfTwoColumnArticlesOnLoad: $('.js-three_column_article_container').data('on-load-number'),
	$twoColumnArticlesContainer: $('.js-three_column_article_container'),
	$numberOfThreeColumnArticlesOnLoad: $('.js-two_column_article_container').data('on-load-number'),
	$threeColumnArticlesContainer: $('.js-two_column_article_container'),

	featureArticleListingPartialName: '_BlogsArticlesListing',
	twoColumnsArticleListingPartialName: '_TwoColumnsArticlesListing',
	threeColumnsArticleListingPartialName: '_ThreeColumnsArticlesListing',

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
			_this.loadAllArticles(
				load.$numberOfFeatureArticlesOnLoad,
				load.featureArticleListingPartialName,
				$(this).data('order-number'),
				load.$restBlogArticlesContainer
			);
			$(this).hide();
		});

		$(document).on('click', '.articles__load-more', function() {
			_this.loadAllArticles(
				load.$numberOfTwoColumnArticlesOnLoad,
				load.twoColumnsArticleListingPartialName,
				$(this).data('order-number'),
				load.$twoColumnArticlesContainer
			);
			$(this).hide();
		});

		$(document).on('click', '.news-list__load-more', function() {
			_this.loadAllArticles(
				load.$numberOfThreeColumnArticlesOnLoad,
				load.threeColumnsArticleListingPartialName,
				$(this).data('order-number'),
				load.$threeColumnArticlesContainer
			);
			$(this).hide();
		});
	},

	loadAllArticles: function(numberOfItemsOnLoad, partial, ordernumber, container) {
		$.get(load.$restBlogArticlesControllerUrl, {
			newsPageId: load.$newspageId,
			numberArticlesOnLoad: numberOfItemsOnLoad,
			partial: partial,
			orderNumber: ordernumber
		}, (response) => {
			container.append(response);
		});
	},

};

export default load;
