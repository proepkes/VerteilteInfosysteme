using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Seller_Client
{

    public static class XMLReader
    {
        public static string ServerConnection_String()
        {
            return XMLreader.Instance.Server_Connection_String;
        }

        public static string ClientConnection_String()
        {
            return XMLreader.Instance.Client_Connection_String;
        }

        public static int SellerID()
        { 
            return XMLreader.Instance.SellerID;
        }

        public static bool ScopeInit()
        {
            return XMLreader.Instance.ScopeInit;
        }
    }
    


    
    
    class XMLreader  //Singleton pattern!!!
    {
        
        private static XMLreader instance;

        public XMLreader() { loadConfig(); }

        public static XMLreader Instance
        {
           get 
           {
              if (instance == null)
              {
                instance = new XMLreader();
              }
              return instance;
           }
        }

        private string config_path = "config.xml";

        public string Config_path
        {
            get { return config_path; }
            set { config_path = value; loadConfig(); }
        }

        private string server_constr;

        public string Server_Connection_String
        {
            get { return server_constr; }
            set { server_constr = value; }
        }
        private string client_constr;

        public string Client_Connection_String
        {
            get { return client_constr; }
            set { client_constr = value; }
        }
        private int sellerID;

        public int SellerID
        {
            get { return sellerID; }
            set { sellerID = value; }
        }

        private bool scopeInit;

        public bool ScopeInit
        {
            get { return scopeInit; }
            set { scopeInit = value; }
        }

        private void loadConfig()
        {
            try
            {
                XmlDocument cfgXML = new XmlDocument();
                cfgXML.Load(config_path);
                int Server_sqlID = -1;
                int Client_sqlID = -1;
                sellerID = -1;

                foreach (XmlNode node in cfgXML.DocumentElement)
                {
                    if (node.Name == "Server_Connection")
                    {
                        Server_sqlID = int.Parse(node.InnerText);

                    }
                    if (node.Name == "Client_Connection")
                    {
                        Client_sqlID = int.Parse(node.InnerText);

                    }

                    if (node.Name == "SellerID")
                    {
                        sellerID = int.Parse(node.InnerText);

                    }

                    if (node.Name == "ScopeInit")
                    {
                        scopeInit = bool.Parse(node.InnerText);
                    }

                    if (Server_sqlID != -1 && node.Name == "SQL-Server" && node.Attributes[0].Value == "" + Server_sqlID)
                    {
                        server_constr = node["Connection"].InnerText;
                    }
                    if (Client_sqlID != -1 && node.Name == "SQL-Server" && node.Attributes[0].Value == "" + Client_sqlID)
                    {
                        client_constr = node["Connection"].InnerText;
                    }

                }




            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString(), "XMLReader Exception - XMLReader.loadconfig()", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
            }
        }


    }
}


 



