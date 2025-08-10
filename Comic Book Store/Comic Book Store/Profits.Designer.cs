namespace Comic_Book_Store
{
    partial class Profits
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
            this.dataProfit = new System.Windows.Forms.DataGridView();
            this.lblOrders = new System.Windows.Forms.Label();
            this.lblStaff = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataProfit)).BeginInit();
            this.SuspendLayout();
            // 
            // dataProfit
            // 
            this.dataProfit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataProfit.Location = new System.Drawing.Point(168, 12);
            this.dataProfit.Name = "dataProfit";
            this.dataProfit.Size = new System.Drawing.Size(164, 202);
            this.dataProfit.TabIndex = 0;
            // 
            // lblOrders
            // 
            this.lblOrders.AutoSize = true;
            this.lblOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrders.Location = new System.Drawing.Point(12, 30);
            this.lblOrders.Name = "lblOrders";
            this.lblOrders.Size = new System.Drawing.Size(97, 32);
            this.lblOrders.TabIndex = 1;
            this.lblOrders.Text = "Orders placed \r\ntoday:";
            // 
            // lblStaff
            // 
            this.lblStaff.AutoSize = true;
            this.lblStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaff.Location = new System.Drawing.Point(12, 102);
            this.lblStaff.Name = "lblStaff";
            this.lblStaff.Size = new System.Drawing.Size(84, 32);
            this.lblStaff.TabIndex = 2;
            this.lblStaff.Text = "Monthly staff \r\nwages:";
            // 
            // Profits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 244);
            this.Controls.Add(this.lblStaff);
            this.Controls.Add(this.lblOrders);
            this.Controls.Add(this.dataProfit);
            this.Name = "Profits";
            this.Text = "Profits";
            this.Load += new System.EventHandler(this.Profits_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataProfit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataProfit;
        private System.Windows.Forms.Label lblOrders;
        private System.Windows.Forms.Label lblStaff;
    }
}