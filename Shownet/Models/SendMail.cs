using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Net.Mail;
using System.Net.Configuration;

namespace Shownet.Models
{
        public class SendMail
        {
            //public static readonly string
           
            public static bool SendEmailMessage(string subject, string body, bool html, string to_addr, string to_name)
            {
                return SendEmailMessage(subject, body, html, to_addr, to_name, "no-reply@shownet.biz", "ShowNet");
            }

            public static bool SendEmailMessage(string subject, string body, bool html, string to_addr, string to_name, string from_addr, string from_name)
            {
                var MailSetting = (SmtpSection)ConfigurationManager.GetSection("system.net/mailSettings/smtp") as SmtpSection;
                var mailTo = new MailAddress(to_addr, to_name);
                var mailFrom = new MailAddress(from_addr, from_name);
                var mail = new MailMessage(mailFrom, mailTo);
                mail.IsBodyHtml = html;
                mail.Subject = subject;
                mail.Body = body;

                string mailServer = MailSetting.Network.Host;
                SmtpClient client = new SmtpClient(mailServer);

                bool ok = true;
                try
                {
                    client.Send(mail);
                }
                catch (Exception ex)
                {
                    ok = false;
                }
                return ok;
            }
        }
    }