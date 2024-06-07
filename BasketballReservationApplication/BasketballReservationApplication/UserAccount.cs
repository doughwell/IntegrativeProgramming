using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginNamespace
{
    public class UserAccount
    {
        private string name;
        protected string email;
        protected string password;
        public UserAccount(string name, string email) //for guest login
        {
            this.name = name;
            this.email = email;
        }
        public UserAccount(string name, string email, string password) //for student/admin login
        {
            this.name = name;
            this.email = email;
            this.password = password;
        }
        public virtual bool validateLogin(string email, string password)
        {
            return this.email == email && this.password == password;
        }
        public string getName()
        {
            return this.name;
        }
        public string getStuEmail()
        {
            return this.email;
        }
    }
}