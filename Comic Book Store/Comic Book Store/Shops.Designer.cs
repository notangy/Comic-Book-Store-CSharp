namespace Comic_Book_Store
{
    partial class Shops
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
            this.lstShops = new System.Windows.Forms.ListBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblActive = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstShops
            // 
            this.lstShops.FormattingEnabled = true;
            this.lstShops.Location = new System.Drawing.Point(12, 12);
            this.lstShops.Name = "lstShops";
            this.lstShops.Size = new System.Drawing.Size(98, 121);
            this.lstShops.TabIndex = 0;
            this.lstShops.SelectedIndexChanged += new System.EventHandler(this.lstShops_SelectedIndexChanged);
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(116, 23);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(59, 16);
            this.lblLocation.TabIndex = 2;
            this.lblLocation.Text = "Location";
            // 
            // lblActive
            // 
            this.lblActive.AutoSize = true;
            this.lblActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActive.Location = new System.Drawing.Point(116, 88);
            this.lblActive.Name = "lblActive";
            this.lblActive.Size = new System.Drawing.Size(148, 45);
            this.lblActive.TabIndex = 4;
            this.lblActive.Text = "The selected store is your \r\nactive one, where orders\r\nare picked up.";
            // 
            // Shops
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 165);
            this.Controls.Add(this.lblActive);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lstShops);
            this.Name = "Shops";
            this.Text = "Shops";
            this.Load += new System.EventHandler(this.Shops_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstShops;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblActive;
    }
}