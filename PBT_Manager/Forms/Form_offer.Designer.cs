namespace PBT_Manager.Forms
{
    partial class Form_offer
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
            this.lBox_tour = new System.Windows.Forms.ListBox();
            this.lb_tour = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.nTB_capacity = new PBT_Manager.NumericTextBox();
            this.lb_capacity = new System.Windows.Forms.Label();
            this.nTB_price = new PBT_Manager.NumericTextBox();
            this.lb_price = new System.Windows.Forms.Label();
            this.dTP_expireTime = new System.Windows.Forms.DateTimePicker();
            this.dTP_expireDate = new System.Windows.Forms.DateTimePicker();
            this.lb_expiretime = new System.Windows.Forms.Label();
            this.dTP_createTime = new System.Windows.Forms.DateTimePicker();
            this.lb_createtime = new System.Windows.Forms.Label();
            this.dTP_createDate = new System.Windows.Forms.DateTimePicker();
            this.lb_tour_costs = new System.Windows.Forms.Label();
            this.nTB_tour_costs = new PBT_Manager.NumericTextBox();
            this.lb_id = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_about = new System.Windows.Forms.Button();
            this.bt_OK = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 420F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lBox_tour, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lb_tour, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.lb_id, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 3, 5);
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
            this.tableLayoutPanel1.TabIndex = 2;
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
            this.tableLayoutPanel4.Location = new System.Drawing.Point(445, 20);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(519, 30);
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
            this.lb_name.Location = new System.Drawing.Point(0, 5);
            this.lb_name.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(90, 25);
            this.lb_name.TabIndex = 9;
            this.lb_name.Text = "Offer-Name:";
            this.lb_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lBox_tour
            // 
            this.lBox_tour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lBox_tour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBox_tour.FormattingEnabled = true;
            this.lBox_tour.ItemHeight = 16;
            this.lBox_tour.Location = new System.Drawing.Point(20, 100);
            this.lBox_tour.Margin = new System.Windows.Forms.Padding(0);
            this.lBox_tour.Name = "lBox_tour";
            this.lBox_tour.Size = new System.Drawing.Size(420, 512);
            this.lBox_tour.TabIndex = 6;
            this.lBox_tour.SelectedIndexChanged += new System.EventHandler(this.lBox_tour_SelectedIndexChanged);
            // 
            // lb_tour
            // 
            this.lb_tour.AutoSize = true;
            this.lb_tour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_tour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tour.Location = new System.Drawing.Point(23, 70);
            this.lb_tour.Name = "lb_tour";
            this.lb_tour.Size = new System.Drawing.Size(414, 30);
            this.lb_tour.TabIndex = 3;
            this.lb_tour.Text = "Tour:";
            this.lb_tour.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.nTB_capacity, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.lb_capacity, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.nTB_price, 1, 8);
            this.tableLayoutPanel2.Controls.Add(this.lb_price, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.dTP_expireTime, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.dTP_expireDate, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lb_expiretime, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.dTP_createTime, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.lb_createtime, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dTP_createDate, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lb_tour_costs, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.nTB_tour_costs, 1, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(445, 100);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 10;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(519, 512);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // nTB_capacity
            // 
            this.nTB_capacity.AllowSpace = false;
            this.nTB_capacity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nTB_capacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nTB_capacity.Location = new System.Drawing.Point(114, 172);
            this.nTB_capacity.Margin = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.nTB_capacity.Name = "nTB_capacity";
            this.nTB_capacity.ReadOnly = true;
            this.nTB_capacity.Size = new System.Drawing.Size(165, 21);
            this.nTB_capacity.TabIndex = 17;
            // 
            // lb_capacity
            // 
            this.lb_capacity.AutoSize = true;
            this.lb_capacity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_capacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_capacity.Location = new System.Drawing.Point(0, 165);
            this.lb_capacity.Margin = new System.Windows.Forms.Padding(0);
            this.lb_capacity.Name = "lb_capacity";
            this.lb_capacity.Size = new System.Drawing.Size(114, 35);
            this.lb_capacity.TabIndex = 16;
            this.lb_capacity.Text = "Ship Capacity:";
            this.lb_capacity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nTB_price
            // 
            this.nTB_price.AllowSpace = false;
            this.nTB_price.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nTB_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nTB_price.Location = new System.Drawing.Point(114, 227);
            this.nTB_price.Margin = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.nTB_price.Name = "nTB_price";
            this.nTB_price.Size = new System.Drawing.Size(165, 21);
            this.nTB_price.TabIndex = 1;
            // 
            // lb_price
            // 
            this.lb_price.AutoSize = true;
            this.lb_price.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_price.Location = new System.Drawing.Point(0, 220);
            this.lb_price.Margin = new System.Windows.Forms.Padding(0);
            this.lb_price.Name = "lb_price";
            this.lb_price.Size = new System.Drawing.Size(114, 35);
            this.lb_price.TabIndex = 15;
            this.lb_price.Text = "Offer Price:";
            this.lb_price.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dTP_expireTime
            // 
            this.dTP_expireTime.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTP_expireTime.CustomFormat = "HH:mm:ss";
            this.dTP_expireTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dTP_expireTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTP_expireTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTP_expireTime.Location = new System.Drawing.Point(282, 62);
            this.dTP_expireTime.Margin = new System.Windows.Forms.Padding(0, 7, 0, 3);
            this.dTP_expireTime.Name = "dTP_expireTime";
            this.dTP_expireTime.ShowUpDown = true;
            this.dTP_expireTime.Size = new System.Drawing.Size(85, 22);
            this.dTP_expireTime.TabIndex = 14;
            // 
            // dTP_expireDate
            // 
            this.dTP_expireDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTP_expireDate.CustomFormat = "ddd,  dd. MMM. yyyy";
            this.dTP_expireDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dTP_expireDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTP_expireDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTP_expireDate.Location = new System.Drawing.Point(114, 62);
            this.dTP_expireDate.Margin = new System.Windows.Forms.Padding(0, 7, 0, 3);
            this.dTP_expireDate.Name = "dTP_expireDate";
            this.dTP_expireDate.Size = new System.Drawing.Size(165, 22);
            this.dTP_expireDate.TabIndex = 13;
            // 
            // lb_expiretime
            // 
            this.lb_expiretime.AutoSize = true;
            this.lb_expiretime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_expiretime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_expiretime.Location = new System.Drawing.Point(0, 55);
            this.lb_expiretime.Margin = new System.Windows.Forms.Padding(0);
            this.lb_expiretime.Name = "lb_expiretime";
            this.lb_expiretime.Size = new System.Drawing.Size(114, 35);
            this.lb_expiretime.TabIndex = 12;
            this.lb_expiretime.Text = "Validity End:";
            this.lb_expiretime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dTP_createTime
            // 
            this.dTP_createTime.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTP_createTime.CustomFormat = "HH:mm:ss";
            this.dTP_createTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dTP_createTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTP_createTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTP_createTime.Location = new System.Drawing.Point(282, 7);
            this.dTP_createTime.Margin = new System.Windows.Forms.Padding(0, 7, 0, 3);
            this.dTP_createTime.Name = "dTP_createTime";
            this.dTP_createTime.ShowUpDown = true;
            this.dTP_createTime.Size = new System.Drawing.Size(85, 22);
            this.dTP_createTime.TabIndex = 11;
            // 
            // lb_createtime
            // 
            this.lb_createtime.AutoSize = true;
            this.lb_createtime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_createtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_createtime.Location = new System.Drawing.Point(0, 0);
            this.lb_createtime.Margin = new System.Windows.Forms.Padding(0);
            this.lb_createtime.Name = "lb_createtime";
            this.lb_createtime.Size = new System.Drawing.Size(114, 35);
            this.lb_createtime.TabIndex = 9;
            this.lb_createtime.Text = "Validity Start:";
            this.lb_createtime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dTP_createDate
            // 
            this.dTP_createDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTP_createDate.CustomFormat = "ddd,  dd. MMM. yyyy";
            this.dTP_createDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dTP_createDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTP_createDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTP_createDate.Location = new System.Drawing.Point(114, 7);
            this.dTP_createDate.Margin = new System.Windows.Forms.Padding(0, 7, 0, 3);
            this.dTP_createDate.Name = "dTP_createDate";
            this.dTP_createDate.Size = new System.Drawing.Size(165, 22);
            this.dTP_createDate.TabIndex = 10;
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
            this.lb_id.Size = new System.Drawing.Size(414, 30);
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
            this.tableLayoutPanel3.Location = new System.Drawing.Point(445, 612);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(519, 30);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // bt_delete
            // 
            this.bt_delete.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_delete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_delete.Location = new System.Drawing.Point(183, 0);
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
            this.bt_about.Location = new System.Drawing.Point(296, 0);
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
            this.bt_OK.Location = new System.Drawing.Point(409, 0);
            this.bt_OK.Margin = new System.Windows.Forms.Padding(0);
            this.bt_OK.Name = "bt_OK";
            this.bt_OK.Size = new System.Drawing.Size(110, 30);
            this.bt_OK.TabIndex = 0;
            this.bt_OK.Text = "OK";
            this.bt_OK.UseVisualStyleBackColor = true;
            this.bt_OK.Click += new System.EventHandler(this.bt_OK_Click);
            // 
            // Form_offer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 662);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form_offer";
            this.Text = "Add/Edit Offer";
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox tB_name;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.ListBox lBox_tour;
        private System.Windows.Forms.Label lb_tour;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DateTimePicker dTP_expireTime;
        private System.Windows.Forms.DateTimePicker dTP_expireDate;
        private System.Windows.Forms.Label lb_expiretime;
        private System.Windows.Forms.DateTimePicker dTP_createTime;
        private System.Windows.Forms.Label lb_createtime;
        private System.Windows.Forms.DateTimePicker dTP_createDate;
        private System.Windows.Forms.Label lb_tour_costs;
        private NumericTextBox nTB_tour_costs;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.Button bt_about;
        private System.Windows.Forms.Button bt_OK;
        private System.Windows.Forms.Label lb_id;
        private NumericTextBox nTB_price;
        private System.Windows.Forms.Label lb_price;
        private NumericTextBox nTB_capacity;
        private System.Windows.Forms.Label lb_capacity;
    }
}