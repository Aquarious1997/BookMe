using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace custwcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
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

        public void isad(string name, string password, string email, string ip)
        {
         
          
                CustClass1 f = new CustClass1();
                f.Name = name;
                f.Password = password;
                f.Email = email;
                f.Ip = ip;

                CustClass2.db.Add(f);
                //throw new NotImplementedException();
          
        }
       public  List<CustClass1> showAll()
        {
            return CustClass2.db;
        }
        public bool islog(string name, string password)
        {
            bool isf = false;
            foreach(CustClass1 i in CustClass2.db)
            {
                if(i.Name==name && i.Password == password)
                {
                    isf = true;
                }
            }

            return isf;
           // throw new NotImplementedException();
        }

        public bool creset(string name, string email, string npassword)
        {
            bool iseq = false;
            foreach (CustClass1 i in CustClass2.db)
            {
                if (i.Name == name && i.Email == email)
                {
                    i.Password = npassword;
                    iseq = true;
                }
            }
            return iseq;
            //throw new NotImplementedException();
        }

        public bool cchangee(string name, string password, string npassword)
        {
            bool is_val = false;
            foreach (CustClass1 i in CustClass2.db)
            {
                if (i.Password == password && i.Name == name)
                {
                    i.Password = npassword;
                    is_val = true;

                }

            }
            //throw new NotImplementedException();
            return is_val;
           
        }
    }
}
