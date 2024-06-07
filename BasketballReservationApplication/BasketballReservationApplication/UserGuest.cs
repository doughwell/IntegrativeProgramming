using LoginNamespace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginNamespace
{
    public class UserGuest : UserAccount
    {
        private string contactNumber;
        public UserGuest(string name, string email, string contact) : base(name, email)
        {
            this.contactNumber = contact;
        }
        public UserGuest(string name, string email, string password, string contact) : base(name, email, password)
        {
            this.contactNumber = contact;
        }
        public override bool validateLogin(string email, string password)
        {
            return base.validateLogin(email, password);
        }
        public string getConactNumber()
        {
            return this.contactNumber;
        }
    }
}
