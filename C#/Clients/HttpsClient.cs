using EgressAssess.Models;

namespace EgressAssess.Clients
{
    class HttpsClient : ClientBase
    {
        public HttpsClient()
        {
            ClientType = ClientType.HTTPS;
            Port = 443;
        }
    }
}