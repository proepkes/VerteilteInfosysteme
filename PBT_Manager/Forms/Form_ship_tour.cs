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

namespace PBT_Manager.Forms
{
    partial class Form_ship_tour : Form
    {
        public Form_ship_tour()
        {
            InitializeComponent();
        }

        DataSet dS;
        SqlDataAdapter sDA_routes;
        SqlDataAdapter sDA_ships;
        SqlDataAdapter sDA_tour;
        SQLConnector sCon;
        int TourID;

        public void setData(int tourid, SQLConnector scon)
        {
            sCon = scon;
            dS = new DataSet();
            TourID = tourid;
            if (tourid >= 0)
            {
                lb_id.Text = "Tour-ID: " + tourid;
            }

            //load ship, route Data from Server
            sDA_routes = sCon.getShip_Route_List_sort(dS, null);
            sDA_ships = sCon.getShips_List(dS, null);
            sDA_tour = sCon.getShip_Tour(dS, "tour", null, tourid);

            //set Data to Form-Elements
            lBox_ship.DataSource = dS.Tables["ships"];
            lBox_ship.DisplayMember = "name";
            lBox_ship.ValueMember = "ShipID";
            lBox_route.DataSource = dS.Tables["ship_routes"];
            lBox_route.DisplayMember = "RouteName";
            lBox_route.ValueMember = "RouteID";
            if (dS.Tables["tour"].Rows.Count > 0)
            {
                lb_id.Text = "Tour-ID: " + dS.Tables["tour"].Rows[0]["ID"];
                lBox_ship.SelectedValue = dS.Tables["tour"].Rows[0]["shipID"];
                lBox_route.SelectedValue = dS.Tables["tour"].Rows[0]["routeID"];
                dTP_sailingDate.Value = (DateTime)dS.Tables["tour"].Rows[0]["sailing_time"];
                dTP_sailingTime.Value = (DateTime)dS.Tables["tour"].Rows[0]["sailing_time"];
                dTP_returnDate.Value = (DateTime)dS.Tables["tour"].Rows[0]["return_time"];
                dTP_returnTime.Value = (DateTime)dS.Tables["tour"].Rows[0]["return_time"];
                nTB_tour_costs.Text = ((Decimal)dS.Tables["tour"].Rows[0]["tour_costs"]).ToString();
                tB_name.Text = (string)dS.Tables["tour"].Rows[0]["name"];
            }


        }

        private void bt_OK_Click(object sender, EventArgs e)
        {
            bool ok = true;

            if (dS.Tables["tour"].Rows.Count == 0)
            {
                dS.Tables["tour"].Rows.Add();
            }

            if (dS.Tables["tour"].Rows.Count > 0)
            {
                dS.Tables["tour"].Rows[0]["shipID"] = lBox_ship.SelectedValue;
                dS.Tables["tour"].Rows[0]["routeID"] = lBox_route.SelectedValue;
                dS.Tables["tour"].Rows[0]["sailing_time"] = DateTime.ParseExact(
                    dTP_sailingDate.Value.Date.ToString("yyyy-MM-dd") +dTP_sailingTime.Value.ToString(" HH:mm"), 
                    "yyyy-MM-dd HH:mm", System.Globalization.CultureInfo.InvariantCulture);
                dS.Tables["tour"].Rows[0]["return_time"] = DateTime.ParseExact(
                    dTP_returnTime.Value.Date.ToString("yyyy-MM-dd") + dTP_returnTime.Value.ToString(" HH:mm"),
                    "yyyy-MM-dd HH:mm", System.Globalization.CultureInfo.InvariantCulture); 
                dS.Tables["tour"].Rows[0]["tour_costs"] = nTB_tour_costs.DecimalValue;
                dS.Tables["tour"].Rows[0]["name"] = tB_name.Text;
            }


            if (sDA_tour != null)
            {
                try
                {
                    SqlCommandBuilder sCB = new SqlCommandBuilder(sDA_tour);
                    sDA_tour.Update(dS, "tour");

                }
                catch (Exception ex)
                {
                    ok = false;
                    MessageBox.Show(ex.Message.ToString(), "Update Error!\nSQL-Server Update Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (ok) this.Close();
        }

        private void bt_about_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            sCon.writeNonQuery("DELETE FROM ship_tours WHERE ID = " + TourID);
            this.Close();
        }

        private void lBox_ship_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (lBox_ship.SelectedIndex >= 0 && lBox_route.SelectedIndex >= 0)
            {
                nTB_tour_costs.Text = ((decimal)dS.Tables["ships"].Rows[lBox_ship.SelectedIndex]["costs_km"] * (decimal)dS.Tables["ship_routes"].Rows[lBox_route.SelectedIndex]["distance_km"]).ToString();
                tB_name.Text = "Tour: [Route: " + (int)dS.Tables["ship_routes"].Rows[lBox_route.SelectedIndex]["RouteID"] + "], [Ship: " + ((int)dS.Tables["ships"].Rows[lBox_ship.SelectedIndex]["shipID"] + "]");
            }


        }

        private void lBox_route_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lBox_ship.SelectedIndex >= 0 && lBox_route.SelectedIndex >= 0)
            {
                nTB_tour_costs.Text = ((decimal)dS.Tables["ships"].Rows[lBox_ship.SelectedIndex]["costs_km"] * (decimal)dS.Tables["ship_routes"].Rows[lBox_route.SelectedIndex]["distance_km"]).ToString();
                tB_name.Text = "Tour: [Route: " + (int)dS.Tables["ship_routes"].Rows[lBox_route.SelectedIndex]["RouteID"] + "], [Ship: " + ((int)dS.Tables["ships"].Rows[lBox_ship.SelectedIndex]["shipID"] + "]");

            }
        }


    }
}
