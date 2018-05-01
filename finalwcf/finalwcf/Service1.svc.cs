using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace finalwcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public bool changee(string name,string password, string new_password)
        {
            bool is_val = false;
            foreach(Class1 i in Class2.db)
            {
                if (i.Password == password && i.Name==name )
                {
                    i.Password = new_password;
                    is_val = true;

                }
                
            }
            //throw new NotImplementedException();
            return is_val;
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public void isadd(string name, string password, string email, string ip)
        {
            Class1 fr = new Class1();
            fr.Name = name;
            fr.Password = password;
            fr.Email = email;
            
            fr.Ip = ip;

            Class2.db.Add(fr);

            //throw new NotImplementedException();
        }

        public bool islogin(string name, string password)
        {
            bool iseqr = false;
            foreach (Class1 i in Class2.db)
            {
                if (i.Name == name && i.Password == password)
                {
                    
                   iseqr = true;
                }
            }
            return iseqr;
            //throw new NotImplementedException();
        }

        public bool reset(string name,string email,string new_password)
        {
            bool iseq = false;
            foreach (Class1 i in Class2.db)
            {
                if (i.Name==name && i.Email == email)
                {
                    i.Password = new_password;
                    iseq = true;
                }
            }
            return iseq;
            //throw new NotImplementedException();
        }
        public  List<Class1> showAll()
          {
            return Class2.db;
        }
}
}
