import helpers from './_project/helpers';
import sliders from './_project/sliders';
import forms from './_project/forms';
import accordion from "./_project/accordion";
import popups from "./_project/popups";

$(() => {
	helpers.init();
	forms.init();
	accordion.init();
	popups.init();
});

$(window).on('load', () => {
	sliders.init();
});
