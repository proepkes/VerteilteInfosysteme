namespace PBT_Manager.Forms
{
    partial class Form_ship_tour
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tB_name = new System.Windows.Forms.TextBox();
            this.lb_name = new System.Windows.Forms.Label();
            this.lBox_route = new System.Windows.Forms.ListBox();
            this.lb_route = new System.Windows.Forms.Label();
            this.lb_ship = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dTP_returnTime = new System.Windows.Forms.DateTimePicker();
            this.dTP_returnDate = new System.Windows.Forms.DateTimePicker();
            this.lb_returntime = new System.Windows.Forms.Label();
            this.dTP_sailingTime = new System.Windows.Forms.DateTimePicker();
            this.lb_sailingtime = new System.Windows.Forms.Label();
            this.dTP_sailingDate = new System.Windows.Forms.DateTimePicker();
            this.lb_tour_costs = new System.Windows.Forms.Label();
            this.nTB_tour_costs = new PBT_Manager.NumericTextBox();
            this.lb_id = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_about = new System.Windows.Forms.Button();
            this.bt_OK = new System.Windows.Forms.Button();
            this.lBox_ship = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 420F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lBox_route, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.lb_route, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.lb_ship, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.lb_id, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 5, 5);
            this.tableLayoutPanel1.Controls.Add(this.lBox_ship, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(984, 662);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 320F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.tB_name, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.lb_name, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(165, 20);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(420, 30);
            this.tableLayoutPanel4.TabIndex = 8;
            // 
            // tB_name
            // 
            this.tB_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tB_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB_name.Location = new System.Drawing.Point(90, 4);
            this.tB_name.Margin = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.tB_name.Name = "tB_name";
            this.tB_name.Size = new System.Drawing.Size(320, 21);
            this.tB_name.TabIndex = 10;
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.Location = new System.Drawing.Point(0, 0);
            this.lb_name.Margin = new System.Windows.Forms.Padding(0);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(90, 30);
            this.lb_name.TabIndex = 9;
            this.lb_name.Text = "Tour-Name:";
            this.lb_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lBox_route
            // 
            this.lBox_route.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lBox_route.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBox_route.FormattingEnabled = true;
            this.lBox_route.ItemHeight = 16;
            this.lBox_route.Location = new System.Drawing.Point(165, 100);
            this.lBox_route.Margin = new System.Windows.Forms.Padding(0);
            this.lBox_route.Name = "lBox_route";
            this.lBox_route.Size = new System.Drawing.Size(420, 512);
            this.lBox_route.TabIndex = 6;
            this.lBox_route.SelectedIndexChanged += new System.EventHandler(this.lBox_route_SelectedIndexChanged);
            // 
            // lb_route
            // 
            this.lb_route.AutoSize = true;
            this.lb_route.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_route.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_route.Location = new System.Drawing.Point(168, 70);
            this.lb_route.Name = "lb_route";
            this.lb_route.Size = new System.Drawing.Size(414, 30);
            this.lb_route.TabIndex = 3;
            this.lb_route.Text = "Route:";
            this.lb_route.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_ship
            // 
            this.lb_ship.AutoSize = true;
            this.lb_ship.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_ship.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ship.Location = new System.Drawing.Point(23, 70);
            this.lb_ship.Name = "lb_ship";
            this.lb_ship.Size = new System.Drawing.Size(134, 30);
            this.lb_ship.TabIndex = 2;
            this.lb_ship.Text = "Ship:";
            this.lb_ship.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.dTP_returnTime, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.dTP_returnDate, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lb_returntime, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.dTP_sailingTime, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.lb_sailingtime, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dTP_sailingDate, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lb_tour_costs, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.nTB_tour_costs, 1, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(590, 100);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(374, 512);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // dTP_returnTime
            // 
            this.dTP_returnTime.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTP_returnTime.CustomFormat = "HH:mm:ss";
            this.dTP_returnTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dTP_returnTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTP_returnTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTP_returnTime.Location = new System.Drawing.Point(282, 62);
            this.dTP_returnTime.Margin = new System.Windows.Forms.Padding(0, 7, 0, 3);
            this.dTP_returnTime.Name = "dTP_returnTime";
            this.dTP_returnTime.ShowUpDown = true;
            this.dTP_returnTime.Size = new System.Drawing.Size(85, 22);
            this.dTP_returnTime.TabIndex = 14;
            // 
            // dTP_returnDate
            // 
            this.dTP_returnDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTP_returnDate.CustomFormat = "ddd,  dd. MMM. yyyy";
            this.dTP_returnDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dTP_returnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTP_returnDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTP_returnDate.Location = new System.Drawing.Point(114, 62);
            this.dTP_returnDate.Margin = new System.Windows.Forms.Padding(0, 7, 0, 3);
            this.dTP_returnDate.Name = "dTP_returnDate";
            this.dTP_returnDate.Size = new System.Drawing.Size(165, 22);
            this.dTP_returnDate.TabIndex = 13;
            // 
            // lb_returntime
            // 
            this.lb_returntime.AutoSize = true;
            this.lb_returntime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_returntime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_returntime.Location = new System.Drawing.Point(0, 55);
            this.lb_returntime.Margin = new System.Windows.Forms.Padding(0);
            this.lb_returntime.Name = "lb_returntime";
            this.lb_returntime.Size = new System.Drawing.Size(114, 35);
            this.lb_returntime.TabIndex = 12;
            this.lb_returntime.Text = "Return Time:";
            this.lb_returntime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dTP_sailingTime
            // 
            this.dTP_sailingTime.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTP_sailingTime.CustomFormat = "HH:mm:ss";
            this.dTP_sailingTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dTP_sailingTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTP_sailingTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTP_sailingTime.Location = new System.Drawing.Point(282, 7);
            this.dTP_sailingTime.Margin = new System.Windows.Forms.Padding(0, 7, 0, 3);
            this.dTP_sailingTime.Name = "dTP_sailingTime";
            this.dTP_sailingTime.ShowUpDown = true;
            this.dTP_sailingTime.Size = new System.Drawing.Size(85, 22);
            this.dTP_sailingTime.TabIndex = 11;
            // 
            // lb_sailingtime
            // 
            this.lb_sailingtime.AutoSize = true;
            this.lb_sailingtime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_sailingtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sailingtime.Location = new System.Drawing.Point(0, 0);
            this.lb_sailingtime.Margin = new System.Windows.Forms.Padding(0);
            this.lb_sailingtime.Name = "lb_sailingtime";
            this.lb_sailingtime.Size = new System.Drawing.Size(114, 35);
            this.lb_sailingtime.TabIndex = 9;
            this.lb_sailingtime.Text = "Sailing Time:";
            this.lb_sailingtime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dTP_sailingDate
            // 
            this.dTP_sailingDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTP_sailingDate.CustomFormat = "ddd,  dd. MMM. yyyy";
            this.dTP_sailingDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dTP_sailingDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTP_sailingDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTP_sailingDate.Location = new System.Drawing.Point(114, 7);
            this.dTP_sailingDate.Margin = new System.Windows.Forms.Padding(0, 7, 0, 3);
            this.dTP_sailingDate.Name = "dTP_sailingDate";
            this.dTP_sailingDate.Size = new System.Drawing.Size(165, 22);
            this.dTP_sailingDate.TabIndex = 10;
            // 
            // lb_tour_costs
            // 
            this.lb_tour_costs.AutoSize = true;
            this.lb_tour_costs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_tour_costs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tour_costs.Location = new System.Drawing.Point(0, 110);
            this.lb_tour_costs.Margin = new System.Windows.Forms.Padding(0);
            this.lb_tour_costs.Name = "lb_tour_costs";
            this.lb_tour_costs.Size = new System.Drawing.Size(114, 35);
            this.lb_tour_costs.TabIndex = 4;
            this.lb_tour_costs.Text = "Tour Costs:";
            this.lb_tour_costs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nTB_tour_costs
            // 
            this.nTB_tour_costs.AllowSpace = false;
            this.nTB_tour_costs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nTB_tour_costs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nTB_tour_costs.Location = new System.Drawing.Point(114, 117);
            this.nTB_tour_costs.Margin = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.nTB_tour_costs.Name = "nTB_tour_costs";
            this.nTB_tour_costs.ReadOnly = true;
            this.nTB_tour_costs.Size = new System.Drawing.Size(165, 21);
            this.nTB_tour_costs.TabIndex = 7;
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_id.Location = new System.Drawing.Point(23, 20);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(134, 30);
            this.lb_id.TabIndex = 1;
            this.lb_id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 6;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel3.Controls.Add(this.bt_delete, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.bt_about, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.bt_OK, 5, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(590, 612);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(374, 30);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // bt_delete
            // 
            this.bt_delete.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_delete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_delete.Location = new System.Drawing.Point(38, 0);
            this.bt_delete.Margin = new System.Windows.Forms.Padding(0);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(110, 30);
            this.bt_delete.TabIndex = 2;
            this.bt_delete.Text = "Delete";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // bt_about
            // 
            this.bt_about.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_about.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_about.Location = new System.Drawing.Point(151, 0);
            this.bt_about.Margin = new System.Windows.Forms.Padding(0);
            this.bt_about.Name = "bt_about";
            this.bt_about.Size = new System.Drawing.Size(110, 30);
            this.bt_about.TabIndex = 1;
            this.bt_about.Text = "Cancel";
            this.bt_about.UseVisualStyleBackColor = true;
            this.bt_about.Click += new System.EventHandler(this.bt_about_Click);
            // 
            // bt_OK
            // 
            this.bt_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_OK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_OK.Location = new System.Drawing.Point(264, 0);
            this.bt_OK.Margin = new System.Windows.Forms.Padding(0);
            this.bt_OK.Name = "bt_OK";
            this.bt_OK.Size = new System.Drawing.Size(110, 30);
            this.bt_OK.TabIndex = 0;
            this.bt_OK.Text = "OK";
            this.bt_OK.UseVisualStyleBackColor = true;
            this.bt_OK.Click += new System.EventHandler(this.bt_OK_Click);
            // 
            // lBox_ship
            // 
            this.lBox_ship.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lBox_ship.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBox_ship.FormattingEnabled = true;
            this.lBox_ship.ItemHeight = 16;
            this.lBox_ship.Location = new System.Drawing.Point(20, 100);
            this.lBox_ship.Margin = new System.Windows.Forms.Padding(0);
            this.lBox_ship.Name = "lBox_ship";
            this.lBox_ship.Size = new System.Drawing.Size(140, 512);
            this.lBox_ship.TabIndex = 5;
            this.lBox_ship.SelectedIndexChanged += new System.EventHandler(this.lBox_ship_SelectedIndexChanged);
            // 
            // Form_ship_tour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 662);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form_ship_tour";
            this.Text = "Add/Edit Ship Tour";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox lBox_route;
        private System.Windows.Forms.Label lb_route;
        private System.Windows.Forms.Label lb_ship;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button bt_about;
        private System.Windows.Forms.Button bt_OK;
        private System.Windows.Forms.ListBox lBox_ship;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.Label lb_tour_costs;
        private NumericTextBox nTB_tour_costs;
        private System.Windows.Forms.DateTimePicker dTP_sailingTime;
        private System.Windows.Forms.Label lb_sailingtime;
        private System.Windows.Forms.DateTimePicker dTP_sailingDate;
        private System.Windows.Forms.DateTimePicker dTP_returnTime;
        private System.Windows.Forms.DateTimePicker dTP_returnDate;
        private System.Windows.Forms.Label lb_returntime;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox tB_name;
        private System.Windows.Forms.Label lb_name;
    }
}