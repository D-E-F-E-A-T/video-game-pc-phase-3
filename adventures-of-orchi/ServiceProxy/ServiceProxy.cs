using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using System.Net;
using Windows.Networking.Connectivity;
using System.Net.Http;
using System.Net.Http.Headers;

namespace ServiceProxy
{
    public sealed class ServiceProxy
    {
        public ServiceProxy()
        {

        }

        public IEnumerable<BuildCommand> Build()
        {
            IEnumerable<BuildCommand> retVal = null;

            bool isConnected = CheckWebServicesConnection();

            //if (!isConnected)
            //{
                DefaultWorldBuilder defaultWorldBuilder = new DefaultWorldBuilder();
                retVal = defaultWorldBuilder.Build();
            //}
            //else
            //{
            //    NetworkWorldBuilder networkWorldBuilder = new NetworkWorldBuilder();
            //    retVal = networkWorldBuilder.GetWorldAsync().GetResults();
            //}

            return retVal;
        }


        public bool CheckWebServicesConnection()
        {
        
            ConnectionProfile connections = NetworkInformation.GetInternetConnectionProfile();
            return connections != null && connections.GetNetworkConnectivityLevel() == NetworkConnectivityLevel.InternetAccess;
        }
    }
}
