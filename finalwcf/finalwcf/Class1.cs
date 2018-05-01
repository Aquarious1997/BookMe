using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace finalwcf
{
    public class Class1
    {
        private string name;
        private string password;
        private string email;
        private string new_password;
        private string ip;
    

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string New_password
        {
            get
            {
                return new_password;
            }

            set
            {
                new_password = value;
            }
        }

        public string Ip
        {
            get
            {
                return ip;
            }

            set
            {
                ip = value;
            }
        }

        
    }
}