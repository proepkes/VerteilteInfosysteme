namespace PBT_Manager.Forms
{
    partial class Form_Transaction
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
            this.lBox_seller = new System.Windows.Forms.ListBox();
            this.lb_seller = new System.Windows.Forms.Label();
            this.lb_offer = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.nTB_seller_eff = new PBT_Manager.NumericTextBox();
            this.lb_seller_eff = new System.Windows.Forms.Label();
            this.nTB_ship_capa = new PBT_Manager.NumericTextBox();
            this.lb_ship_capa = new System.Windows.Forms.Label();
            this.lb_contingent = new System.Windows.Forms.Label();
            this.nTB_contingent = new PBT_Manager.NumericTextBox();
            this.lb_id = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.bt_del = new System.Windows.Forms.Button();
            this.bt_about = new System.Windows.Forms.Button();
            this.bt_OK = new System.Windows.Forms.Button();
            this.lBox_offer = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 260F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lBox_seller, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.lb_seller, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.lb_offer, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.lb_id, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 5, 5);
            this.tableLayoutPanel1.Controls.Add(this.lBox_offer, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 5, 1);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 562);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lBox_seller
            // 
            this.lBox_seller.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lBox_seller.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBox_seller.FormattingEnabled = true;
            this.lBox_seller.ItemHeight = 16;
            this.lBox_seller.Location = new System.Drawing.Point(285, 100);
            this.lBox_seller.Margin = new System.Windows.Forms.Padding(0);
            this.lBox_seller.Name = "lBox_seller";
            this.lBox_seller.Size = new System.Drawing.Size(180, 412);
            this.lBox_seller.TabIndex = 6;
            this.lBox_seller.SelectedIndexChanged += new System.EventHandler(this.lBox_seller_SelectedIndexChanged);
            // 
            // lb_seller
            // 
            this.lb_seller.AutoSize = true;
            this.lb_seller.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_seller.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_seller.Location = new System.Drawing.Point(288, 70);
            this.lb_seller.Name = "lb_seller";
            this.lb_seller.Size = new System.Drawing.Size(174, 30);
            this.lb_seller.TabIndex = 3;
            this.lb_seller.Text = "Seller:";
            this.lb_seller.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_offer
            // 
            this.lb_offer.AutoSize = true;
            this.lb_offer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_offer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_offer.Location = new System.Drawing.Point(23, 70);
            this.lb_offer.Name = "lb_offer";
            this.lb_offer.Size = new System.Drawing.Size(254, 30);
            this.lb_offer.TabIndex = 2;
            this.lb_offer.Text = "Offer:";
            this.lb_offer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.nTB_seller_eff, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lb_seller_eff, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.nTB_ship_capa, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lb_ship_capa, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lb_contingent, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.nTB_contingent, 1, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(470, 100);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(294, 412);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // nTB_seller_eff
            // 
            this.nTB_seller_eff.AllowSpace = false;
            this.nTB_seller_eff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nTB_seller_eff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nTB_seller_eff.Location = new System.Drawing.Point(125, 62);
            this.nTB_seller_eff.Margin = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.nTB_seller_eff.Name = "nTB_seller_eff";
            this.nTB_seller_eff.ReadOnly = true;
            this.nTB_seller_eff.Size = new System.Drawing.Size(120, 21);
            this.nTB_seller_eff.TabIndex = 11;
            // 
            // lb_seller_eff
            // 
            this.lb_seller_eff.AutoSize = true;
            this.lb_seller_eff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_seller_eff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_seller_eff.Location = new System.Drawing.Point(0, 55);
            this.lb_seller_eff.Margin = new System.Windows.Forms.Padding(0);
            this.lb_seller_eff.Name = "lb_seller_eff";
            this.lb_seller_eff.Size = new System.Drawing.Size(125, 35);
            this.lb_seller_eff.TabIndex = 10;
            this.lb_seller_eff.Text = "Seller Efficincy:";
            this.lb_seller_eff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nTB_ship_capa
            // 
            this.nTB_ship_capa.AllowSpace = false;
            this.nTB_ship_capa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nTB_ship_capa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nTB_ship_capa.Location = new System.Drawing.Point(125, 7);
            this.nTB_ship_capa.Margin = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.nTB_ship_capa.Name = "nTB_ship_capa";
            this.nTB_ship_capa.ReadOnly = true;
            this.nTB_ship_capa.Size = new System.Drawing.Size(120, 21);
            this.nTB_ship_capa.TabIndex = 9;
            // 
            // lb_ship_capa
            // 
            this.lb_ship_capa.AutoSize = true;
            this.lb_ship_capa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_ship_capa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ship_capa.Location = new System.Drawing.Point(0, 0);
            this.lb_ship_capa.Margin = new System.Windows.Forms.Padding(0);
            this.lb_ship_capa.Name = "lb_ship_capa";
            this.lb_ship_capa.Size = new System.Drawing.Size(125, 35);
            this.lb_ship_capa.TabIndex = 8;
            this.lb_ship_capa.Text = "Ship Capacity:";
            this.lb_ship_capa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_contingent
            // 
            this.lb_contingent.AutoSize = true;
            this.lb_contingent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_contingent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_contingent.Location = new System.Drawing.Point(0, 110);
            this.lb_contingent.Margin = new System.Windows.Forms.Padding(0);
            this.lb_contingent.Name = "lb_contingent";
            this.lb_contingent.Size = new System.Drawing.Size(125, 35);
            this.lb_contingent.TabIndex = 4;
            this.lb_contingent.Text = "Contingent:";
            this.lb_contingent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nTB_contingent
            // 
            this.nTB_contingent.AllowSpace = false;
            this.nTB_contingent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nTB_contingent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nTB_contingent.Location = new System.Drawing.Point(125, 117);
            this.nTB_contingent.Margin = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.nTB_contingent.Name = "nTB_contingent";
            this.nTB_contingent.Size = new System.Drawing.Size(120, 21);
            this.nTB_contingent.TabIndex = 7;
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_id.Location = new System.Drawing.Point(23, 20);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(254, 30);
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
            this.tableLayoutPanel3.Location = new System.Drawing.Point(470, 512);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(294, 30);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // bt_del
            // 
            this.bt_del.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_del.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_del.Location = new System.Drawing.Point(18, 0);
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
            this.bt_about.Location = new System.Drawing.Point(111, 0);
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
            this.bt_OK.Location = new System.Drawing.Point(204, 0);
            this.bt_OK.Margin = new System.Windows.Forms.Padding(0);
            this.bt_OK.Name = "bt_OK";
            this.bt_OK.Size = new System.Drawing.Size(90, 30);
            this.bt_OK.TabIndex = 0;
            this.bt_OK.Text = "OK";
            this.bt_OK.UseVisualStyleBackColor = true;
            this.bt_OK.Click += new System.EventHandler(this.bt_OK_Click);
            // 
            // lBox_offer
            // 
            this.lBox_offer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lBox_offer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBox_offer.FormattingEnabled = true;
            this.lBox_offer.ItemHeight = 16;
            this.lBox_offer.Location = new System.Drawing.Point(20, 100);
            this.lBox_offer.Margin = new System.Windows.Forms.Padding(0);
            this.lBox_offer.Name = "lBox_offer";
            this.lBox_offer.Size = new System.Drawing.Size(260, 412);
            this.lBox_offer.TabIndex = 5;
            this.lBox_offer.SelectedIndexChanged += new System.EventHandler(this.lBox_offer_SelectedIndexChanged);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(470, 20);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(294, 30);
            this.tableLayoutPanel4.TabIndex = 7;
            // 
            // Form_Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form_Transaction";
            this.Text = "Add/Edit Transaction";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox lBox_seller;
        private System.Windows.Forms.Label lb_seller;
        private System.Windows.Forms.Label lb_offer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lb_contingent;
        private NumericTextBox nTB_contingent;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button bt_del;
        private System.Windows.Forms.Button bt_about;
        private System.Windows.Forms.Button bt_OK;
        private System.Windows.Forms.ListBox lBox_offer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private NumericTextBox nTB_seller_eff;
        private System.Windows.Forms.Label lb_seller_eff;
        private NumericTextBox nTB_ship_capa;
        private System.Windows.Forms.Label lb_ship_capa;
    }
}