using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace finalwcf
{
    [DataContract]
    public class CustClass1
    {
        private string name;
        private string password;
        private string npassword;
        private string email;
        private string ip;
        [DataMember]
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
        [DataMember]
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
        [DataMember]
        public string Npassword
        {
            get
            {
                return npassword;
            }

            set
            {
                npassword = value;
            }
        }
        [DataMember]
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
        [DataMember]
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