using System.Net;
using System.Net.Sockets;

namespace Facility.Entities
{
    public class HttpUrlAdder : Adder
    {
        public HttpUrlAdder(IPAddress[] ips, int port)
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
                    yield return @$"netsh http add urlacl url=http://{ip}:{Port}/ user=\Todos";
                }
            }
        }
    }
}