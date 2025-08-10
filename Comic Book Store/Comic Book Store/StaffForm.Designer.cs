namespace Comic_Book_Store
{
    partial class StaffForm
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
            this.lblGreeting = new System.Windows.Forms.Label();
            this.btnProfits = new System.Windows.Forms.Button();
            this.btnCus = new System.Windows.Forms.Button();
            this.btnInven = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnPers = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreeting.Location = new System.Drawing.Point(26, 35);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(53, 20);
            this.lblGreeting.TabIndex = 0;
            this.lblGreeting.Text = "Hello !";
            // 
            // btnProfits
            // 
            this.btnProfits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfits.Location = new System.Drawing.Point(147, 185);
            this.btnProfits.Name = "btnProfits";
            this.btnProfits.Size = new System.Drawing.Size(81, 50);
            this.btnProfits.TabIndex = 3;
            this.btnProfits.Text = "View profits";
            this.btnProfits.UseVisualStyleBackColor = true;
            this.btnProfits.Click += new System.EventHandler(this.btnProfits_Click);
            // 
            // btnCus
            // 
            this.btnCus.Enabled = false;
            this.btnCus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCus.Location = new System.Drawing.Point(147, 73);
            this.btnCus.Name = "btnCus";
            this.btnCus.Size = new System.Drawing.Size(81, 50);
            this.btnCus.TabIndex = 4;
            this.btnCus.Text = "View customers";
            this.btnCus.UseVisualStyleBackColor = true;
            this.btnCus.Click += new System.EventHandler(this.btnCus_Click);
            // 
            // btnInven
            // 
            this.btnInven.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInven.Location = new System.Drawing.Point(44, 82);
            this.btnInven.Name = "btnInven";
            this.btnInven.Size = new System.Drawing.Size(91, 82);
            this.btnInven.TabIndex = 6;
            this.btnInven.Text = "View inventory";
            this.btnInven.UseVisualStyleBackColor = true;
            this.btnInven.Click += new System.EventHandler(this.btnInven_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.Enabled = false;
            this.btnOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrders.Location = new System.Drawing.Point(44, 185);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(81, 50);
            this.btnOrders.TabIndex = 7;
            this.btnOrders.Text = "View orders";
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnPers
            // 
            this.btnPers.Enabled = false;
            this.btnPers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPers.Location = new System.Drawing.Point(147, 129);
            this.btnPers.Name = "btnPers";
            this.btnPers.Size = new System.Drawing.Size(81, 50);
            this.btnPers.TabIndex = 8;
            this.btnPers.Text = "View personnel";
            this.btnPers.UseVisualStyleBackColor = true;
            this.btnPers.Click += new System.EventHandler(this.btnPers_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(274, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 276);
            this.Controls.Add(this.btnPers);
            this.Controls.Add(this.btnOrders);
            this.Controls.Add(this.btnInven);
            this.Controls.Add(this.btnCus);
            this.Controls.Add(this.btnProfits);
            this.Controls.Add(this.lblGreeting);
            this.Controls.Add(this.menuStrip1);
            this.Name = "StaffForm";
            this.Text = "StaffForm";
            this.Load += new System.EventHandler(this.StaffForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGreeting;
        private System.Windows.Forms.Button btnProfits;
        private System.Windows.Forms.Button btnCus;
        private System.Windows.Forms.Button btnInven;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnPers;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
    }
}