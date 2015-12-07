namespace PBT_Manager
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tLP_main = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bt_add_passengers = new System.Windows.Forms.Button();
            this.bt_show_passengers = new System.Windows.Forms.Button();
            this.bt_edit_customers = new System.Windows.Forms.Button();
            this.bt_add_transaction = new System.Windows.Forms.Button();
            this.bt_show_transactions = new System.Windows.Forms.Button();
            this.bt_edit_sellers = new System.Windows.Forms.Button();
            this.bt_add_offer = new System.Windows.Forms.Button();
            this.bt_show_offers = new System.Windows.Forms.Button();
            this.bt_add_ship_tour = new System.Windows.Forms.Button();
            this.bt_show_ship_tours = new System.Windows.Forms.Button();
            this.bt_add_ship_route = new System.Windows.Forms.Button();
            this.bt_show_ship_routes_name = new System.Windows.Forms.Button();
            this.bt_edit_location = new System.Windows.Forms.Button();
            this.bt_edit_ships = new System.Windows.Forms.Button();
            this.dGV_main = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.bt_update_dGV_main = new System.Windows.Forms.Button();
            this.bt_refresh_scope = new System.Windows.Forms.Button();
            this.tLP_main.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_main)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tLP_main
            // 
            this.tLP_main.ColumnCount = 3;
            this.tLP_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tLP_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLP_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tLP_main.Controls.Add(this.bt_refresh_scope, 0, 2);
            this.tLP_main.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tLP_main.Controls.Add(this.dGV_main, 1, 1);
            this.tLP_main.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.tLP_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLP_main.Location = new System.Drawing.Point(0, 0);
            this.tLP_main.Name = "tLP_main";
            this.tLP_main.RowCount = 4;
            this.tLP_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tLP_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLP_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tLP_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tLP_main.Size = new System.Drawing.Size(1384, 862);
            this.tLP_main.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.bt_add_passengers, 0, 19);
            this.tableLayoutPanel1.Controls.Add(this.bt_show_passengers, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.bt_edit_customers, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.bt_add_transaction, 0, 18);
            this.tableLayoutPanel1.Controls.Add(this.bt_show_transactions, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.bt_edit_sellers, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.bt_add_offer, 0, 17);
            this.tableLayoutPanel1.Controls.Add(this.bt_show_offers, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.bt_add_ship_tour, 0, 16);
            this.tableLayoutPanel1.Controls.Add(this.bt_show_ship_tours, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.bt_add_ship_route, 0, 15);
            this.tableLayoutPanel1.Controls.Add(this.bt_show_ship_routes_name, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.bt_edit_location, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.bt_edit_ships, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 15);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 26;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(220, 802);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // bt_add_passengers
            // 
            this.bt_add_passengers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_add_passengers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_add_passengers.Location = new System.Drawing.Point(1, 571);
            this.bt_add_passengers.Margin = new System.Windows.Forms.Padding(1);
            this.bt_add_passengers.Name = "bt_add_passengers";
            this.bt_add_passengers.Size = new System.Drawing.Size(218, 28);
            this.bt_add_passengers.TabIndex = 14;
            this.bt_add_passengers.Text = "Add Passengers (booking)";
            this.bt_add_passengers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_add_passengers.UseVisualStyleBackColor = true;
            this.bt_add_passengers.Click += new System.EventHandler(this.bt_add_passengers_Click);
            // 
            // bt_show_passengers
            // 
            this.bt_show_passengers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_show_passengers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_show_passengers.Location = new System.Drawing.Point(1, 271);
            this.bt_show_passengers.Margin = new System.Windows.Forms.Padding(1);
            this.bt_show_passengers.Name = "bt_show_passengers";
            this.bt_show_passengers.Size = new System.Drawing.Size(218, 28);
            this.bt_show_passengers.TabIndex = 13;
            this.bt_show_passengers.Text = "Show Passengers (all)";
            this.bt_show_passengers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_show_passengers.UseVisualStyleBackColor = true;
            this.bt_show_passengers.Click += new System.EventHandler(this.bt_show_passengers_Click);
            // 
            // bt_edit_customers
            // 
            this.bt_edit_customers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_edit_customers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_edit_customers.Location = new System.Drawing.Point(1, 91);
            this.bt_edit_customers.Margin = new System.Windows.Forms.Padding(1);
            this.bt_edit_customers.Name = "bt_edit_customers";
            this.bt_edit_customers.Size = new System.Drawing.Size(218, 28);
            this.bt_edit_customers.TabIndex = 12;
            this.bt_edit_customers.Text = "Edit Customers";
            this.bt_edit_customers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_edit_customers.UseVisualStyleBackColor = true;
            this.bt_edit_customers.Click += new System.EventHandler(this.bt_edit_customers_Click);
            // 
            // bt_add_transaction
            // 
            this.bt_add_transaction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_add_transaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_add_transaction.Location = new System.Drawing.Point(1, 541);
            this.bt_add_transaction.Margin = new System.Windows.Forms.Padding(1);
            this.bt_add_transaction.Name = "bt_add_transaction";
            this.bt_add_transaction.Size = new System.Drawing.Size(218, 28);
            this.bt_add_transaction.TabIndex = 11;
            this.bt_add_transaction.Text = "Add Transaction";
            this.bt_add_transaction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_add_transaction.UseVisualStyleBackColor = true;
            this.bt_add_transaction.Click += new System.EventHandler(this.bt_add_transaction_Click);
            // 
            // bt_show_transactions
            // 
            this.bt_show_transactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_show_transactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_show_transactions.Location = new System.Drawing.Point(1, 241);
            this.bt_show_transactions.Margin = new System.Windows.Forms.Padding(1);
            this.bt_show_transactions.Name = "bt_show_transactions";
            this.bt_show_transactions.Size = new System.Drawing.Size(218, 28);
            this.bt_show_transactions.TabIndex = 10;
            this.bt_show_transactions.Text = "Show Transactions";
            this.bt_show_transactions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_show_transactions.UseVisualStyleBackColor = true;
            this.bt_show_transactions.Click += new System.EventHandler(this.bt_show_transactions_Click);
            // 
            // bt_edit_sellers
            // 
            this.bt_edit_sellers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_edit_sellers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_edit_sellers.Location = new System.Drawing.Point(1, 61);
            this.bt_edit_sellers.Margin = new System.Windows.Forms.Padding(1);
            this.bt_edit_sellers.Name = "bt_edit_sellers";
            this.bt_edit_sellers.Size = new System.Drawing.Size(218, 28);
            this.bt_edit_sellers.TabIndex = 9;
            this.bt_edit_sellers.Text = "Edit Sellers";
            this.bt_edit_sellers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_edit_sellers.UseVisualStyleBackColor = true;
            this.bt_edit_sellers.Click += new System.EventHandler(this.bt_edit_sellers_Click);
            // 
            // bt_add_offer
            // 
            this.bt_add_offer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_add_offer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_add_offer.Location = new System.Drawing.Point(1, 511);
            this.bt_add_offer.Margin = new System.Windows.Forms.Padding(1);
            this.bt_add_offer.Name = "bt_add_offer";
            this.bt_add_offer.Size = new System.Drawing.Size(218, 28);
            this.bt_add_offer.TabIndex = 8;
            this.bt_add_offer.Text = "Add Offer";
            this.bt_add_offer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_add_offer.UseVisualStyleBackColor = true;
            this.bt_add_offer.Click += new System.EventHandler(this.bt_add_offer_Click);
            // 
            // bt_show_offers
            // 
            this.bt_show_offers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_show_offers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_show_offers.Location = new System.Drawing.Point(1, 211);
            this.bt_show_offers.Margin = new System.Windows.Forms.Padding(1);
            this.bt_show_offers.Name = "bt_show_offers";
            this.bt_show_offers.Size = new System.Drawing.Size(218, 28);
            this.bt_show_offers.TabIndex = 7;
            this.bt_show_offers.Text = "Show Offers";
            this.bt_show_offers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_show_offers.UseVisualStyleBackColor = true;
            this.bt_show_offers.Click += new System.EventHandler(this.bt_show_offers_Click);
            // 
            // bt_add_ship_tour
            // 
            this.bt_add_ship_tour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_add_ship_tour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_add_ship_tour.Location = new System.Drawing.Point(1, 481);
            this.bt_add_ship_tour.Margin = new System.Windows.Forms.Padding(1);
            this.bt_add_ship_tour.Name = "bt_add_ship_tour";
            this.bt_add_ship_tour.Size = new System.Drawing.Size(218, 28);
            this.bt_add_ship_tour.TabIndex = 6;
            this.bt_add_ship_tour.Text = "Add Ship-Tour";
            this.bt_add_ship_tour.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_add_ship_tour.UseVisualStyleBackColor = true;
            this.bt_add_ship_tour.Click += new System.EventHandler(this.bt_add_ship_tour_Click);
            // 
            // bt_show_ship_tours
            // 
            this.bt_show_ship_tours.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_show_ship_tours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_show_ship_tours.Location = new System.Drawing.Point(1, 181);
            this.bt_show_ship_tours.Margin = new System.Windows.Forms.Padding(1);
            this.bt_show_ship_tours.Name = "bt_show_ship_tours";
            this.bt_show_ship_tours.Size = new System.Drawing.Size(218, 28);
            this.bt_show_ship_tours.TabIndex = 5;
            this.bt_show_ship_tours.Text = "Show Ship-Tours";
            this.bt_show_ship_tours.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_show_ship_tours.UseVisualStyleBackColor = true;
            this.bt_show_ship_tours.Click += new System.EventHandler(this.bt_show_ship_tours_Click);
            // 
            // bt_add_ship_route
            // 
            this.bt_add_ship_route.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_add_ship_route.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_add_ship_route.Location = new System.Drawing.Point(1, 451);
            this.bt_add_ship_route.Margin = new System.Windows.Forms.Padding(1);
            this.bt_add_ship_route.Name = "bt_add_ship_route";
            this.bt_add_ship_route.Size = new System.Drawing.Size(218, 28);
            this.bt_add_ship_route.TabIndex = 4;
            this.bt_add_ship_route.Text = "Add Ship-Route";
            this.bt_add_ship_route.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_add_ship_route.UseVisualStyleBackColor = true;
            this.bt_add_ship_route.Click += new System.EventHandler(this.bt_add_ship_route_Click);
            // 
            // bt_show_ship_routes_name
            // 
            this.bt_show_ship_routes_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_show_ship_routes_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_show_ship_routes_name.Location = new System.Drawing.Point(1, 151);
            this.bt_show_ship_routes_name.Margin = new System.Windows.Forms.Padding(1);
            this.bt_show_ship_routes_name.Name = "bt_show_ship_routes_name";
            this.bt_show_ship_routes_name.Size = new System.Drawing.Size(218, 28);
            this.bt_show_ship_routes_name.TabIndex = 3;
            this.bt_show_ship_routes_name.Text = "Show Ship-Routes";
            this.bt_show_ship_routes_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_show_ship_routes_name.UseVisualStyleBackColor = true;
            this.bt_show_ship_routes_name.Click += new System.EventHandler(this.bt_show_ship_routes_name_Click);
            // 
            // bt_edit_location
            // 
            this.bt_edit_location.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_edit_location.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_edit_location.Location = new System.Drawing.Point(1, 31);
            this.bt_edit_location.Margin = new System.Windows.Forms.Padding(1);
            this.bt_edit_location.Name = "bt_edit_location";
            this.bt_edit_location.Size = new System.Drawing.Size(218, 28);
            this.bt_edit_location.TabIndex = 1;
            this.bt_edit_location.Text = "Edit Locations";
            this.bt_edit_location.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_edit_location.UseVisualStyleBackColor = true;
            this.bt_edit_location.Click += new System.EventHandler(this.bt_edit_location_Click);
            // 
            // bt_edit_ships
            // 
            this.bt_edit_ships.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_edit_ships.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_edit_ships.Location = new System.Drawing.Point(1, 1);
            this.bt_edit_ships.Margin = new System.Windows.Forms.Padding(1);
            this.bt_edit_ships.Name = "bt_edit_ships";
            this.bt_edit_ships.Size = new System.Drawing.Size(218, 28);
            this.bt_edit_ships.TabIndex = 0;
            this.bt_edit_ships.Text = "Edit Ships";
            this.bt_edit_ships.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_edit_ships.UseVisualStyleBackColor = true;
            this.bt_edit_ships.Click += new System.EventHandler(this.bt_edit_ships_Click);
            // 
            // dGV_main
            // 
            this.dGV_main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGV_main.Location = new System.Drawing.Point(223, 17);
            this.dGV_main.Margin = new System.Windows.Forms.Padding(3, 2, 1, 3);
            this.dGV_main.Name = "dGV_main";
            this.dGV_main.Size = new System.Drawing.Size(1150, 797);
            this.dGV_main.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel2.Controls.Add(this.bt_update_dGV_main, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(220, 817);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1154, 30);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // bt_update_dGV_main
            // 
            this.bt_update_dGV_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_update_dGV_main.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_update_dGV_main.Location = new System.Drawing.Point(974, 0);
            this.bt_update_dGV_main.Margin = new System.Windows.Forms.Padding(0);
            this.bt_update_dGV_main.Name = "bt_update_dGV_main";
            this.bt_update_dGV_main.Size = new System.Drawing.Size(180, 30);
            this.bt_update_dGV_main.TabIndex = 0;
            this.bt_update_dGV_main.Text = "Save Table";
            this.bt_update_dGV_main.UseVisualStyleBackColor = true;
            this.bt_update_dGV_main.Click += new System.EventHandler(this.bt_update_dGV_main_Click);
            // 
            // bt_refresh_scope
            // 
            this.bt_refresh_scope.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_refresh_scope.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_refresh_scope.Location = new System.Drawing.Point(1, 818);
            this.bt_refresh_scope.Margin = new System.Windows.Forms.Padding(1);
            this.bt_refresh_scope.Name = "bt_refresh_scope";
            this.bt_refresh_scope.Size = new System.Drawing.Size(218, 28);
            this.bt_refresh_scope.TabIndex = 15;
            this.bt_refresh_scope.Text = "Refresh Client-Assignments (Scopes)";
            this.bt_refresh_scope.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_refresh_scope.UseVisualStyleBackColor = true;
            this.bt_refresh_scope.Click += new System.EventHandler(this.bt_refresh_scope_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 862);
            this.Controls.Add(this.tLP_main);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(20, 20);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Pirate Bay Tours - Manager";
            this.tLP_main.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_main)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tLP_main;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button bt_add_passengers;
        private System.Windows.Forms.Button bt_show_passengers;
        private System.Windows.Forms.Button bt_edit_customers;
        private System.Windows.Forms.Button bt_add_transaction;
        private System.Windows.Forms.Button bt_show_transactions;
        private System.Windows.Forms.Button bt_edit_sellers;
        private System.Windows.Forms.Button bt_add_offer;
        private System.Windows.Forms.Button bt_show_offers;
        private System.Windows.Forms.Button bt_add_ship_tour;
        private System.Windows.Forms.Button bt_show_ship_tours;
        private System.Windows.Forms.Button bt_add_ship_route;
        private System.Windows.Forms.Button bt_show_ship_routes_name;
        private System.Windows.Forms.Button bt_edit_location;
        private System.Windows.Forms.Button bt_edit_ships;
        private System.Windows.Forms.DataGridView dGV_main;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button bt_update_dGV_main;
        private System.Windows.Forms.Button bt_refresh_scope;
    }
}

