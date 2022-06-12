using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace rrt.Services
{
    public interface IAuthService
    {
        bool Login(string Email, string Password);
        bool Register(string Email, string Name, string Password, bool RememberMe);
    }

    public class AuthService : IAuthService
    {
        private readonly DatabaseContext _context;

        public AuthService(DatabaseContext context)
        {
            _context = context;
        }

        public bool Login(string Email, string Password)
        {
            var user = _context.Users.Find.FirstOrDefault(x => x.Email == Email && x.PasswordHash == Password.GetHashCode());
            if (user == null) return false;
            else return true;
        }

        public bool Register(string Email, string Name, string Password, bool RememberMe)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);
                _context.Users.Add(new
                {
                    Email = Email,
                    Name = Name,
                    PasswordHash = Password.GetHashCode(),
                    RememberMe = RememberMe
                });
                _context.SaveChanges();
                return true;
            }
            catch (FormatException)
            {
                return false;
            };

        }

    }
}
