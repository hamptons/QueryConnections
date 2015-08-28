using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueryServerConnections
{
    public partial class activeConnectionsForm : Form
    {
        private string list;

        private List<String> connectionResultList = new List<string>();

        //private string text = System.IO.File.ReadAllText(@"C:\Users\hamptons\Google Drive\Query Server Connections\testData.txt");

        public activeConnectionsForm()
        {
            InitializeComponent();
        }

        private void activeConnectionsForm_Load(object sender, EventArgs e)
        {
            this.connectionsListFlowLayoutPanel.Controls.Clear();

            //comment out while using test data
            foreach (String server in ServerList.GetServers())
            {
                connectionResultList.AddRange(RDPInfo.ListUsers(server).Where(x => !x.Contains("n/a")));
                //connectionResultList.AddRange(RDPInfo.ListUsers(server));
            }

            //use for testing purposes, otherwise comment out
            //connectionResultList.Clear();
            //connectionResultList.Add(text);
            //connectionResultList.Add(text);

            foreach (String result in connectionResultList)
            {
                activeConnectionUserControl fActiveConnectionUserControl = new activeConnectionUserControl(result);

                this.connectionsListFlowLayoutPanel.Controls.Add(fActiveConnectionUserControl);

                Console.WriteLine(result);
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            this.connectionsListFlowLayoutPanel.Controls.Clear();
            connectionResultList.Clear();

            //comment out while using test data
            foreach (String server in ServerList.GetServers())
            {
                connectionResultList.AddRange(RDPInfo.ListUsers(server).Where(x => !x.Contains("n/a")));
            }

            //use for testing purposes, otherwise comment out
            //connectionResultList.Add(text);
            //connectionResultList.Add(text);
            //connectionResultList.Add(text);

            foreach (String result in connectionResultList)
            {
                activeConnectionUserControl fActiveConnectionUserControl = new activeConnectionUserControl(result);

                this.connectionsListFlowLayoutPanel.Controls.Add(fActiveConnectionUserControl);

                Console.WriteLine(result);
            }
        }

        private void serverListPictureBox_Click(object sender, EventArgs e)
        {
            list = "Servers queried: \r";

            foreach (String server in ServerList.GetServers())
            {
                list = list + '\r' + server;
            }

            ////Console.WriteLine(list);
            MessageBox.Show(list);
        }
    }
}
