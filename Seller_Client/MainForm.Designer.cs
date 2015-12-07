namespace Seller_Client
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
            this.btn_tools = new System.Windows.Forms.Button();
            this.btn_synchronize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_tools
            // 
            this.btn_tools.Location = new System.Drawing.Point(329, 12);
            this.btn_tools.Name = "btn_tools";
            this.btn_tools.Size = new System.Drawing.Size(85, 33);
            this.btn_tools.TabIndex = 0;
            this.btn_tools.Text = "Tools";
            this.btn_tools.UseVisualStyleBackColor = true;
            this.btn_tools.Click += new System.EventHandler(this.btn_tools_Click);
            // 
            // btn_synchronize
            // 
            this.btn_synchronize.Location = new System.Drawing.Point(12, 12);
            this.btn_synchronize.Name = "btn_synchronize";
            this.btn_synchronize.Size = new System.Drawing.Size(118, 33);
            this.btn_synchronize.TabIndex = 1;
            this.btn_synchronize.Text = "Synchronize";
            this.btn_synchronize.UseVisualStyleBackColor = true;
            this.btn_synchronize.Click += new System.EventHandler(this.btn_synchronize_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 403);
            this.Controls.Add(this.btn_synchronize);
            this.Controls.Add(this.btn_tools);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Seller_Client";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_tools;
        private System.Windows.Forms.Button btn_synchronize;
    }
}

