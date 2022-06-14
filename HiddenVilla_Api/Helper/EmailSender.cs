using System.Threading.Tasks;
using Mailjet.Client;
using Mailjet.Client.Resources;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Options;
using Newtonsoft.Json.Linq;

namespace HiddenVilla_Api.Helper
{
    public class EmailSender : IEmailSender
    {
        private readonly MailJetSettings _mailJetSettings;

        public EmailSender(IOptions<MailJetSettings> mailjetSettings) => _mailJetSettings = mailjetSettings.Value;

        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var client = new MailjetClient(_mailJetSettings.PublicKey,
                _mailJetSettings.PrivateKey)
            {
                Version = ApiVersion.V3_1,
            };
            var request = new MailjetRequest
            {
                Resource = Send.Resource,
            }
               .Property(Send.Messages, new JArray {
                new JObject {
                 {"From", new JObject {
                  {"Email", _mailJetSettings.Email},
                  {"Name", "Mailjet Pilot"}
                  }},
                 {"To", new JArray {
                  new JObject {
                   {"Email", email},
                   {"Name", "Hello"}
                   }
                  }},
                 {"Subject", subject},
                 {"HTMLPart", htmlMessage}
                 }
                   });

            _ = await client.PostAsync(request);
        }
    }
}
