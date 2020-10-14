using EgressAssess.Models;

namespace EgressAssess.Clients
{
    class ClientBase
    {
        public ClientType ClientType { get; set; }
        public DataType DataType { get; set; }
        public int Size { get; set; }
        public string Target { get; set; }
        public int Port { get; set; }
        public bool NoPing { get; set; }
    }
}