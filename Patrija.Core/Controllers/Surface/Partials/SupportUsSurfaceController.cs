using System;
using System.Net;
using System.Net.Mail;
using System.Web.Mvc;
using Patrija.Common;
using Patrija.Core.Dtos;

namespace Patrija.Core.Controllers.Surface.Partials
{
    public class SupportUsSurfaceController : BaseSurfaceController
    {
        [HttpPost]
        public ActionResult SubmitDonationForm(SimpleFormDto formData)
        {
            if (!ModelState.IsValid)
            {
                return new HttpStatusCodeResult(400);
            }

            try
            {
                var emailClient = new SmtpClient();
                var mailMessage = new MailMessage
                {
                    From = new MailAddress(AppSettings.SourceEmailAddress),
                    Subject = $"[Donacije] Korisnik {formData.FullName}"
                };

                mailMessage.To.Add(new MailAddress(AppSettings.DestinationEmailAddress));
                //message.IsBodyHtml = true; 

                mailMessage.Body =
                    $"{formData.FullName} sa email adresom {formData.EmailAddress} je poslao poruku: {formData.Comment}";
                emailClient.Port = AppSettings.SmtpPort;
                emailClient.Host = AppSettings.SmtpHost;
                emailClient.EnableSsl = true;
                emailClient.UseDefaultCredentials = false;
                emailClient.Credentials =
                    new NetworkCredential(AppSettings.SourceEmailAddress, AppSettings.SourceEmailPassword);
                emailClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                emailClient.Send(mailMessage);
            }
            catch
            {
                return new HttpStatusCodeResult(500);
            }

            return new HttpStatusCodeResult(200);
        }
    }
}