using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShealedExample
{
    // public class Admin : User [ Not possible ] 
    public class Admin : User
    {
        public sealed override void Login()
        {
            base.Login();
        }
    }
}
