using EgressAssess.Models;

namespace EgressAssess.Core
{
    class ConnectionTest
    {
        ClientType Client;

        public ConnectionTest(ClientType Client)
        {
            this.Client = Client;
        }

        public bool TestConnection
        {
            get
            {
                return true;
            }
        }
    }
}