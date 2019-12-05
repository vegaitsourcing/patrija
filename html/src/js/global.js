import helpers from './_project/helpers';
import sliders from './_project/sliders';
import forms from './_project/forms';
import accordion from './_project/accordion';
import popups from './_project/popups';
import header from './_project/header';
import load from './_project/loadmore';
import shave from './_project/shave';

$(() => {
	helpers.init();
	header.init();
	forms.init();
	accordion.init();
	popups.init();
	load.init();
	shave.init();
});

$(window).on('load', () => {
	sliders.init();
});

$(window).on('resize', () => {
	shave.init();
});
