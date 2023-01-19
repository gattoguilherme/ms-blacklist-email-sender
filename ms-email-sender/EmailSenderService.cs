using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ms_email_sender
{
    public static class EmailSenderService
    {
        public static void SendEmail(string content)
        {
            SmtpClient smtp = new SmtpClient();

            smtp.UseDefaultCredentials = false;
            smtp.EnableSsl = true;
            smtp.Host = "smtp.office365.com";
            smtp.Port = 587;
            smtp.Credentials = new System.Net.NetworkCredential(Consts.username, Consts.password);

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(Consts.username);

            if (!string.IsNullOrWhiteSpace(Consts.username))
            {
                mail.To.Add(new MailAddress(Consts.username));
            }
            else
            {
                Console.WriteLine("Erro ao enviar mensagem");
                return;
            }
            //if (!string.IsNullOrWhiteSpace(textBoxCC.Text))
            //    mail.CC.Add(new System.Net.Mail.MailAddress(textBoxCC.Text));
            //if (!string.IsNullOrWhiteSpace(textBoxCCo.Text))
            //    mail.Bcc.Add(new System.Net.Mail.MailAddress(textBoxCCo.Text));
            mail.Subject = "Novo candidato dentro da BlackList!";
            mail.Body = content;

            smtp.Send(mail);
            Console.WriteLine("Email enviado");
        }
    }
}
