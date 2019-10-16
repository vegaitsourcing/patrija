import helpers from './_project/helpers';
import sliders from './_project/sliders';
import forms from './_project/forms';
import accordion from './_project/accordion';
import popups from './_project/popups';
import header from './_project/header';
import load from './_project/loadmore';

$(() => {
	helpers.init();
	header.init();
	forms.init();
	accordion.init();
	popups.init();
	load.init();
});

$(window).on('load', () => {
	sliders.init();
});
