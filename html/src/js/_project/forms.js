const forms = {
	init: function() {

		$('#donations-form').on('click', '.btn--submit', (event) => {
			this.submitSingleForm(event, '/umbraco/surface/SimpleFormSurface/SubmitDonationForm');
		});

		$('#seller-form').on('click', '.btn--submit', (event) => {
			this.submitSingleForm(event, '/umbraco/surface/SimpleFormSurface/SubmitSellerForm');
		});

		$('#user-form').on('click', '.btn--submit', (event) => {
			this.submitSingleForm(event, '/umbraco/surface/SimpleFormSurface/SubmitUserForm');
		});

		$('#volunteer-form').on('click', '.btn--submit', (event) => {
			this.submitSingleForm(event, '/umbraco/surface/SimpleFormSurface/SubmitVolunteerForm');
		});

		$('#contact-form').on('click', '.btn--submit', (event) => {
			this.submitSingleForm(event, '/umbraco/surface/SimpleFormSurface/SubmitContactForm');
		});
	},

	submitSingleForm: function(event, url) {
		const fullName = $(event.delegateTarget).find('#name').val();
		const fullNameValid = !!fullName;
		const fullNameErrorNode = $(event.delegateTarget).find('[data-for="name"]');
		fullNameErrorNode.css('display', fullNameValid ? 'none' : 'inherit');

		const emailAddress = $(event.delegateTarget).find('#email').val();
		const emailValid = !!emailAddress && this.validateEmail(emailAddress);
		const emailErrorNode = $(event.delegateTarget).find('[data-for="email"]');
		emailErrorNode.css('display', emailValid ? 'none' : 'inherit');

		const comment = $(event.delegateTarget).find('#message').val();
		const commentValid = !!comment;
		const commentErrorNode = $(event.delegateTarget).find('[data-for="message"]');
		commentErrorNode.css('display', commentValid ? 'none' : 'inherit');

		if(fullNameValid && emailValid && commentValid) {
			$.ajax({
				type: 'POST',
				url: url,
				data: {
					FullName: fullName,
					EmailAddress: emailAddress,
					Comment: comment
				}
			})
				.done(() => {
					$(event.delegateTarget).find('.form__message-success').css('display', 'inherit');
				});
		}
	},

	validateEmail: function(email) {
		const re = /\S+@\S+\.\S+/;
		return re.test(String(email).toLowerCase());
	}
};

export default forms;
