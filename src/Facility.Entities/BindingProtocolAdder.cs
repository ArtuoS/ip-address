using System.Net;
using System.Net.Sockets;

namespace Facility.Entities
{
    public class BindingProtocolAdder : Adder
    {
        public BindingProtocolAdder(IPAddress[] ips, int port)
        {
            Ips = ips;
            Port = port;
        }

        private IPAddress[] Ips { get; set; }
        private int Port { get; set; }

        public override IEnumerable<string> GetFormattedIpv4Urls()
        {
            foreach (var ip in Ips)
            {
                if (ip.AddressFamily.Equals(AddressFamily.InterNetwork))
                {
                    yield return $"<binding protocol=\"http\" bindingInformation=\"*:{Port}:{ip}\" />";
                }
            }
        }
    }
}
