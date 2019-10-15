using System.ComponentModel;
using System.Configuration;

namespace Patrija.Common
{
	/// <summary>
	/// Enables access to application settings, stored in App.config or Web.config 'appSettings' section.
	/// </summary>
	public static partial class AppSettings
	{
		public static bool DisableHttpCompression => Get<bool>("disableHttpCompression", false);
		public static string XMLSitemapRouteUrl => Get<string>("xmlSitemapRouteUrl", "xmlsitemap");

	    public static string SmtpHost => Get<string>("emailSmtpHost", string.Empty);
	    public static int SmtpPort => Get<int>("emailSmtpPort", -1);
	    public static string SourceEmailAddress => Get<string>("emailSourceAdddress", string.Empty);
	    public static string SourceEmailPassword => Get<string>("emailSourcePassword", string.Empty);
	    public static string DestinationEmailAddress => Get<string>("emailDestinationAdddress", string.Empty);

        public static string FacebookUrl => Get<string>("social-facebook");
        public static string TwitterUrl => Get<string>("social-twitter");
        public static string LinkedInUrl => Get<string>("social-linkedIn");
        public static string GooglePlusUrl => Get<string>("social-googlePlus");

        /// <summary>
        /// Retrieves configuration value associated with given <paramref name="key"/>.
        /// </summary>
        /// <typeparam name="T">Configuration value type.</typeparam>
        /// <param name="key">Configuration key.</param>
        /// <returns>Configuration value associated with given <paramref name="key"/>.</returns>
        public static T Get<T>(string key)
		{
			string setting = ConfigurationManager.AppSettings[key];
			if (string.IsNullOrWhiteSpace(setting))
			{
				throw new ConfigurationErrorsException($"Key '{key}' not found in the configuration file!");
			}

			return (T)TypeDescriptor.GetConverter(typeof(T)).ConvertFromInvariantString(setting);
		}

		/// <summary>
		/// Retrieves configuration value associated with given <paramref name="key"/>.
		/// If value for given <paramref name="key"/> is not found, <paramref name="defaultValue"/> is returned.
		/// </summary>
		/// <typeparam name="T">Configuration value type.</typeparam>
		/// <param name="key">Configuration key.</param>
		/// <param name="defaultValue">Default value.</param>
		/// <returns>Configuration value associated with given <paramref name="key"/>, or <paramref name="defaultValue"/> if given <paramref name="key"/> is not found.</returns>
		public static T Get<T>(string key, T defaultValue)
		{
			string setting = ConfigurationManager.AppSettings[key];
			if (string.IsNullOrWhiteSpace(setting))
			{
				return defaultValue;
			}

			return (T)TypeDescriptor.GetConverter(typeof(T)).ConvertFromInvariantString(setting);
		}
	}
}
