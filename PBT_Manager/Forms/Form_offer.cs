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
    partial class Form_offer : Form
    {
        public Form_offer()
        {
            InitializeComponent();
        }


        DataSet dS;
        
        SqlDataAdapter sDA_offer;
        SqlDataAdapter sDA_tour;
        SQLConnector sCon;
        int OfferID;

        public void setData(int offerid, SQLConnector scon)
        {
            sCon = scon;
            dS = new DataSet();
            OfferID = offerid;
            if (offerid >= 0)
            {
                lb_id.Text = "Offer-ID: " + offerid;
            }

            //load tours, offer Data from Server
            sDA_tour = sCon.getShip_Tours_List(dS, null);
            sDA_offer = sCon.getOffer(dS, "offer", null, OfferID);

            
            lBox_tour.DataSource = dS.Tables["ship_tours"];
            lBox_tour.DisplayMember = "TourName";
            lBox_tour.ValueMember = "TourID";

            if (dS.Tables["offer"].Rows.Count > 0)
            {
                lb_id.Text = "Offer-ID: " + dS.Tables["offer"].Rows[0]["ID"];
                lBox_tour.SelectedValue = dS.Tables["offer"].Rows[0]["tourID"];
                dTP_createDate.Value = (DateTime)dS.Tables["offer"].Rows[0]["create_date"];
                dTP_createTime.Value = (DateTime)dS.Tables["offer"].Rows[0]["create_date"];
                dTP_expireDate.Value = (DateTime)dS.Tables["offer"].Rows[0]["expire_date"];
                dTP_expireTime.Value = (DateTime)dS.Tables["offer"].Rows[0]["expire_date"];
                
                nTB_price.Text = ((Decimal)dS.Tables["offer"].Rows[0]["price"]).ToString();
                tB_name.Text = (string)dS.Tables["offer"].Rows[0]["name"];
            }


        }

        private void bt_OK_Click(object sender, EventArgs e)
        {
            bool ok = true;

            if (dS.Tables["offer"].Rows.Count == 0)
            {
                dS.Tables["offer"].Rows.Add();
            }

            if (dS.Tables["offer"].Rows.Count > 0)
            {
                dS.Tables["offer"].Rows[0]["tourID"] = lBox_tour.SelectedValue;
                dS.Tables["offer"].Rows[0]["create_date"] = DateTime.ParseExact(
                    dTP_createDate.Value.Date.ToString("yyyy-MM-dd") + dTP_createTime.Value.ToString(" HH:mm"),
                    "yyyy-MM-dd HH:mm", System.Globalization.CultureInfo.InvariantCulture);
                dS.Tables["offer"].Rows[0]["expire_date"] = DateTime.ParseExact(
                    dTP_expireDate.Value.Date.ToString("yyyy-MM-dd") + dTP_expireTime.Value.ToString(" HH:mm"),
                    "yyyy-MM-dd HH:mm", System.Globalization.CultureInfo.InvariantCulture);
                dS.Tables["offer"].Rows[0]["price"] = nTB_price.DecimalValue;
                dS.Tables["offer"].Rows[0]["name"] = tB_name.Text;
            }


            if (sDA_tour != null)
            {
                try
                {
                    SqlCommandBuilder sCB = new SqlCommandBuilder(sDA_offer);
                    sDA_offer.Update(dS, "offer");

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
            sCon.writeNonQuery("DELETE FROM offers WHERE ID = " + OfferID);
            this.Close();
        }

        private void lBox_tour_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lBox_tour.SelectedIndex >= 0)
            {
                nTB_tour_costs.Text = ((Decimal)dS.Tables["ship_tours"].Rows[lBox_tour.SelectedIndex]["Tour Costs"]).ToString();
                nTB_capacity.Text = ((int)dS.Tables["ship_tours"].Rows[lBox_tour.SelectedIndex]["Ship Capacity"]).ToString();
                tB_name.Text = "Offer: [Tour: " + (int)dS.Tables["ship_tours"].Rows[lBox_tour.SelectedIndex]["TourID"] + "]" ;

            }
        }
    }
}
