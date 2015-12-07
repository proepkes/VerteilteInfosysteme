using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBLib.Synchronization;

namespace Seller_Client
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_tools_Click(object sender, EventArgs e)
        {
            new ToolsForm().Show(this);
        }

        private void btn_synchronize_Click(object sender, EventArgs e)
        {
            new DbSynchronizer().Synchronize();
        }
    }
}
