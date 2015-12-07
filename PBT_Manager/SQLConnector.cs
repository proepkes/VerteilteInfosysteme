using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.Xml;


namespace PBT_Manager
{
    class SQLConnector
    {
        string conStr = "";//@"Data Source=Server\SQLExpress;Initial Catalog=database;User ID=username;Password=password";

        public string SQLConnectionString
        {
            get { return conStr; }           
        }
        SqlConnection con;

        public SqlConnection Connection
        {
            get { return con; }
        }

        public SQLConnector(string pathCFG_XML)
        {
      
            
            try
            {
                XmlDocument cfgXML = new XmlDocument();
                cfgXML.Load(pathCFG_XML);
                int sqlID = -1;

                foreach (XmlNode node in cfgXML.DocumentElement)
                {
                    if (node.Name == "SQL-Server_Connection")
                    {
                        sqlID = int.Parse(node.InnerText);
                        
                    }
                    if (sqlID != -1 && node.Name == "SQL-Server" && node.Attributes[0].Value == ""+sqlID)
                    {
                        conStr = node["Connection"].InnerText;
                    }
                }

                
                

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString(), "SQLConnector/XMLReader Error!\nConstructor Exception - XML read", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
            }

            if (conStr != "")
            {

                try
                {                                                        
                    con = new SqlConnection(conStr);
                    con.Open();


                    
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message.ToString(), "SQLConnector Error!\nConstructor Exception - SQLConnection.Open", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(2);
                }


            }
            else
            {
                MessageBox.Show("Empty Connection-String!\n", "SQLConnector Error!\nConstructor Exception - Invalide Connection-String", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(2);
            }
        }





        //SQL Select Commands

        public SqlDataAdapter getShips_List(DataSet dS, DataGridView dGV)
        {
            return getList(
            @"SELECT ID AS 'ShipID', regNo, capacity, name, discription, costs_km, speed_kmh FROM ships "
            , dS, "ships", dGV); 
        }


        public SqlDataAdapter getLocations_List(DataSet dS, DataGridView dGV)
        {
            return getList(
            @"SELECT ID AS 'LocationID', name, pos_x, pos_y FROM locations "
            , dS, "locations", dGV); 
        }

        public SqlDataAdapter getSellers_List(DataSet dS, DataGridView dGV)
        {
            return getList(
            @"SELECT ID AS 'SellerID', forename, surname, efficiency FROM sellers "
            , dS, "sellers", dGV);
        }

        public SqlDataAdapter getCustomers_List(DataSet dS, DataGridView dGV)
        {
            return getList(
            @"SELECT ID AS 'CustomerID', surname, forename, IBAN, BIC FROM customers "
            , dS, "customers", dGV);
        }

        public SqlDataAdapter getSellers_List_FullName(DataSet dS, DataGridView dGV)
        {
            return getList(
            @"SELECT ID AS 'SellerID', CONCAT(forename,' ',surname) AS 'SellerName', efficiency FROM sellers "
            , dS, "sellers", dGV);
        }

        public SqlDataAdapter getCustomers_List_FullName(DataSet dS, DataGridView dGV)
        {
            return getList(
            @"SELECT ID AS 'CustomerID', CONCAT(forename,' ',surname) AS 'CustomerName', IBAN, BIC FROM customers "
            , dS, "customers", dGV);
        }

        public SqlDataAdapter getLocations_List(DataSet dS, string dS_name, DataGridView dGV)
        {
            return getList(
            @"SELECT ID AS 'LocationID', name, pos_x, pos_y FROM locations "
            , dS, dS_name, dGV);
        }



        public SqlDataAdapter getShip_Route(DataSet dS, string dS_name, DataGridView dGV, int RouteID)
        {
            return getList(
            @"SELECT ID AS 'RouteID', ship_routes.name AS 'RouteName', from_locationID, to_locationID, distance_km FROM ship_routes WHERE ID = " + RouteID
            , dS, dS_name, dGV);
        }

        public SqlDataAdapter getShip_Route_List(DataSet dS, DataGridView dGV)
        {
            return getList(
            @"SELECT ship_routes.ID AS 'RouteID', ship_routes.name AS 'RouteName',  from_location.name AS 'FROM', to_location.name AS 'TO', distance_km " +
            
            " FROM ship_routes "+
            " INNER JOIN locations to_location ON ship_routes.to_locationID = to_location.ID "+
            " INNER JOIN locations from_location ON ship_routes.from_locationID = from_location.ID "
            ,dS,"ship_routes",dGV);
        }

        public SqlDataAdapter getShip_Route_List_sort(DataSet dS, DataGridView dGV)
        {
            return getList(
            @"SELECT ship_routes.ID AS 'RouteID', ship_routes.name AS 'RouteName', distance_km" +
            " FROM ship_routes " +
            " INNER JOIN locations to_location ON ship_routes.to_locationID = to_location.ID " +
            " INNER JOIN locations from_location ON ship_routes.from_locationID = from_location.ID "
            , dS, "ship_routes", dGV);
        }

        public SqlDataAdapter getShip_Tours_List(DataSet dS, DataGridView dGV)
        {
            return getList(
            @"SELECT ship_tours.ID AS 'TourID',ship_tours.name AS 'TourName', ship_tours.tour_costs AS 'Tour Costs', " +
            " ships.regNo AS 'Ship RegNo', ships.name AS 'Ship Name', ships.capacity AS 'Ship Capacity', ships.costs_km AS 'Ship Costs per km', " +
            " from_location.name AS 'FROM', to_location.name AS 'TO', "+
            " ship_tours.sailing_time AS 'Sailing Time', ship_tours.return_time AS 'Return Time', ship_routes.distance_km AS 'Distance in km' " +
            

            " FROM ship_tours " +
            " INNER JOIN ships ON ship_tours.shipID = ships.ID " +
            " INNER JOIN ship_routes ON ship_tours.routeID = ship_routes.ID "+
            " INNER JOIN locations to_location ON ship_routes.to_locationID = to_location.ID " +
            " INNER JOIN locations from_location ON ship_routes.from_locationID = from_location.ID " 
            , dS, "ship_tours", dGV);
        }

        public SqlDataAdapter getShip_Tour(DataSet dS, string dS_name, DataGridView dGV, int TourID)
        {
            return getList(
            @"SELECT * FROM ship_tours WHERE ID = " + TourID
            , dS, dS_name, dGV);
        }

        public SqlDataAdapter getOffers_List(DataSet dS, DataGridView dGV)
        {
            return getList(
            @"SELECT offers.ID AS 'OfferID', offers.name AS 'OfferName', offers.create_date AS 'Validity Start', offers.expire_date AS 'Validity End', offers.price AS 'Offer Price', "+
            " ship_tours.name AS 'Tour Name', ship_tours.tour_costs AS 'Tour Costs', ship_tours.sailing_time AS 'Sailing', ship_tours.return_time AS 'Return',  " +
            " ships.name AS 'Ship Name', ships.capacity AS 'Ship Capa', ship_routes.name AS 'Route Name'" +

            " FROM offers " +
            " INNER JOIN ship_tours ON offers.tourID = ship_tours.ID " +
            " INNER JOIN ships ON ship_tours.shipID = ships.ID " +
            " INNER JOIN ship_routes ON ship_tours.routeID = ship_routes.ID "
            , dS, "offers", dGV);
        }

        public SqlDataAdapter getOffer(DataSet dS, string dS_name, DataGridView dGV, int OfferID)
        {
            return getList(
            @"SELECT * FROM offers WHERE ID = " + OfferID
            , dS, dS_name, dGV);
        }


        public SqlDataAdapter getTransactions_List(DataSet dS, DataGridView dGV, string where)
        {
            string WHERE = "";
            if (where.Length > 0) WHERE = " WHERE " + where;
            return getList(
            @"SELECT transactions.ID AS 'TransID', offers.name AS 'OfferName', CONCAT(sellers.forename,' ',sellers.surname) AS 'SellerName', transactions.seller_contingent AS 'SellerCont.', COUNT(passengers.ID) AS 'sold', " +
            " ships.name AS 'Ship Name', ships.capacity AS 'ShipCapacity', ship_tours.name AS 'Tour Name', transactions.server_refresh_time AS 'lastRefresh'" +

            " FROM transactions " +
            " INNER JOIN offers ON transactions.offerID = offers.ID" +
            " INNER JOIN sellers ON transactions.sellerID = sellers.ID" +
            " INNER JOIN ship_tours ON offers.tourID = ship_tours.ID " +
            " INNER JOIN ships ON ship_tours.shipID = ships.ID " +
            " LEFT OUTER JOIN passengers ON passengers.transactionID = transactions.ID " +
            WHERE + " GROUP BY transactions.ID, offers.name, sellers.forename, sellers.surname, transactions.seller_contingent, ships.name, ships.capacity, ship_tours.name, transactions.server_refresh_time "
            , dS, "transactions", dGV);
        }

        public SqlDataAdapter getTransaction(DataSet dS, string dS_name, DataGridView dGV, int TransactionID)
        {
            return getList(
            @"SELECT * FROM transactions WHERE ID = " + TransactionID
            , dS, dS_name, dGV);
        }

        public SqlDataAdapter getPassengers_List(DataSet dS, DataGridView dGV)
        {
            return getList(
            @"SELECT passengers.ID AS 'PassengerID', CONCAT(customers.forename,' ',customers.surname) AS 'PassengerName', offers.name AS 'OfferName', "+
            " passengers.price AS 'Ticket Price', passengers.is_paid AS 'is paid', passengers.booked_time, " +
            " CONCAT(sellers.forename,' ',sellers.surname) AS 'SellerName' " +
            

            " FROM passengers " +
            " INNER JOIN transactions ON passengers.transactionID = transactions.ID " +
            " INNER JOIN customers ON passengers.customerID = customers.ID " +
            " INNER JOIN offers ON transactions.offerID = offers.ID" +
            " INNER JOIN sellers ON transactions.sellerID = sellers.ID" 
            , dS, "passengers", dGV);
        }

        public SqlDataAdapter getPassenger(DataSet dS, string dS_name, DataGridView dGV, int PassengerID)
        {
            return getList(
            @"SELECT * FROM passengers WHERE passengers.ID = " + PassengerID
            , dS, dS_name, dGV);
        }

        public SqlDataAdapter getPassenger_Seller(DataSet dS, string dS_name, DataGridView dGV, int PassengerID)
        {
            return getList(
            @"SELECT transactions.sellerID FROM passengers INNER JOIN transactions ON transactions.ID = passengers.transactionID WHERE passengers.ID = " + PassengerID
            , dS, dS_name, dGV);
        }



        public SqlDataAdapter getList(string cmdstr, DataSet dS, string dS_name, DataGridView dGV)
        {
            SqlDataAdapter sDA = null;
            try
            {
                SqlCommand cmd = new SqlCommand(cmdstr, con);

                if (con.State == ConnectionState.Closed) con.Open();
                sDA = new SqlDataAdapter(cmd);
                
                if (dS != null){
                    
                   
                    sDA.Fill(dS, dS_name);
                
                    if (dGV != null){
                        dGV.Columns.Clear();
                        dGV.DataSource = dS.Tables[dS_name];
                        dGV.Columns[0].ReadOnly = true;
                    }
                }

                cmd.Dispose();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString()+"\n\nCMDSTR:\n"+cmdstr, "SQLConnector Error!\nSQL-Server Select Exception - getList()", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return sDA;
        }

        public void refresh(SqlDataAdapter sDA, DataSet dS, DataGridView dGV)
        {
            if (dS.Tables.Count > 0)
            {
                string name = dS.Tables[0].TableName;
                dS.Tables.Clear();
                sDA.Fill(dS, name);
                dGV.DataSource = dS.Tables[dS.Tables[0].TableName];
            }
        }



        
        //SQL WRITE Command


        public void writeNonQuery(string cmdstr)
        {
            if (cmdstr.Length > 0)
            {
                try
                {
                    //MessageBox.Show(cmdstr);
                    if (con.State == ConnectionState.Closed) con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = cmdstr;
                    cmd.ExecuteNonQuery();
                    
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message.ToString(), "SQLConnector Error!\nMySQL Insert/Update Exception - writeNonQuery()", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }




        private string SafeGetString(SqlDataReader reader, string colName)
        {
            
            if (!reader.IsDBNull(reader.GetOrdinal(colName)))
                return reader.GetString(reader.GetOrdinal(colName)).Trim();
            else
                return string.Empty;
        }

        private int SafeGetInt(SqlDataReader reader, string colName)
        {
            try
            {
                if (!reader.IsDBNull(reader.GetOrdinal(colName)))
                    return reader.GetInt32(reader.GetOrdinal(colName));
                else
                    return -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString()+"\nSafeGetInt(reader , string colName = "+colName+")", "SQLConnector Error!\nSafeGetInt()", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        private bool SafeGetBool(SqlDataReader reader, string colName)
        {
            if (!reader.IsDBNull(reader.GetOrdinal(colName)))
                return  Convert.ToBoolean(reader.GetByte(reader.GetOrdinal(colName)));
            else
                return false;
        }

        private DateTime SafeGetDateTime(SqlDataReader reader, string colName)
        {
            if (!reader.IsDBNull(reader.GetOrdinal(colName)))
                return reader.GetDateTime(reader.GetOrdinal(colName));
            else
                return new DateTime(1900, 01, 01, 0, 0, 0);
        }





    }
}
