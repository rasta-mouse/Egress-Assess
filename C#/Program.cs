using CommandLine;

using System.Collections.Generic;

namespace EgressAssess
{
    class Program
    {
        class Options
        {
            [Option('c', "client", Required = true, HelpText = "The protocol to egress data over.")]
            public string Client { get; set; }

            [Option('t', "target", Required = true, HelpText = "The IP or hostname of the Egress-Assess server.")]
            public string Target { get; set; }

            [Option('v', "resolve", Required = false, HelpText = "Enable DNS resolution for ICMP transfers.")]
            public bool ResolveDNS { get; set; }

            [Option('m', "no-icmp", Required = false, HelpText = "Disable ping check.")]
            public bool NoPing { get; set; }

            [Option('x', "proxy", Required = false, HelpText = "Exfiltrate data using the system proxy.")]
            public bool Proxy { get; set; }

            [Option('u', "user-agent", Required = false, HelpText = "Assign a specific UserAgent (\"IE\",\"Moz\",\"Saf\"). Default's to random.")]
            public string UserAgent { get; set; }

            [Option('a', "actor", Required = false, HelpText = "Assign a malware profile to your traffic.")]
            public string Actor { get; set; }

            [Option('u', "username", Required = false, HelpText = "The username for the chosen client.")]
            public string Username { get; set; }

            [Option('p', "password", Required = false, HelpText = "The password for the chosen client.")]
            public string Password { get; set; }

            [Option('d', "datatype", Required = true, HelpText = "The data you want to generate and exfil. May contain filepath to transfer file.")]
            public string Datatype { get; set; }

            [Option('s', "size", Required = true, HelpText = "Size in MB to send.")]
            public int Size { get; set; }

            [Option('l', "loops", Required = false, HelpText = "How many times to re-run.")]
            public int Loops { get; set; }

            [Option('r', "report", Required = false, HelpText = "Write a report to console and disk. Default report location \"C:\\Egress-Assess\\report.txt\".")]
            public bool Report { get; set; }

            [Option('o', "port", Required = false, HelpText = "Specify a non-standard port for data transfer.")]
            public int Port { get; set; }

            [Option('x', "smtp-to", Required = false, HelpText = "The \"TO\" address you wish to specify for SMTP client.")]
            public string SMTPTo { get; set; }

            [Option('y', "smtp-from", Required = false, HelpText = "The \"FROM\" address you wish to specify for SMTP client.")]
            public string SMTPFrom { get; set; }

            [Option('z', "smtp-subject", Required = false, HelpText = "The subject you wish to specify for SMTP client.")]
            public string SMTPSubject { get; set; }
        }

        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<Options>(args)
                .WithParsed(RunOptions)
                .WithNotParsed(HandleParseError);
        }

        static void RunOptions(Options opts)
        {
            //handle options
        }
        static void HandleParseError(IEnumerable<Error> errs)
        {
            //handle errors
        }
    }
}