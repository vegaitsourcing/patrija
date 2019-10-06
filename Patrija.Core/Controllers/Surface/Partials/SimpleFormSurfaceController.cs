using System;
using System.Net;
using System.Net.Mail;
using System.Web.Mvc;
using Patrija.Common;
using Patrija.Core.Dtos;

namespace Patrija.Core.Controllers.Surface.Partials
{
    public class SimpleFormSurfaceController : BaseSurfaceController
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
                SendEmail(formData, $"[Donacije] Korisnik {formData.FullName}");
            }
            catch
            {
                return new HttpStatusCodeResult(500);
            }

            return new HttpStatusCodeResult(200);
        }

        [HttpPost]
        public ActionResult SubmitSellerForm(SimpleFormDto formData)
        {
            if (!ModelState.IsValid)
            {
                return new HttpStatusCodeResult(400);
            }

            try
            {
                SendEmail(formData, $"[Prodavac] Korisnik {formData.FullName}");
            }
            catch
            {
                return new HttpStatusCodeResult(500);
            }

            return new HttpStatusCodeResult(200);
        }

        private void SendEmail(SimpleFormDto formData, string subject)
        {
            var emailClient = new SmtpClient();
            var mailMessage = new MailMessage
            {
                From = new MailAddress(AppSettings.SourceEmailAddress),
                Subject = subject,
                Body = $"{formData.FullName} sa email adresom {formData.EmailAddress} je poslao poruku: {Environment.NewLine}\"{formData.Comment}\""
            };

            mailMessage.To.Add(new MailAddress(AppSettings.DestinationEmailAddress));
            //message.IsBodyHtml = true; 

            emailClient.Port = AppSettings.SmtpPort;
            emailClient.Host = AppSettings.SmtpHost;
            emailClient.EnableSsl = true;
            emailClient.UseDefaultCredentials = false;
            emailClient.Credentials =
                new NetworkCredential(AppSettings.SourceEmailAddress, AppSettings.SourceEmailPassword);
            emailClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            emailClient.Send(mailMessage);
        }
    }
}