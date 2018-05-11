using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace finalwcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);
        [OperationContract]
        bool islogin(string name, string password);
        [OperationContract]
        void isadd(string name, string password, string email, string ip);
        [OperationContract]
        bool reset(string name, string email, string new_password);
        [OperationContract]
        bool changee(string name,string password, string new_password);
        [OperationContract]
        List<Class1> showAll();

        [OperationContract]
        void isad(string name, string password,string email,string ip);
        [OperationContract]
        bool islog(string name,string password);
        [OperationContract]
       bool creset(string name, string email, string npassword);
        [OperationContract]
        bool cchangee(string name, string password, string npassword);
        [OperationContract]
        List<CustClass1> showAll2();
        [OperationContract]
        void isaf(string service, string route, string routee, string buses, string capacity);
        [OperationContract]
        List<string> showName1();
        [OperationContract]
        List<string> showName2();
        [OperationContract]
        List<string> showName3();
        [OperationContract]
        List<string> showName4();
        [OperationContract]
        List<string> showName5();
        [OperationContract]
        void adname1(string name);
        [OperationContract]
        void adname2(string name);

        [OperationContract]
        void adname3(string name);
        [OperationContract]
        void adname4(string name);
        [OperationContract]
        void adname5(string name);
        [OperationContract]
        void deletepp(int index);
        [OperationContract]
        void delete1(int index);
        [OperationContract]
        void delete2(int index);
        [OperationContract]
        void delete3(int index);
        [OperationContract]
        void delete4(int index);
        [OperationContract]
        void delete5(int index);
        [OperationContract]
        List<addy> showAll3();
        [OperationContract]
        void updateCapacity(string cap, int index);
        [OperationContract]
        void updateItem(int ind, string bus, string cap);


        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
