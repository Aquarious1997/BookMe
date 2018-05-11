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
        public void adname1(string name)
        {
            addy2.showe1.Add(name);
            //throw new NotImplementedException();
        }
        public void updateItem(int ind, string bus, string cap)
        {
            addy2 y = new addy2();
            y.update(ind, bus, cap);
        }
        public void updateCapacity(string cap, int index)
        {

            addy2.showe5.RemoveAt(index);
            addy2.showe5.Insert(index, cap);





        }
        public void adname2(string name)
        {
            addy2.showe2.Add(name);
            //throw new NotImplementedException();
        }

        public void adname3(string name)
        {
            addy2.showe3.Add(name);
            //throw new NotImplementedException();
        }

        public void adname4(string name)
        {
            addy2.showe4.Add(name);
            //throw new NotImplementedException();
        }

        public void adname5(string name)
        {
            addy2.showe5.Add(name);
            //throw new NotImplementedException();
        }

        public void delete1(int index)
        {
            addy2.showe1.RemoveAt(index);
            //throw new NotImplementedException();
        }

        public void delete2(int index)
        {
            addy2.showe2.RemoveAt(index);
            // throw new NotImplementedException();
        }

        public void delete3(int index)
        {
            addy2.showe3.RemoveAt(index);
            // throw new NotImplementedException();
        }

        public void delete4(int index)
        {
            addy2.showe4.RemoveAt(index);
            //throw new NotImplementedException();
        }

        public void delete5(int index)
        {
            addy2.showe5.RemoveAt(index);
            //throw new NotImplementedException();
        }

        public void deletepp(int index)
        {
            addy2 t = new addy2();
            t.deletpp(index);
            // throw new NotImplementedException();
        }

        public void isaf(string service, string route, string routee, string buses, string capacity)
        {
            addy fp = new addy();
            fp.Service = service;
            fp.Route = route;
            fp.Routee = routee;
            fp.Bus = buses;
            fp.Capacity = capacity;

            addy2.db.Add(fp);
            //throw new NotImplementedException();
        }

        public List<addy> showAll3()
        {
            return addy2.db;
            //throw new NotImplementedException();
        }

        public List<string> showName1()
        {
            return addy2.showe1;
            // throw new NotImplementedException();
        }

        public List<string> showName2()
        {
            return addy2.showe2;
            // throw new NotImplementedException();
        }

        public List<string> showName3()
        {
            return addy2.showe3;
            //throw new NotImplementedException();
        }

        public List<string> showName4()
        {
            return addy2.showe4;
            //throw new NotImplementedException();
        }

        public List<string> showName5()
        {
            return addy2.showe5;
            //throw new NotImplementedException();
        }

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

        public bool cchangee(string name, string password, string new_password)
        {
            bool is_val = false;
            foreach (CustClass1 i in CustClass2.db)
            {
                if (i.Password == password && i.Name == name)
                {
                    i.Password = new_password;
                    is_val = true;

                }
            }
            
            return is_val;
            //throw new NotImplementedException();
        }

        public bool creset(string name, string email, string npassword)
        {
            bool iseq = false;
            foreach (Class1 i in Class2.db)
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

        public bool islog(string name, string password)
        {
            bool isf = false;
            foreach(CustClass1 r in CustClass2.db)
            {
                if(r.Name== name && r.Password == password)
                {
                    isf = true;
                }
            }
            return isf;
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

        public List<CustClass1> showAll2()
        {
            return CustClass2.db;
           // throw new NotImplementedException();
        }
    }
}
