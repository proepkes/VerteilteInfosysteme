using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        SqlConnection Server_con;
        SqlConnection Client_con;
        Scope scope;

        public MainForm()
        {
            InitializeComponent();

            Server_con = new SqlConnection(XMLReader.ServerConnection_String());
            Client_con = new SqlConnection(XMLReader.ClientConnection_String());
            scope = new Scope(Server_con, Client_con);
            if (XMLReader.ScopeInit()) scope.Init_Scopes();
        }

        private void btn_tools_Click(object sender, EventArgs e)
        {
            new ToolsForm().Show(this);
        }

        private void btn_synchronize_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"SellerID: " + XMLReader.SellerID() + @"\nServer: " + XMLReader.ServerConnection_String() + @"\nClient: " + XMLReader.ClientConnection_String());
            new DbSynchronizer().Synchronize();
        }
    }
}
