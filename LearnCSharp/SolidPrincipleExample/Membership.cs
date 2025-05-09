using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrincipleExample
{
    public class Membership
    {
        public void CreateAccount(string email, string password)
        {
            new DBUtility().Read("");
            string pass = new Encryption().Encrypt(password);


            new EmailSender().SendRegistrationEmail(email);


        }
    }
}
