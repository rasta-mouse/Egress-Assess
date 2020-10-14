using EgressAssess.Clients;

using System.Net.NetworkInformation;
using System.Text;

namespace EgressAssess.Core
{
    class ConnectionTest
    {
        ClientBase Client;

        public ConnectionTest(ClientBase Client)
        {
            this.Client = Client;
        }

        public bool TestConnection
        {
            get
            {
                if (TestICMP())
                {
                    CustomConsole.WriteLine($"{Client.Target} is UP on ICMP");
                    return true;
                }
                else
                {
                    CustomConsole.WriteError($"{Client.Target} is DOWN on ICMP");
                    return false;
                }
            }
        }

        bool TestICMP()
        {
            var sender = new Ping();
            var opts = new PingOptions
            {
                DontFragment = true
            };

            var data = Encoding.ASCII.GetBytes("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"); // 32 bytes
            var timeout = 120;

            var reply = sender.Send(Client.Target, timeout, data, opts);

            if (reply.Status == IPStatus.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}