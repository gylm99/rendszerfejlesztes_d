using MimeKit;

namespace EstateSales.Backend.Services.Email
{
    public static class EmailCrator
    {
        public static MimeMessage CreateEmailMessage(string fromName, string fromEmail, string toName, string toEmail, MimeEntity body)
        {
            if (string.IsNullOrWhiteSpace(fromName)) throw new ArgumentException("Sender name cannot be empty", nameof(fromName));
            if (string.IsNullOrWhiteSpace(fromEmail)) throw new ArgumentException("Sender email cannot be empty", nameof(fromEmail));
            if (string.IsNullOrWhiteSpace(toName)) throw new ArgumentException("Recipient name cannot be empty", nameof(toName));
            if (string.IsNullOrWhiteSpace(toEmail)) throw new ArgumentException("Recipient email cannot be empty", nameof(toEmail));

            if (body == null) throw new ArgumentNullException(nameof(body));

            var newemail = new MimeMessage();

            newemail.SetEmailMessage(fromName, fromEmail, toName, toEmail, body);

            return newemail;
        }

        public static void SetEmailMessage(this MimeMessage newemail, string fromName, string fromEmail, string toName, string toEmail, MimeEntity body)
        {
            if (string.IsNullOrWhiteSpace(fromName)) throw new ArgumentException("Sender name cannot be empty", nameof(fromName));
            if (string.IsNullOrWhiteSpace(fromEmail)) throw new ArgumentException("Sender email cannot be empty", nameof(fromEmail));
            if (string.IsNullOrWhiteSpace(toName)) throw new ArgumentException("Recipient name cannot be empty", nameof(toName));
            if (string.IsNullOrWhiteSpace(toEmail)) throw new ArgumentException("Recipient email cannot be empty", nameof(toEmail));

            if (body == null) throw new ArgumentNullException(nameof(body));

            newemail.From.Add(new MailboxAddress(fromName, fromEmail));
            newemail.To.Add(new MailboxAddress(toName, toEmail));

            newemail.Body = body;
        }
    }
}
