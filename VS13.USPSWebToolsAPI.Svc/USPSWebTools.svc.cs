using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;

namespace VS13.USPS {
    //
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.NotAllowed)]
    public class USPSWebTools:IUSPSWebTools {
        //Members

        //Interface
        public USPSWebTools() { }
        public DataSet TrackRequest(string itemNumber) {
            //
            DataSet response = null;
            try {
                response = new USPSGateway().TrackRequest(itemNumber);
            }
            catch (Exception ex) { throw new FaultException<USPSFault>(new USPSFault(ex.Message),"Service Error"); }
            return response;
        }
        public DataSet TrackFieldRequest(string itemNumber) {
            //
            DataSet response = null;
            try {
                response = new USPSGateway().TrackFieldRequest(itemNumber);
            }
            catch(Exception ex) { throw new FaultException<USPSFault>(new USPSFault(ex.Message), "Service Error"); }
            return response;
        }
        public DataSet TrackFieldRequests(string[] itemNumbers) {
            //
            DataSet response = null;
            try {
                response = new USPSGateway().TrackFieldRequests(itemNumbers);
            }
            catch(Exception ex) { throw new FaultException<USPSFault>(new USPSFault(ex.Message), "Service Error"); }
            return response;
        }

        public DataSet VerifyAddress(string firmName,string address1,string address2,string city,string state,string zip5,string zip4) {
            //
            DataSet response = new DataSet();
            try {
                DataSet ds = new USPSGateway().VerifyAddress(firmName, address1, address2, city, state, zip5, zip4);
                if (ds != null) response.Merge(ds);
            }
            catch(Exception ex) { throw new FaultException<USPSFault>(new USPSFault(ex.Message), "Service Error"); }
            return response;
        }
        public DataSet LookupCityState(string zip5) {
            //
            DataSet response = new DataSet();
            try {
                DataSet ds = new USPSGateway().LookupCityState(zip5);
                if (ds != null) response.Merge(ds);
            }
            catch(Exception ex) { throw new FaultException<USPSFault>(new USPSFault(ex.Message), "Service Error"); }
            return response;
        }
        public DataSet LookupZipCode(string firmName,string address1,string address2,string city,string state) {
            //
            DataSet response = new DataSet();
            try {
                DataSet ds = new USPSGateway().LookupZipCode(firmName,address1,address2,city,state);
                if (ds != null) response.Merge(ds);
            }
            catch (Exception ex) { throw new FaultException<USPSFault>(new USPSFault(ex.Message),"Service Error"); }
            return response;
        }
    }
}
