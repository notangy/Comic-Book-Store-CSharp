namespace Comic_Book_Store
{
    partial class Records
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
            this.dataRecords = new System.Windows.Forms.DataGridView();
            this.lblRecords = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // dataRecords
            // 
            this.dataRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataRecords.Location = new System.Drawing.Point(25, 72);
            this.dataRecords.Name = "dataRecords";
            this.dataRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataRecords.Size = new System.Drawing.Size(331, 270);
            this.dataRecords.TabIndex = 0;
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.Location = new System.Drawing.Point(22, 25);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(135, 18);
            this.lblRecords.TabIndex = 1;
            this.lblRecords.Text = "Customer Records";
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(191, 18);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(97, 33);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete user";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // Records
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 367);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.dataRecords);
            this.Name = "Records";
            this.Text = "CusRecords";
            this.Load += new System.EventHandler(this.CusRecords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataRecords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataRecords;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Button btnDelete;
    }
}