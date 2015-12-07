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
    partial class Form_ship_route : Form
    {
        public Form_ship_route()
        {
            InitializeComponent();
        }

        DataSet dS;
        SqlDataAdapter sDA_location;
        SqlDataAdapter sDA_route;
        SQLConnector sCon;
        int RouteID;

        public void setData(int routeid, SQLConnector scon)
        {
            sCon = scon;
            dS = new DataSet();
            RouteID = routeid;
            if (routeid >= 0)
            {
                lb_id.Text = "Route-ID: " + routeid;
            }

            //load Loaction Data from Server
            sDA_location = sCon.getLocations_List(dS, "from_location", null);
            sDA_location.Fill(dS, "to_location");           
            sDA_route = sCon.getShip_Route(dS, "route", null, routeid);

            //set Data to Form-Elements
            lBox_from_location.DataSource = dS.Tables["from_location"];
            lBox_from_location.DisplayMember = "name";
            lBox_from_location.ValueMember = "LocationID";
            lBox_to_location.DataSource = dS.Tables["to_location"];
            lBox_to_location.DisplayMember = "name";
            lBox_to_location.ValueMember = "LocationID";
            if (dS.Tables["route"].Rows.Count > 0)
            {
                lb_id.Text = "Route-ID: " + dS.Tables["route"].Rows[0]["RouteID"];
                lBox_from_location.SelectedValue = dS.Tables["route"].Rows[0]["from_locationID"];
                lBox_to_location.SelectedValue = dS.Tables["route"].Rows[0]["to_locationID"];
                tB_name.Text = (string)dS.Tables["route"].Rows[0]["RouteName"];
                nTB_distance.Text = ((Decimal)dS.Tables["route"].Rows[0]["distance_km"]).ToString();
            }


        }

        private void bt_OK_Click(object sender, EventArgs e)
        {
            bool ok = true;

            if (dS.Tables["route"].Rows.Count == 0)
            {
                dS.Tables["route"].Rows.Add();
            }

            if (dS.Tables["route"].Rows.Count > 0)
            {
                dS.Tables["route"].Rows[0]["from_locationID"] = lBox_from_location.SelectedValue;
                dS.Tables["route"].Rows[0]["to_locationID"] = lBox_to_location.SelectedValue;
                dS.Tables["route"].Rows[0]["RouteName"] = tB_name.Text;
                dS.Tables["route"].Rows[0]["distance_km"] = nTB_distance.DecimalValue;
            }


            if (sDA_route != null)
            {
                try
                {
                    SqlCommandBuilder sCB = new SqlCommandBuilder(sDA_route);
                    sDA_route.Update(dS, "route");

                }
                catch (Exception ex)
                {
                    ok = false;
                    MessageBox.Show(ex.Message.ToString(), "Update Error!\nSQL-Server Update Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (ok == true) this.Close();
        }

        private void bt_about_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_del_Click(object sender, EventArgs e)
        {
            sCon.writeNonQuery("DELETE FROM ship_routes WHERE ID = " + RouteID);
            this.Close();
        }

        private void lBox_from_location_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lBox_from_location.SelectedIndex >= 0 && lBox_to_location.SelectedIndex >= 0)
            {
                tB_name.Text = ((string)dS.Tables["from_location"].Rows[lBox_from_location.SelectedIndex]["name"] + " >> " + (string)dS.Tables["to_location"].Rows[lBox_to_location.SelectedIndex]["name"] + " (" + nTB_distance.DecimalValue +" km)");
            }
        }

        private void lBox_to_location_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lBox_from_location.SelectedIndex >= 0 && lBox_to_location.SelectedIndex >= 0)
            {
                tB_name.Text = ((string)dS.Tables["from_location"].Rows[lBox_from_location.SelectedIndex]["name"] + " >> " + (string)dS.Tables["to_location"].Rows[lBox_to_location.SelectedIndex]["name"] + " (" + nTB_distance.DecimalValue + " km)");
            }
        }

        private void nTB_distance_TextChanged(object sender, EventArgs e)
        {
            if (lBox_from_location.SelectedIndex >= 0 && lBox_to_location.SelectedIndex >= 0)
            {
                tB_name.Text = ((string)dS.Tables["from_location"].Rows[lBox_from_location.SelectedIndex]["name"] + " >> " + (string)dS.Tables["to_location"].Rows[lBox_to_location.SelectedIndex]["name"] + " (" + nTB_distance.DecimalValue + " km)");
            }
        }
    }
}
