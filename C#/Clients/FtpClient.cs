namespace EgressAssess.Clients
{
    class FtpClient : ClientBase
    {
        public FtpClient()
        {
            ClientType = Models.ClientType.FTP;
            Port = 21;
        }
    }
}