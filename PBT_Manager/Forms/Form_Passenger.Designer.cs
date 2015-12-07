namespace PBT_Manager.Forms
{
    partial class Form_Passenger
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
            this.lb_select_seller = new System.Windows.Forms.Label();
            this.lBox_customer = new System.Windows.Forms.ListBox();
            this.lb_customer = new System.Windows.Forms.Label();
            this.lb_transaction = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lb_sold_contingent = new System.Windows.Forms.Label();
            this.nTB_sold_contingent = new PBT_Manager.NumericTextBox();
            this.dTP_booked_time = new System.Windows.Forms.DateTimePicker();
            this.dTP_booked_date = new System.Windows.Forms.DateTimePicker();
            this.lb_is_paid = new System.Windows.Forms.Label();
            this.nTB_price = new PBT_Manager.NumericTextBox();
            this.lb_price = new System.Windows.Forms.Label();
            this.lb_booked_time = new System.Windows.Forms.Label();
            this.cB_is_paid = new System.Windows.Forms.CheckBox();
            this.lb_id = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.bt_del = new System.Windows.Forms.Button();
            this.bt_about = new System.Windows.Forms.Button();
            this.bt_OK = new System.Windows.Forms.Button();
            this.lBox_transaction = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.coB_select_seller = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lb_select_seller, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lBox_customer, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.lb_customer, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.lb_transaction, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 5, 6);
            this.tableLayoutPanel1.Controls.Add(this.lb_id, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 5, 7);
            this.tableLayoutPanel1.Controls.Add(this.lBox_transaction, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.coB_select_seller, 3, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 562);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // lb_select_seller
            // 
            this.lb_select_seller.AutoSize = true;
            this.lb_select_seller.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_select_seller.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_select_seller.Location = new System.Drawing.Point(23, 20);
            this.lb_select_seller.Name = "lb_select_seller";
            this.lb_select_seller.Size = new System.Drawing.Size(174, 30);
            this.lb_select_seller.TabIndex = 9;
            this.lb_select_seller.Text = "Select Seller:";
            this.lb_select_seller.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lBox_customer
            // 
            this.lBox_customer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lBox_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBox_customer.FormattingEnabled = true;
            this.lBox_customer.ItemHeight = 16;
            this.lBox_customer.Location = new System.Drawing.Point(205, 150);
            this.lBox_customer.Margin = new System.Windows.Forms.Padding(0);
            this.lBox_customer.Name = "lBox_customer";
            this.lBox_customer.Size = new System.Drawing.Size(180, 362);
            this.lBox_customer.TabIndex = 6;
            // 
            // lb_customer
            // 
            this.lb_customer.AutoSize = true;
            this.lb_customer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_customer.Location = new System.Drawing.Point(208, 120);
            this.lb_customer.Name = "lb_customer";
            this.lb_customer.Size = new System.Drawing.Size(174, 30);
            this.lb_customer.TabIndex = 3;
            this.lb_customer.Text = "Customers:";
            this.lb_customer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_transaction
            // 
            this.lb_transaction.AutoSize = true;
            this.lb_transaction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_transaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_transaction.Location = new System.Drawing.Point(23, 120);
            this.lb_transaction.Name = "lb_transaction";
            this.lb_transaction.Size = new System.Drawing.Size(174, 30);
            this.lb_transaction.TabIndex = 2;
            this.lb_transaction.Text = "Transactions /Offers:";
            this.lb_transaction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.lb_sold_contingent, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.nTB_sold_contingent, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.dTP_booked_time, 3, 6);
            this.tableLayoutPanel2.Controls.Add(this.dTP_booked_date, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.lb_is_paid, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.nTB_price, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lb_price, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lb_booked_time, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.cB_is_paid, 1, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(390, 150);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(374, 362);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lb_sold_contingent
            // 
            this.lb_sold_contingent.AutoSize = true;
            this.lb_sold_contingent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_sold_contingent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sold_contingent.Location = new System.Drawing.Point(0, 0);
            this.lb_sold_contingent.Margin = new System.Windows.Forms.Padding(0);
            this.lb_sold_contingent.Name = "lb_sold_contingent";
            this.lb_sold_contingent.Size = new System.Drawing.Size(110, 35);
            this.lb_sold_contingent.TabIndex = 17;
            this.lb_sold_contingent.Text = "Transaction - Sold Tickets:";
            this.lb_sold_contingent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nTB_sold_contingent
            // 
            this.nTB_sold_contingent.AllowSpace = false;
            this.nTB_sold_contingent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nTB_sold_contingent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nTB_sold_contingent.Location = new System.Drawing.Point(110, 7);
            this.nTB_sold_contingent.Margin = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.nTB_sold_contingent.Name = "nTB_sold_contingent";
            this.nTB_sold_contingent.ReadOnly = true;
            this.nTB_sold_contingent.Size = new System.Drawing.Size(165, 21);
            this.nTB_sold_contingent.TabIndex = 16;
            // 
            // dTP_booked_time
            // 
            this.dTP_booked_time.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTP_booked_time.CustomFormat = "HH:mm:ss";
            this.dTP_booked_time.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dTP_booked_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTP_booked_time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTP_booked_time.Location = new System.Drawing.Point(278, 172);
            this.dTP_booked_time.Margin = new System.Windows.Forms.Padding(0, 7, 0, 3);
            this.dTP_booked_time.Name = "dTP_booked_time";
            this.dTP_booked_time.ShowUpDown = true;
            this.dTP_booked_time.Size = new System.Drawing.Size(85, 22);
            this.dTP_booked_time.TabIndex = 13;
            // 
            // dTP_booked_date
            // 
            this.dTP_booked_date.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTP_booked_date.CustomFormat = "ddd,  dd. MMM. yyyy";
            this.dTP_booked_date.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dTP_booked_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTP_booked_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTP_booked_date.Location = new System.Drawing.Point(110, 172);
            this.dTP_booked_date.Margin = new System.Windows.Forms.Padding(0, 7, 0, 3);
            this.dTP_booked_date.Name = "dTP_booked_date";
            this.dTP_booked_date.Size = new System.Drawing.Size(165, 22);
            this.dTP_booked_date.TabIndex = 12;
            // 
            // lb_is_paid
            // 
            this.lb_is_paid.AutoSize = true;
            this.lb_is_paid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_is_paid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_is_paid.Location = new System.Drawing.Point(0, 110);
            this.lb_is_paid.Margin = new System.Windows.Forms.Padding(0);
            this.lb_is_paid.Name = "lb_is_paid";
            this.lb_is_paid.Size = new System.Drawing.Size(110, 35);
            this.lb_is_paid.TabIndex = 10;
            this.lb_is_paid.Text = "Is paid:";
            this.lb_is_paid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nTB_price
            // 
            this.nTB_price.AllowSpace = false;
            this.nTB_price.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nTB_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nTB_price.Location = new System.Drawing.Point(110, 62);
            this.nTB_price.Margin = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.nTB_price.Name = "nTB_price";
            this.nTB_price.Size = new System.Drawing.Size(165, 21);
            this.nTB_price.TabIndex = 9;
            // 
            // lb_price
            // 
            this.lb_price.AutoSize = true;
            this.lb_price.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_price.Location = new System.Drawing.Point(0, 55);
            this.lb_price.Margin = new System.Windows.Forms.Padding(0);
            this.lb_price.Name = "lb_price";
            this.lb_price.Size = new System.Drawing.Size(110, 35);
            this.lb_price.TabIndex = 8;
            this.lb_price.Text = "Ticket Price:";
            this.lb_price.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_booked_time
            // 
            this.lb_booked_time.AutoSize = true;
            this.lb_booked_time.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_booked_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_booked_time.Location = new System.Drawing.Point(0, 165);
            this.lb_booked_time.Margin = new System.Windows.Forms.Padding(0);
            this.lb_booked_time.Name = "lb_booked_time";
            this.lb_booked_time.Size = new System.Drawing.Size(110, 35);
            this.lb_booked_time.TabIndex = 4;
            this.lb_booked_time.Text = "Booked Time:";
            this.lb_booked_time.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cB_is_paid
            // 
            this.cB_is_paid.AutoSize = true;
            this.cB_is_paid.Location = new System.Drawing.Point(113, 121);
            this.cB_is_paid.Margin = new System.Windows.Forms.Padding(3, 11, 3, 3);
            this.cB_is_paid.Name = "cB_is_paid";
            this.cB_is_paid.Size = new System.Drawing.Size(15, 14);
            this.cB_is_paid.TabIndex = 14;
            this.cB_is_paid.UseVisualStyleBackColor = true;
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_id.Location = new System.Drawing.Point(23, 70);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(174, 30);
            this.lb_id.TabIndex = 1;
            this.lb_id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 6;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel3.Controls.Add(this.bt_del, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.bt_about, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.bt_OK, 5, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(390, 512);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(374, 30);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // bt_del
            // 
            this.bt_del.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_del.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_del.Location = new System.Drawing.Point(98, 0);
            this.bt_del.Margin = new System.Windows.Forms.Padding(0);
            this.bt_del.Name = "bt_del";
            this.bt_del.Size = new System.Drawing.Size(90, 30);
            this.bt_del.TabIndex = 2;
            this.bt_del.Text = "Delete";
            this.bt_del.UseVisualStyleBackColor = true;
            this.bt_del.Click += new System.EventHandler(this.bt_del_Click);
            // 
            // bt_about
            // 
            this.bt_about.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_about.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_about.Location = new System.Drawing.Point(191, 0);
            this.bt_about.Margin = new System.Windows.Forms.Padding(0);
            this.bt_about.Name = "bt_about";
            this.bt_about.Size = new System.Drawing.Size(90, 30);
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
            this.bt_OK.Location = new System.Drawing.Point(284, 0);
            this.bt_OK.Margin = new System.Windows.Forms.Padding(0);
            this.bt_OK.Name = "bt_OK";
            this.bt_OK.Size = new System.Drawing.Size(90, 30);
            this.bt_OK.TabIndex = 0;
            this.bt_OK.Text = "OK";
            this.bt_OK.UseVisualStyleBackColor = true;
            this.bt_OK.Click += new System.EventHandler(this.bt_OK_Click);
            // 
            // lBox_transaction
            // 
            this.lBox_transaction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lBox_transaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBox_transaction.FormattingEnabled = true;
            this.lBox_transaction.ItemHeight = 16;
            this.lBox_transaction.Location = new System.Drawing.Point(20, 150);
            this.lBox_transaction.Margin = new System.Windows.Forms.Padding(0);
            this.lBox_transaction.Name = "lBox_transaction";
            this.lBox_transaction.Size = new System.Drawing.Size(180, 362);
            this.lBox_transaction.TabIndex = 5;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(390, 70);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(374, 30);
            this.tableLayoutPanel4.TabIndex = 7;
            // 
            // coB_select_seller
            // 
            this.coB_select_seller.Dock = System.Windows.Forms.DockStyle.Fill;
            this.coB_select_seller.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coB_select_seller.FormattingEnabled = true;
            this.coB_select_seller.Location = new System.Drawing.Point(208, 23);
            this.coB_select_seller.Name = "coB_select_seller";
            this.coB_select_seller.Size = new System.Drawing.Size(174, 24);
            this.coB_select_seller.TabIndex = 8;
            this.coB_select_seller.SelectedIndexChanged += new System.EventHandler(this.coB_select_seller_SelectedIndexChanged);
            // 
            // Form_Passenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form_Passenger";
            this.Text = "Add/Edit Passenger";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox lBox_customer;
        private System.Windows.Forms.Label lb_customer;
        private System.Windows.Forms.Label lb_transaction;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lb_is_paid;
        private NumericTextBox nTB_price;
        private System.Windows.Forms.Label lb_price;
        private System.Windows.Forms.Label lb_booked_time;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button bt_del;
        private System.Windows.Forms.Button bt_about;
        private System.Windows.Forms.Button bt_OK;
        private System.Windows.Forms.ListBox lBox_transaction;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.DateTimePicker dTP_booked_time;
        private System.Windows.Forms.DateTimePicker dTP_booked_date;
        private System.Windows.Forms.CheckBox cB_is_paid;
        private NumericTextBox nTB_sold_contingent;
        private System.Windows.Forms.Label lb_select_seller;
        private System.Windows.Forms.Label lb_sold_contingent;
        private System.Windows.Forms.ComboBox coB_select_seller;
    }
}