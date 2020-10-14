using EgressAssess.Models;

namespace EgressAssess.Clients
{
    class HttpClient : ClientBase
    {
        public HttpClient()
        {
            ClientType = ClientType.HTTP;
            Port = 80;
        }
    }
}