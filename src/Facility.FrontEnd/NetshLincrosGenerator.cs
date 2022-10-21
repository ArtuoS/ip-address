using Facility.Entities;
using System.Net;

namespace Facility.FrontEnd
{
    public partial class NetshLincrosGenerator : Form
    {
        private readonly int PORT = 56768;
        public NetshLincrosGenerator()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            var ipHostEntry = Dns.GetHostEntry(Dns.GetHostName());
            if (ipHostEntry.AddressList.Any())
            {
                var httpUrlAdder = new HttpUrlAdder(ipHostEntry.AddressList, PORT);
                SetHttpUrls(httpUrlAdder.GetFormattedIpv4Urls());

                var bindingProtocolAdder = new BindingProtocolAdder(ipHostEntry.AddressList, PORT);
                SetBindingProtocols(bindingProtocolAdder.GetFormattedIpv4Urls());
            }
        }

        private void SetHttpUrls(IEnumerable<string> formattedCommands)
        {
            foreach (var formattedCommand in formattedCommands)
            {
                rtbIps.Text += $"{formattedCommand}\n";
            }
        }

        private void SetBindingProtocols(IEnumerable<string> formattedCommands)
        {
            foreach (var formattedCommand in formattedCommands)
            {
                rtbBindingProtocol.Text += $"{formattedCommand}\n";
            }
        }
    }
}