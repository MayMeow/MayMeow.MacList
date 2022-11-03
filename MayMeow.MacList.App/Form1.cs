using System.Net.NetworkInformation;

namespace MayMeow.MacList.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            foreach (NetworkInterface networkInterface in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (networkInterface.NetworkInterfaceType != NetworkInterfaceType.Ethernet && networkInterface.NetworkInterfaceType != NetworkInterfaceType.Wireless80211) continue;
                string[] row = {networkInterface.OperationalStatus.ToString(), networkInterface.Description, networkInterface.GetPhysicalAddress().ToString(), networkInterface.NetworkInterfaceType.ToString() };
                ListViewItem item = new ListViewItem(row);

                listView1.Items.Add(item);
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
    }
}