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
    partial class Form_Transaction : Form
    {
        public Form_Transaction()
        {
            InitializeComponent();
        }

        DataSet dS;
        SqlDataAdapter sDA_offers;
        SqlDataAdapter sDA_sellers;
        SqlDataAdapter sDA_transaction;
        SQLConnector sCon;
        int TransID;

        public void setData(int transid, SQLConnector scon)
        {
            sCon = scon;
            dS = new DataSet();
            TransID = transid;
            if (transid >= 0)
            {
                lb_id.Text = "Trans-ID: " + transid;
            }

            //load DataSets
            sDA_offers = sCon.getOffers_List(dS, null);
            sDA_sellers = sCon.getSellers_List_FullName(dS, null);
            sDA_transaction = sCon.getTransaction(dS, "transaction", null, TransID);

            //set Data to Form-Elements
            lBox_offer.DataSource = dS.Tables["offers"];
            lBox_offer.DisplayMember = "OfferName";
            lBox_offer.ValueMember = "OfferID";
            lBox_seller.DataSource = dS.Tables["sellers"];
            lBox_seller.DisplayMember = "SellerName";
            lBox_seller.ValueMember = "SellerID";
            if (dS.Tables["transaction"].Rows.Count > 0)
            {
                lb_id.Text = "Trans-ID: " + dS.Tables["transaction"].Rows[0]["ID"];
                lBox_offer.SelectedValue = dS.Tables["transaction"].Rows[0]["offerID"];
                lBox_seller.SelectedValue = dS.Tables["transaction"].Rows[0]["sellerID"];
                nTB_contingent.Text = ((int)dS.Tables["transaction"].Rows[0]["seller_contingent"]).ToString();
            }


        }

        private void bt_OK_Click(object sender, EventArgs e)
        {
            bool ok = true;

            if (dS.Tables["transaction"].Rows.Count == 0)
            {
                dS.Tables["transaction"].Rows.Add();
            }

            if (dS.Tables["transaction"].Rows.Count > 0)
            {
                dS.Tables["transaction"].Rows[0]["offerID"] = lBox_offer.SelectedValue;
                dS.Tables["transaction"].Rows[0]["sellerID"] = lBox_seller.SelectedValue;
                dS.Tables["transaction"].Rows[0]["seller_contingent"] = nTB_contingent.IntValue;
            }


            if (sDA_transaction != null)
            {
                try
                {
                    SqlCommandBuilder sCB = new SqlCommandBuilder(sDA_transaction);
                    sDA_transaction.Update(dS, "transaction");

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
            sCon.writeNonQuery("DELETE FROM transaction WHERE ID = " + TransID);
            this.Close();
        }

        private void lBox_offer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lBox_offer.SelectedIndex >= 0)
            {
                nTB_ship_capa.Text = ((int)dS.Tables["offers"].Rows[lBox_offer.SelectedIndex]["Ship Capa"]).ToString();
            }
        }

        private void lBox_seller_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lBox_seller.SelectedIndex >= 0)
            {
                nTB_seller_eff.Text = ((decimal)dS.Tables["sellers"].Rows[lBox_seller.SelectedIndex]["efficiency"]).ToString();
            }
        }


        
    }
}
