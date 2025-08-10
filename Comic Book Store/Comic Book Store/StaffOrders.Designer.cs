namespace Comic_Book_Store
{
    partial class StaffOrders
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
            this.dataOrders = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.chkID = new System.Windows.Forms.CheckBox();
            this.dataItems = new System.Windows.Forms.DataGridView();
            this.lblItems = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataItems)).BeginInit();
            this.SuspendLayout();
            // 
            // dataOrders
            // 
            this.dataOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataOrders.Location = new System.Drawing.Point(12, 117);
            this.dataOrders.Name = "dataOrders";
            this.dataOrders.ReadOnly = true;
            this.dataOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataOrders.Size = new System.Drawing.Size(428, 122);
            this.dataOrders.TabIndex = 0;
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(30, 21);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(101, 43);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit order";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(137, 21);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(101, 43);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete order";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(179, 80);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(85, 20);
            this.txtID.TabIndex = 4;
            // 
            // chkID
            // 
            this.chkID.AutoSize = true;
            this.chkID.Enabled = false;
            this.chkID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkID.Location = new System.Drawing.Point(47, 80);
            this.chkID.Name = "chkID";
            this.chkID.Size = new System.Drawing.Size(126, 20);
            this.chkID.TabIndex = 5;
            this.chkID.Text = "Alter by order ID:";
            this.chkID.UseVisualStyleBackColor = true;
            this.chkID.CheckedChanged += new System.EventHandler(this.chkID_CheckedChanged);
            // 
            // dataItems
            // 
            this.dataItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataItems.Location = new System.Drawing.Point(116, 282);
            this.dataItems.Name = "dataItems";
            this.dataItems.ReadOnly = true;
            this.dataItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataItems.Size = new System.Drawing.Size(226, 122);
            this.dataItems.TabIndex = 6;
            // 
            // lblItems
            // 
            this.lblItems.AutoSize = true;
            this.lblItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItems.Location = new System.Drawing.Point(12, 261);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(86, 18);
            this.lblItems.TabIndex = 7;
            this.lblItems.Text = "Order Items";
            // 
            // StaffOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 416);
            this.Controls.Add(this.lblItems);
            this.Controls.Add(this.dataItems);
            this.Controls.Add(this.chkID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dataOrders);
            this.Name = "StaffOrders";
            this.Text = "AllOrders";
            this.Load += new System.EventHandler(this.AllOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataOrders;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.CheckBox chkID;
        private System.Windows.Forms.DataGridView dataItems;
        private System.Windows.Forms.Label lblItems;
    }
}