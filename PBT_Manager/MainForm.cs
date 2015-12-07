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
using DBLib;

namespace PBT_Manager
{
    public partial class MainForm : Form
    {

        SQLConnector sCon;
        DataSet dS_main;
        SqlDataAdapter current_sDA = null;
        ScopeFactory scopeFactory;



        public MainForm()
        {

            InitializeComponent();
            dS_main = new DataSet();
            sCon = new SQLConnector("config.xml");
            bt_update_dGV_main.Enabled = false;
            scopeFactory = new ScopeFactory(sCon.Connection, sCon.Connection);

        }



        private void bt_update_dGV_main_Click(object sender, EventArgs e)
        {
            if (current_sDA != null)
            {
                try
                {
                    SqlCommandBuilder sCB = new SqlCommandBuilder(current_sDA);

                    current_sDA.Update(dS_main, dS_main.Tables[0].TableName);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Update Error!\nSQL-Server Update Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void bt_edit_ships_Click(object sender, EventArgs e)
        {
            dS_main.Tables.Clear();
            current_sDA = sCon.getShips_List(dS_main, dGV_main);
            bt_update_dGV_main.Text = "Save Table: ships";
            bt_update_dGV_main.Enabled = true;
        }

        private void bt_edit_location_Click(object sender, EventArgs e)
        {
            dS_main.Tables.Clear();
            current_sDA = sCon.getLocations_List(dS_main, dGV_main);
            bt_update_dGV_main.Text = "Save Table: locations";
            bt_update_dGV_main.Enabled = true;
        }

        private void bt_edit_sellers_Click(object sender, EventArgs e)
        {
            dS_main.Tables.Clear();
            current_sDA = sCon.getSellers_List(dS_main, dGV_main);
            bt_update_dGV_main.Text = "Save Table: sellers";
            bt_update_dGV_main.Enabled = true;
        }

        private void bt_edit_customers_Click(object sender, EventArgs e)
        {
            dS_main.Tables.Clear();
            current_sDA = sCon.getCustomers_List(dS_main, dGV_main);
            bt_update_dGV_main.Text = "Save Table: customers";
            bt_update_dGV_main.Enabled = true;
        }


        private void bt_show_ship_routes_name_Click(object sender, EventArgs e)
        {
            dS_main.Tables.Clear();
            current_sDA = sCon.getShip_Route_List(dS_main, dGV_main);
            bt_update_dGV_main.Text = "Save Table: N/A";
            bt_update_dGV_main.Enabled = false;
        }

        private void bt_show_ship_tours_Click(object sender, EventArgs e)
        {
            dS_main.Tables.Clear();
            current_sDA = sCon.getShip_Tours_List(dS_main, dGV_main);
            bt_update_dGV_main.Text = "Save Table: N/A";
            bt_update_dGV_main.Enabled = false;
        }

        private void bt_show_offers_Click(object sender, EventArgs e)
        {
            dS_main.Tables.Clear();
            current_sDA = sCon.getOffers_List(dS_main, dGV_main);
            bt_update_dGV_main.Text = "Save Table: N/A";
            bt_update_dGV_main.Enabled = false;
        }

        private void bt_show_transactions_Click(object sender, EventArgs e)
        {
            dS_main.Tables.Clear();
            current_sDA = sCon.getTransactions_List(dS_main, dGV_main, "");
            bt_update_dGV_main.Text = "Save Table: N/A";
            bt_update_dGV_main.Enabled = false;
        }

        private void bt_show_passengers_Click(object sender, EventArgs e)
        {
            dS_main.Tables.Clear();
            current_sDA = sCon.getPassengers_List(dS_main, dGV_main);
            bt_update_dGV_main.Text = "Save Table: N/A";
            bt_update_dGV_main.Enabled = false;
        }

        private void bt_add_ship_route_Click(object sender, EventArgs e)
        {
            Forms.Form_ship_route sr_form = new Forms.Form_ship_route();
            sr_form.setData(-1, sCon);
            sr_form.ShowDialog();
            if (sr_form.DialogResult == DialogResult.OK) sCon.refresh(current_sDA, dS_main, dGV_main);
        }

        private void bt_add_ship_tour_Click(object sender, EventArgs e)
        {
            Forms.Form_ship_tour st_form = new Forms.Form_ship_tour();
            st_form.setData(-1, sCon);
            st_form.ShowDialog();
            if (st_form.DialogResult == DialogResult.OK) sCon.refresh(current_sDA, dS_main, dGV_main);
        }

        private void bt_add_offer_Click(object sender, EventArgs e)
        {
            Forms.Form_offer of_form = new Forms.Form_offer();
            of_form.setData(-1, sCon);
            of_form.ShowDialog();
            if (of_form.DialogResult == DialogResult.OK) sCon.refresh(current_sDA, dS_main, dGV_main);
        }


        private void bt_add_transaction_Click(object sender, EventArgs e)
        {
            Forms.Form_Transaction tf_form = new Forms.Form_Transaction();
            tf_form.setData(-1, sCon);
            tf_form.ShowDialog();
            if (tf_form.DialogResult == DialogResult.OK) sCon.refresh(current_sDA, dS_main, dGV_main);
        }

        private void bt_add_passengers_Click(object sender, EventArgs e)
        {
            Forms.Form_Passenger ps_form = new Forms.Form_Passenger();
            ps_form.setData(-1, 0, sCon);
            ps_form.ShowDialog();
            if (ps_form.DialogResult == DialogResult.OK) sCon.refresh(current_sDA, dS_main, dGV_main);
        }




        private void dGV_main_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex < dGV_main.RowCount - 1)
            {
                switch (dS_main.Tables[0].TableName)
                {
                    case "ship_routes":
                        Forms.Form_ship_route sr_form = new Forms.Form_ship_route();
                        sr_form.setData((int)dS_main.Tables[dS_main.Tables[0].TableName].Rows[e.RowIndex]["RouteID"], sCon);
                        sr_form.ShowDialog();
                        if (sr_form.DialogResult == DialogResult.OK) sCon.refresh(current_sDA, dS_main, dGV_main);
                        break;

                    case "ship_tours":
                        Forms.Form_ship_tour st_form = new Forms.Form_ship_tour();
                        st_form.setData((int)dS_main.Tables[dS_main.Tables[0].TableName].Rows[e.RowIndex]["TourID"], sCon);
                        st_form.ShowDialog();
                        if (st_form.DialogResult == DialogResult.OK) sCon.refresh(current_sDA, dS_main, dGV_main);
                        break;

                    case "offers":
                        Forms.Form_offer of_form = new Forms.Form_offer();
                        of_form.setData((int)dS_main.Tables[dS_main.Tables[0].TableName].Rows[e.RowIndex]["OfferID"], sCon);
                        of_form.ShowDialog();
                        if (of_form.DialogResult == DialogResult.OK) sCon.refresh(current_sDA, dS_main, dGV_main);
                        break;

                    case "transactions":
                        Forms.Form_Transaction tf_form = new Forms.Form_Transaction();
                        tf_form.setData((int)dS_main.Tables[dS_main.Tables[0].TableName].Rows[e.RowIndex]["TransID"], sCon);
                        tf_form.ShowDialog();
                        if (tf_form.DialogResult == DialogResult.OK) sCon.refresh(current_sDA, dS_main, dGV_main);
                        break;

                    case "passengers":
                        Forms.Form_Passenger ps_form = new Forms.Form_Passenger();
                        ps_form.setData((int)dS_main.Tables[dS_main.Tables[0].TableName].Rows[e.RowIndex]["PassengerID"], -1, sCon);
                        ps_form.ShowDialog();
                        if (ps_form.DialogResult == DialogResult.OK) sCon.refresh(current_sDA, dS_main, dGV_main);
                        break;


                }
            }
        }

        private void bt_refresh_scope_Click(object sender, EventArgs e)
        {
            scopeFactory.refreshServerScope(1);
        }























    }
}