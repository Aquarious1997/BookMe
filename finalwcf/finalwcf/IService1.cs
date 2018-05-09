﻿using System;
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
