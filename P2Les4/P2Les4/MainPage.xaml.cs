using P2Les4.Classes;
using System;
using System.Net;
using Xamarin.Forms;

namespace P2Les4
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            //var address = Dns.GetHostAddresses("esp32.local")[0];
            //Console.WriteLine(address);
            serverIPEntry.Text = "192.168.2.26";
        }

        private void updateButton(object sender, EventArgs e)
        {
            Client client = new Client();
            string response = client.StartClient(serverIPEntry.Text, Int32.Parse(serverPortEntry.Text) , messageEntry.Text);
            Temperature.Text = null;
            Temperature.Text = response;
        }
    }
}
