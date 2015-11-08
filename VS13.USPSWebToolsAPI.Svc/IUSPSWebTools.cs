using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace VS13.USPS {
    [ServiceContract(Namespace = "http://VS13.USPS")]
    public interface IUSPSWebTools {
        //Tracking Interface        
        [OperationContract]
        [FaultContractAttribute(typeof(USPSFault),Action = "http://Argix.USPSFault")]
        DataSet TrackRequest(string itemNumber);
        [OperationContract]
        [FaultContractAttribute(typeof(USPSFault),Action = "http://Argix.USPSFault")]
        DataSet TrackFieldRequest(string itemNumber);
        [OperationContract]
        [FaultContractAttribute(typeof(USPSFault),Action = "http://Argix.USPSFault")]
        DataSet TrackFieldRequests(string[] itemNumbers);

        //Address Verification Interface
        [OperationContract]
        [FaultContractAttribute(typeof(USPSFault),Action = "http://Argix.USPSFault")]
        DataSet VerifyAddress(string firmName,string address1,string address2,string city,string state,string zip5,string zip4);
        [OperationContract]
        [FaultContractAttribute(typeof(USPSFault),Action = "http://Argix.USPSFault")]
        DataSet LookupCityState(string zip5);
        [OperationContract]
        [FaultContractAttribute(typeof(USPSFault),Action = "http://Argix.USPSFault")]
        DataSet LookupZipCode(string firmName,string address1,string address2,string city,string state);
    }

    [DataContract]
    public class USPSFault {
        private string mMessage = "";
        public USPSFault(string message) { this.mMessage = message; }
        [DataMember]
        public string Message { get { return this.mMessage; } set { this.mMessage = value; } }
    }

}
