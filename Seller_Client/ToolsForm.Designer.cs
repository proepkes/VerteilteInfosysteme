namespace Seller_Client
{
    partial class ToolsForm
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
            this.btn_provisionClient = new System.Windows.Forms.Button();
            this.btn_provisionServer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_provisionClient
            // 
            this.btn_provisionClient.Location = new System.Drawing.Point(12, 55);
            this.btn_provisionClient.Name = "btn_provisionClient";
            this.btn_provisionClient.Size = new System.Drawing.Size(221, 37);
            this.btn_provisionClient.TabIndex = 0;
            this.btn_provisionClient.Text = "ProvisionClient";
            this.btn_provisionClient.UseVisualStyleBackColor = true;
            this.btn_provisionClient.Click += new System.EventHandler(this.btn_provision_Click);
            // 
            // btn_provisionServer
            // 
            this.btn_provisionServer.Location = new System.Drawing.Point(12, 12);
            this.btn_provisionServer.Name = "btn_provisionServer";
            this.btn_provisionServer.Size = new System.Drawing.Size(221, 37);
            this.btn_provisionServer.TabIndex = 1;
            this.btn_provisionServer.Text = "ProvisionServer";
            this.btn_provisionServer.UseVisualStyleBackColor = true;
            this.btn_provisionServer.Click += new System.EventHandler(this.btn_provision_Click);
            // 
            // ToolsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 103);
            this.Controls.Add(this.btn_provisionServer);
            this.Controls.Add(this.btn_provisionClient);
            this.Name = "ToolsForm";
            this.Text = "Tools";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_provisionClient;
        private System.Windows.Forms.Button btn_provisionServer;
    }
}