namespace PBT_Manager.Forms
{
    partial class Form_ship_route
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
            this.lBox_to_location = new System.Windows.Forms.ListBox();
            this.lb_to_location = new System.Windows.Forms.Label();
            this.lb_from_location = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lb_distance = new System.Windows.Forms.Label();
            this.nTB_distance = new PBT_Manager.NumericTextBox();
            this.lb_id = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.bt_del = new System.Windows.Forms.Button();
            this.bt_about = new System.Windows.Forms.Button();
            this.bt_OK = new System.Windows.Forms.Button();
            this.lBox_from_location = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tB_name = new System.Windows.Forms.TextBox();
            this.lb_name = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
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
            this.tableLayoutPanel1.Controls.Add(this.lBox_to_location, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.lb_to_location, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.lb_from_location, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.lb_id, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 5, 5);
            this.tableLayoutPanel1.Controls.Add(this.lBox_from_location, 1, 4);
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
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lBox_to_location
            // 
            this.lBox_to_location.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lBox_to_location.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBox_to_location.FormattingEnabled = true;
            this.lBox_to_location.ItemHeight = 16;
            this.lBox_to_location.Location = new System.Drawing.Point(205, 100);
            this.lBox_to_location.Margin = new System.Windows.Forms.Padding(0);
            this.lBox_to_location.Name = "lBox_to_location";
            this.lBox_to_location.Size = new System.Drawing.Size(180, 412);
            this.lBox_to_location.TabIndex = 6;
            this.lBox_to_location.SelectedIndexChanged += new System.EventHandler(this.lBox_to_location_SelectedIndexChanged);
            // 
            // lb_to_location
            // 
            this.lb_to_location.AutoSize = true;
            this.lb_to_location.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_to_location.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_to_location.Location = new System.Drawing.Point(208, 70);
            this.lb_to_location.Name = "lb_to_location";
            this.lb_to_location.Size = new System.Drawing.Size(174, 30);
            this.lb_to_location.TabIndex = 3;
            this.lb_to_location.Text = "To Location:";
            this.lb_to_location.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_from_location
            // 
            this.lb_from_location.AutoSize = true;
            this.lb_from_location.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_from_location.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_from_location.Location = new System.Drawing.Point(23, 70);
            this.lb_from_location.Name = "lb_from_location";
            this.lb_from_location.Size = new System.Drawing.Size(174, 30);
            this.lb_from_location.TabIndex = 2;
            this.lb_from_location.Text = "From Location:";
            this.lb_from_location.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.lb_distance, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.nTB_distance, 1, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(390, 100);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(374, 412);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lb_distance
            // 
            this.lb_distance.AutoSize = true;
            this.lb_distance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_distance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_distance.Location = new System.Drawing.Point(0, 110);
            this.lb_distance.Margin = new System.Windows.Forms.Padding(0);
            this.lb_distance.Name = "lb_distance";
            this.lb_distance.Size = new System.Drawing.Size(114, 35);
            this.lb_distance.TabIndex = 4;
            this.lb_distance.Text = "Distance in km:";
            this.lb_distance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nTB_distance
            // 
            this.nTB_distance.AllowSpace = false;
            this.nTB_distance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nTB_distance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nTB_distance.Location = new System.Drawing.Point(114, 117);
            this.nTB_distance.Margin = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.nTB_distance.Name = "nTB_distance";
            this.nTB_distance.Size = new System.Drawing.Size(240, 21);
            this.nTB_distance.TabIndex = 7;
            this.nTB_distance.TextChanged += new System.EventHandler(this.nTB_distance_TextChanged);
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_id.Location = new System.Drawing.Point(23, 20);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(174, 30);
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
            this.bt_del.Location = new System.Drawing.Point(38, 0);
            this.bt_del.Margin = new System.Windows.Forms.Padding(0);
            this.bt_del.Name = "bt_del";
            this.bt_del.Size = new System.Drawing.Size(110, 30);
            this.bt_del.TabIndex = 2;
            this.bt_del.Text = "Delete";
            this.bt_del.UseVisualStyleBackColor = true;
            this.bt_del.Click += new System.EventHandler(this.bt_del_Click);
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
            // lBox_from_location
            // 
            this.lBox_from_location.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lBox_from_location.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBox_from_location.FormattingEnabled = true;
            this.lBox_from_location.ItemHeight = 16;
            this.lBox_from_location.Location = new System.Drawing.Point(20, 100);
            this.lBox_from_location.Margin = new System.Windows.Forms.Padding(0);
            this.lBox_from_location.Name = "lBox_from_location";
            this.lBox_from_location.Size = new System.Drawing.Size(180, 412);
            this.lBox_from_location.TabIndex = 5;
            this.lBox_from_location.SelectedIndexChanged += new System.EventHandler(this.lBox_from_location_SelectedIndexChanged);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.tB_name, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.lb_name, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(390, 20);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(374, 30);
            this.tableLayoutPanel4.TabIndex = 7;
            // 
            // tB_name
            // 
            this.tB_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tB_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB_name.Location = new System.Drawing.Point(114, 4);
            this.tB_name.Margin = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.tB_name.Name = "tB_name";
            this.tB_name.Size = new System.Drawing.Size(240, 21);
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
            this.lb_name.Size = new System.Drawing.Size(114, 30);
            this.lb_name.TabIndex = 9;
            this.lb_name.Text = "Route-Name:";
            this.lb_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form_ship_route
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form_ship_route";
            this.Text = "Add/Edit Ship Route";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lb_to_location;
        private System.Windows.Forms.Label lb_from_location;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lb_distance;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ListBox lBox_from_location;
        private System.Windows.Forms.ListBox lBox_to_location;
        private NumericTextBox nTB_distance;
        private System.Windows.Forms.Button bt_about;
        private System.Windows.Forms.Button bt_OK;
        private System.Windows.Forms.Button bt_del;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox tB_name;
        private System.Windows.Forms.Label lb_name;
    }
}