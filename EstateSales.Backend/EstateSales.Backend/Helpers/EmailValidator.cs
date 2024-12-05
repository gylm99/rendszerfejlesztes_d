using System.Net.Mail;

namespace HelpersProject.EmailHelpers
{
    public static class EmailValidator
    {
        public static bool ValidateEmail(string mailaddress)
        {
            try
            {
                var email = new MailAddress(mailaddress);
            }
            catch
            {
                return false;
            }
            return true;

        }
        public static bool IsValidEmail(this string mailaddress)
        {
            return ValidateEmail(mailaddress);
        }
    }
}
