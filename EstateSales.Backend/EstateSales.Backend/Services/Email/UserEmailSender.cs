using EstateSales.Backend.Datas.Entities;
using EstateSales.Backend.Responses;
using HelpersProject.EmailHelpers;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using MimeKit;

namespace EstateSales.Backend.Services.Email
{
    public class UserEmailSender : IEmailSender<LoginUser>
    {
        private readonly SmtpSettings _smtpSettings;
        private Response _response = new Response();

        public UserEmailSender(IOptions<SmtpSettings> options)
        {
            _smtpSettings = options.Value;
        }

        public bool IsSuccess => _response.IsSuccess;
        public string Error => _response.Error;

        public async Task SendConfirmationLinkAsync(LoginUser user, string email, string confirmationLink)
        {
            if (!email.IsValidEmail())
            {
                _response = new Response($"A megadott email cím ({email}) érvénytelen!");
                return;
            }
            else if (user.Email is null || !user.Email.IsValidEmail())
            {
                _response = new Response($"A megadott email cím ({email}) érvénytelen!");
                return;
            }

            var builder = new BodyBuilder();
            builder.HtmlBody = $@"
                    <html>
                        <body>
                            <h2>Kedves {user.Email}!</h2>
                            <p>Köszönjük, hogy regisztráltál! Kérjük, erősítsd meg a regisztrációdat a következő linkre kattintva:</p>
                            <p><a href='{confirmationLink}'>Regisztráció megerősítése</a></p>
                            <p>Üdvözlettel,<br>Az Ottleszek.hu csapata</p>
                        </body>
                    </html>";

            builder.TextBody = $"Kedves {user.Email}!\n\nKérjük, erősítsd meg a regisztrációdat az alábbi linkre kattintva:\n{confirmationLink}\n\nÜdvözlettel,\nAz Ottleszek.hu csapata";

            using var newemail = new MimeMessage();
            newemail.SetEmailMessage("Regisztráció", "noreplay@ottleszek.hu", user.Email, user.Email, builder.ToMessageBody());


            using var smtpClient = new SmtpClient();
            try
            {
                // smtp.Connect(host: "sandbox.smtp.mailtrap.io", port: 465,useSsl:false);
                // smtpClient.Connect("sandbox.smtp.mailtrap.io", 465, MailKit.Security.SecureSocketOptions.StartTls);
                // smtpClient.Authenticate("993bd8fcb037f9", "8e3d7fb1e7bdbd");

                smtpClient.Connect(_smtpSettings.Host, _smtpSettings.Port, MailKit.Security.SecureSocketOptions.StartTls);
                smtpClient.Authenticate(_smtpSettings.Username, _smtpSettings.Password);

                await smtpClient.SendAsync(newemail);
            }
            catch (SmtpCommandException ex)
            {
                Console.WriteLine($"SMTP parancshiba történt: {ex.Message}");
                Console.WriteLine($"Hiba típusa: {ex.ErrorCode}");
                Console.WriteLine($"SMTP kód: {ex.StatusCode}");
                _response.SetNewError(ex.Message);
            }
            catch (SmtpProtocolException ex)
            {
                Console.WriteLine($"SMTP protokoll hiba történt: {ex.Message}");
                _response.SetNewError(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ismeretlen hiba történt: {ex.Message}");
                _response.SetNewError(ex.Message);
            }
            finally
            {
                await smtpClient.DisconnectAsync(true);
            }
        }

        public async Task SendPasswordResetCodeAsync(LoginUser user, string email, string resetCode)
        {
            if (!email.IsValidEmail())
            {
                _response = new Response($"A megadott email cím ({email}) érvénytelen!");
                return;
            }
            else if (user.Email is null || !user.Email.IsValidEmail())
            {
                _response = new Response(($"A megadott email cím ({email}) érvénytelen!"));
                return;
            }

            var builder = new BodyBuilder();
            builder.HtmlBody = $@"
                    <html>
                        <body>
                            <h2>Kedves {user.Email}!</h2>
                            <p>Erre a linkre kattintva kérhet új jelszót:</p>
                            <p><a href='{resetCode}'>Új jelszó kérése</a></p>
                            <p>Üdvözlettel,<br>Az Ottleszek.hu csapata</p>
                        </body>
                    </html>";

            builder.TextBody = $"Kedves {user.Email}!\n\nErre a linkre kattintva kérhet új jelszót:</p>:\n{resetCode}\n\nÜdvözlettel,\nAz Ottleszek.hu csapata";

            using var newemail = new MimeMessage();
            newemail.SetEmailMessage("Regisztráció", "noreplay@ottleszek.hu", user.Email, user.Email, builder.ToMessageBody());


            using var smtpClient = new SmtpClient();
            try
            {
                // smtp.Connect(host: "sandbox.smtp.mailtrap.io", port: 465,useSsl:false);
                // smtpClient.Connect("sandbox.smtp.mailtrap.io", 465, MailKit.Security.SecureSocketOptions.StartTls);
                // smtpClient.Authenticate("993bd8fcb037f9", "8e3d7fb1e7bdbd");

                smtpClient.Connect(_smtpSettings.Host, _smtpSettings.Port, MailKit.Security.SecureSocketOptions.StartTls);
                smtpClient.Authenticate(_smtpSettings.Username, _smtpSettings.Password);

                await smtpClient.SendAsync(newemail);
            }
            catch (SmtpCommandException ex)
            {
                Console.WriteLine($"SMTP parancshiba történt: {ex.Message}");
                Console.WriteLine($"Hiba típusa: {ex.ErrorCode}");
                Console.WriteLine($"SMTP kód: {ex.StatusCode}");
                _response.SetNewError(ex.Message);
            }
            catch (SmtpProtocolException ex)
            {
                Console.WriteLine($"SMTP protokoll hiba történt: {ex.Message}");
                _response.SetNewError(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ismeretlen hiba történt: {ex.Message}");
                _response.SetNewError(ex.Message);
            }
            finally
            {
                await smtpClient.DisconnectAsync(true);
            }
        }

        public async Task SendPasswordResetLinkAsync(LoginUser user, string email, string resetLink)
        {

            if (!email.IsValidEmail())
            {
                _response = new Response($"A megadott email cím ({email}) érvénytelen!");
                return;
            }
            else if (user.Email is null || !user.Email.IsValidEmail())
            {
                _response = new Response(($"A megadott email cím ({email}) érvénytelen!"));
                return;
            }

            var builder = new BodyBuilder();
            builder.HtmlBody = $@"
                    <html>
                        <body>
                            <h2>Kedves {user.Email}!</h2>
                            <p>Erre a linkre kattintva kérhet új jelszót:</p>
                            <p><a href='{resetLink}'>Új jelszó kérése</a></p>
                            <p>Üdvözlettel,<br>Az Ottleszek.hu csapata</p>
                        </body>
                    </html>";

            builder.TextBody = $"Kedves {user.Email}!\n\nErre a linkre kattintva kérhet új jelszót:</p>:\n{resetLink}\n\nÜdvözlettel,\nAz Ottleszek.hu csapata";

            using var newemail = new MimeMessage();
            newemail.SetEmailMessage("Regisztráció", "noreplay@ottleszek.hu", user.Email, user.Email, builder.ToMessageBody());


            using var smtpClient = new SmtpClient();
            try
            {
                // smtp.Connect(host: "sandbox.smtp.mailtrap.io", port: 465,useSsl:false);
                // smtpClient.Connect("sandbox.smtp.mailtrap.io", 465, MailKit.Security.SecureSocketOptions.StartTls);
                // smtpClient.Authenticate("993bd8fcb037f9", "8e3d7fb1e7bdbd");

                smtpClient.Connect(_smtpSettings.Host, _smtpSettings.Port, MailKit.Security.SecureSocketOptions.StartTls);
                smtpClient.Authenticate(_smtpSettings.Username, _smtpSettings.Password);

                await smtpClient.SendAsync(newemail);
            }
            catch (SmtpCommandException ex)
            {
                Console.WriteLine($"SMTP parancshiba történt: {ex.Message}");
                Console.WriteLine($"Hiba típusa: {ex.ErrorCode}");
                Console.WriteLine($"SMTP kód: {ex.StatusCode}");
                _response.SetNewError(ex.Message);
            }
            catch (SmtpProtocolException ex)
            {
                Console.WriteLine($"SMTP protokoll hiba történt: {ex.Message}");
                _response.SetNewError(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ismeretlen hiba történt: {ex.Message}");
                _response.SetNewError(ex.Message);
            }
            finally
            {
                await smtpClient.DisconnectAsync(true);
            }


        }
    }
}
