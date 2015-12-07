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
    partial class Form_Passenger : Form
    {
        public Form_Passenger()
        {
            InitializeComponent();
        }
        DataSet dS;
        SqlDataAdapter sDA_sellers;
        SqlDataAdapter sDA_transactions;
        SqlDataAdapter sDA_customers;
        SqlDataAdapter sDA_passenger;
        SqlDataAdapter sDA_passenger_seller;
        SQLConnector sCon;
        int PassengerID;

        public void setData(int passengerid, int sellerID, SQLConnector scon)
        {
            sCon = scon;
            dS = new DataSet();
            PassengerID = passengerid;
            if (passengerid >= 0)
            {
                lb_id.Text = "Passenger-ID: " + passengerid;
            }

            //load DataSets
            sDA_sellers = sCon.getSellers_List_FullName(dS, null);
            sDA_customers = sCon.getCustomers_List_FullName(dS, null);
            
            
            sDA_passenger = sCon.getPassenger(dS, "passenger", null, PassengerID);

            //set Data to Form-Elements
            lBox_customer.DataSource = dS.Tables["customers"];
            lBox_customer.DisplayMember = "CustomerName";
            lBox_customer.ValueMember = "CustomerID";

            coB_select_seller.DataSource = dS.Tables["sellers"];
            coB_select_seller.DisplayMember = "SellerName";
            coB_select_seller.ValueMember = "SellerID";

            if (sellerID >= 0)  coB_select_seller.SelectedValue = sellerID;            


            if (dS.Tables["passenger"].Rows.Count > 0)
            {
                if (sellerID < 0)
                {
                    sDA_passenger_seller = sCon.getPassenger_Seller(dS, "passenger_seller", null, PassengerID);
                    if (dS.Tables["passenger_seller"].Rows.Count > 0)  coB_select_seller.SelectedValue = dS.Tables["passenger_seller"].Rows[0]["sellerID"];
                }

                lb_id.Text = "Passenger-ID: " + dS.Tables["passenger"].Rows[0]["ID"];
                lBox_customer.SelectedValue = dS.Tables["passenger"].Rows[0]["customerID"];
                lBox_transaction.SelectedValue = dS.Tables["passenger"].Rows[0]["transactionID"];
                nTB_price.Text = ((decimal)dS.Tables["passenger"].Rows[0]["price"]).ToString();
                //if ((byte)dS.Tables["passenger"].Rows[0]["is_paid"] == 0) cB_is_paid.Checked = false; else cB_is_paid.Checked = true;
                cB_is_paid.Checked = Convert.ToBoolean((byte)dS.Tables["passenger"].Rows[0]["is_paid"]);
                dTP_booked_date.Value = (DateTime)dS.Tables["passenger"].Rows[0]["booked_time"];
                dTP_booked_time.Value = (DateTime)dS.Tables["passenger"].Rows[0]["booked_time"];
            }


        }

        private void bt_OK_Click(object sender, EventArgs e)
        {
            bool ok = true;

            if (dS.Tables["passenger"].Rows.Count == 0)
            {
                dS.Tables["passenger"].Rows.Add();
            }
            if (lBox_transaction.SelectedIndex >= 0)
            {
                if (dS.Tables["passenger"].Rows.Count > 0)
                {

                    dS.Tables["passenger"].Rows[0]["customerID"] = lBox_customer.SelectedValue;
                    dS.Tables["passenger"].Rows[0]["transactionID"] = lBox_transaction.SelectedValue;
                    dS.Tables["passenger"].Rows[0]["price"] = nTB_price.DecimalValue;
                    dS.Tables["passenger"].Rows[0]["is_paid"] = Convert.ToInt16(cB_is_paid.Checked);

                    dS.Tables["passenger"].Rows[0]["booked_time"] = DateTime.ParseExact(
                        dTP_booked_date.Value.Date.ToString("yyyy-MM-dd") + dTP_booked_time.Value.ToString(" HH:mm"),
                        "yyyy-MM-dd HH:mm", System.Globalization.CultureInfo.InvariantCulture);
                }



                if (sDA_passenger != null)
                {
                    try
                    {
                        SqlCommandBuilder sCB = new SqlCommandBuilder(sDA_passenger);
                        sDA_passenger.Update(dS, "passenger");

                    }
                    catch (Exception ex)
                    {
                        ok = false;
                        MessageBox.Show(ex.Message.ToString(), "Update Error!\nSQL-Server Update Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else { ok = false; MessageBox.Show("You have to select a valid Transaction!", "No valid Transaction!", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            if (ok == true) this.Close();
        }

        private void bt_about_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_del_Click(object sender, EventArgs e)
        {
            sCon.writeNonQuery("DELETE FROM transaction WHERE ID = " + PassengerID);
            this.Close();
        }



        private void coB_select_seller_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (coB_select_seller.SelectedIndex >= 0)
            {
                if (dS.Tables.Contains("transactions"))
                {
                    dS.Tables["transactions"].Clear();
                }
                
                sDA_transactions = sCon.getTransactions_List(dS, null, " sellerID = " + ((int)dS.Tables["sellers"].Rows[coB_select_seller.SelectedIndex]["SellerID"]).ToString());
                //sDA_transactions = sCon.getTransactions_List(dS, null, " sellerID = " +coB_select_seller.SelectedValue);
                
                lBox_transaction.DataSource = dS.Tables["transactions"];
                lBox_transaction.DisplayMember = "OfferName";
                lBox_transaction.ValueMember = "TransID";
            }


        }



    }
}
