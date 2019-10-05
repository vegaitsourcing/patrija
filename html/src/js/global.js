import helpers from './_project/helpers';
import sliders from './_project/sliders';

$(() => {
	helpers.init();
});

$(window).on('load', () => {
	sliders.init();
});
