using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBLib.Provisioning;

namespace Seller_Client
{
    public partial class ToolsForm : Form
    {
        public ToolsForm()
        {
            InitializeComponent();
        }

        private void btn_provision_Click(object sender, EventArgs e)
        {
            if (sender == btn_provisionClient)
            {
                new ClientProvisioner().ProvisionClient();
            }
            else if (sender == btn_provisionServer)
            {
                new ServerProvisioner().ProvisionServer();
            }
        }
    }
}
