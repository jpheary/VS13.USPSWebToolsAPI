using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.ServiceModel;
using System.Threading;

namespace VS13.USPS {
    //
    public class USPSGateway {
        //Members

        //Interface
        public USPSGateway() { }
        public CommunicationState ServiceState { get { return new USPSWebToolsClient().State; } }
        public string ServiceAddress { get { return new USPSWebToolsClient().Endpoint.Address.Uri.AbsoluteUri; } }

        public static AddressValidateResponse VerifyAddress(string firmName,string address1,string address2,string city,string state,string zip5,string zip4) {
            //
            AddressValidateResponse response = new AddressValidateResponse();
            USPSWebToolsClient client = new USPSWebToolsClient();
            try {
                DataSet ds = client.VerifyAddress(firmName,address1,address2,city,state,zip5,zip4);
                if (ds != null) response.Merge(ds);
                client.Close();
            }
            catch (TimeoutException te) { client.Abort(); throw new ApplicationException(te.Message); }
            catch (FaultException<USPSFault> cfe) { client.Abort(); throw new ApplicationException(cfe.Detail.Message); }
            catch (FaultException fe) { client.Abort(); throw new ApplicationException(fe.Message); }
            catch (CommunicationException ce) { client.Abort(); throw new ApplicationException(ce.Message); }
            return response;
        }
        public static CityStateLookupResponse LookupCityState(string zip5) {
            //
            CityStateLookupResponse response = new CityStateLookupResponse();
            USPSWebToolsClient client = new USPSWebToolsClient();
            try {
                DataSet ds = client.LookupCityState(zip5);
                if (ds != null) response.Merge(ds);
                client.Close();
            }
            catch (TimeoutException te) { client.Abort(); throw new ApplicationException(te.Message); }
            catch (FaultException<USPSFault> cfe) { client.Abort(); throw new ApplicationException(cfe.Detail.Message); }
            catch (FaultException fe) { client.Abort(); throw new ApplicationException(fe.Message); }
            catch (CommunicationException ce) { client.Abort(); throw new ApplicationException(ce.Message); }
            return response;
        }
        public static ZipCodeLookupResponse LookupZipCode(string firmName,string address1,string address2,string city,string state) {
            //
            ZipCodeLookupResponse response = new ZipCodeLookupResponse();
            USPSWebToolsClient client = new USPSWebToolsClient();
            try {
                DataSet ds = client.LookupZipCode(firmName,address1,address2,city,state);
                if (ds != null) response.Merge(ds);
                client.Close();
            }
            catch (TimeoutException te) { client.Abort(); throw new ApplicationException(te.Message); }
            catch (FaultException<USPSFault> cfe) { client.Abort(); throw new ApplicationException(cfe.Detail.Message); }
            catch (FaultException fe) { client.Abort(); throw new ApplicationException(fe.Message); }
            catch (CommunicationException ce) { client.Abort(); throw new ApplicationException(ce.Message); }
            return response;
        }

        public static TrackResponse TrackRequest(string itemNumber) {
            //
            TrackResponse response = new TrackResponse();
            USPSWebToolsClient client = new USPSWebToolsClient();
            try {
                DataSet ds = client.TrackRequest(itemNumber);
                if (ds != null) response.Merge(ds);
                client.Close();
            }
            catch (TimeoutException te) { client.Abort(); throw new ApplicationException(te.Message); }
            catch (FaultException<USPSFault> cfe) { client.Abort(); throw new ApplicationException(cfe.Detail.Message); }
            catch (FaultException fe) { client.Abort(); throw new ApplicationException(fe.Message); }
            catch (CommunicationException ce) { client.Abort(); throw new ApplicationException(ce.Message); }
            return response;
        }
        public static TrackFieldResponse TrackFieldRequest(string itemNumber) {
            //
            TrackFieldResponse response = new TrackFieldResponse();
            USPSWebToolsClient client = new USPSWebToolsClient();
            try {
                DataSet ds = client.TrackFieldRequest(itemNumber);
                if (ds != null) response.Merge(ds);
                client.Close();
            }
            catch (TimeoutException te) { client.Abort(); throw new ApplicationException(te.Message); }
            catch (FaultException<USPSFault> cfe) { client.Abort(); throw new ApplicationException(cfe.Detail.Message); }
            catch (FaultException fe) { client.Abort(); throw new ApplicationException(fe.Message); }
            catch (CommunicationException ce) { client.Abort(); throw new ApplicationException(ce.Message); }
            return response;
        }
        public static TrackFieldResponse TrackFieldRequests(string[] itemNumbers) {
            //
            TrackFieldResponse response = new TrackFieldResponse();
            USPSWebToolsClient client = new USPSWebToolsClient();
            try {
                DataSet ds = client.TrackFieldRequests(itemNumbers);
                if (ds != null) response.Merge(ds);
                client.Close();
            }
            catch (TimeoutException te) { client.Abort(); throw new ApplicationException(te.Message); }
            catch (FaultException<USPSFault> cfe) { client.Abort(); throw new ApplicationException(cfe.Detail.Message); }
            catch (FaultException fe) { client.Abort(); throw new ApplicationException(fe.Message); }
            catch (CommunicationException ce) { client.Abort(); throw new ApplicationException(ce.Message); }
            return response;
        }
    }
}