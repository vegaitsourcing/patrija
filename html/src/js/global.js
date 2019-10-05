import helpers from './_project/helpers';
import sliders from './_project/sliders';
import forms from './_project/forms';

$(() => {
	helpers.init();
	forms.init();
});

$(window).on('load', () => {
	sliders.init();
});
