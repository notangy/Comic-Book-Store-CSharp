namespace Comic_Book_Store
{
    partial class OrderEdit
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstItems = new System.Windows.Forms.ListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.txtDelivery = new System.Windows.Forms.TextBox();
            this.boxMail = new System.Windows.Forms.ComboBox();
            this.lblShipping = new System.Windows.Forms.Label();
            this.lstShops = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rdoDelivery = new System.Windows.Forms.RadioButton();
            this.rdoCollection = new System.Windows.Forms.RadioButton();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnBasket = new System.Windows.Forms.Button();
            this.lstBasket = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.lblStaff = new System.Windows.Forms.Label();
            this.chkPaidY = new System.Windows.Forms.CheckBox();
            this.chkPaidN = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Delivery Address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mail Service:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Items:";
            // 
            // lstItems
            // 
            this.lstItems.FormattingEnabled = true;
            this.lstItems.Location = new System.Drawing.Point(13, 41);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(113, 121);
            this.lstItems.TabIndex = 3;
            this.lstItems.SelectedIndexChanged += new System.EventHandler(this.lstItems_SelectedIndexChanged);
            // 
            // btnRemove
            // 
            this.btnRemove.Enabled = false;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(143, 45);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(90, 31);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove item";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // txtDelivery
            // 
            this.txtDelivery.Location = new System.Drawing.Point(120, 204);
            this.txtDelivery.Multiline = true;
            this.txtDelivery.Name = "txtDelivery";
            this.txtDelivery.Size = new System.Drawing.Size(126, 52);
            this.txtDelivery.TabIndex = 5;
            this.txtDelivery.TextChanged += new System.EventHandler(this.txtDelivery_TextChanged);
            // 
            // boxMail
            // 
            this.boxMail.FormattingEnabled = true;
            this.boxMail.Location = new System.Drawing.Point(120, 272);
            this.boxMail.Name = "boxMail";
            this.boxMail.Size = new System.Drawing.Size(126, 21);
            this.boxMail.TabIndex = 6;
            this.boxMail.SelectedIndexChanged += new System.EventHandler(this.boxMail_SelectedIndexChanged);
            // 
            // lblShipping
            // 
            this.lblShipping.AutoSize = true;
            this.lblShipping.Location = new System.Drawing.Point(117, 306);
            this.lblShipping.Name = "lblShipping";
            this.lblShipping.Size = new System.Drawing.Size(51, 13);
            this.lblShipping.TabIndex = 9;
            this.lblShipping.Text = "Shipping:";
            this.lblShipping.Visible = false;
            // 
            // lstShops
            // 
            this.lstShops.FormattingEnabled = true;
            this.lstShops.Location = new System.Drawing.Point(134, 329);
            this.lstShops.Name = "lstShops";
            this.lstShops.Size = new System.Drawing.Size(112, 95);
            this.lstShops.TabIndex = 10;
            this.lstShops.SelectedIndexChanged += new System.EventHandler(this.lstShops_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Shop to collect from:";
            // 
            // rdoDelivery
            // 
            this.rdoDelivery.AutoSize = true;
            this.rdoDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoDelivery.Location = new System.Drawing.Point(143, 147);
            this.rdoDelivery.Name = "rdoDelivery";
            this.rdoDelivery.Size = new System.Drawing.Size(68, 19);
            this.rdoDelivery.TabIndex = 12;
            this.rdoDelivery.TabStop = true;
            this.rdoDelivery.Text = "Delivery";
            this.rdoDelivery.UseVisualStyleBackColor = true;
            // 
            // rdoCollection
            // 
            this.rdoCollection.AutoSize = true;
            this.rdoCollection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoCollection.Location = new System.Drawing.Point(143, 170);
            this.rdoCollection.Name = "rdoCollection";
            this.rdoCollection.Size = new System.Drawing.Size(79, 19);
            this.rdoCollection.TabIndex = 13;
            this.rdoCollection.Text = "Collection";
            this.rdoCollection.UseVisualStyleBackColor = true;
            this.rdoCollection.CheckedChanged += new System.EventHandler(this.rdoCollection_CheckedChanged);
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(14, 362);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(86, 15);
            this.lblLocation.TabIndex = 14;
            this.lblLocation.Text = "Shop Location";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(271, 182);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(48, 20);
            this.lblTotal.TabIndex = 19;
            this.lblTotal.Text = "Total:";
            // 
            // btnBasket
            // 
            this.btnBasket.Enabled = false;
            this.btnBasket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBasket.Location = new System.Drawing.Point(143, 82);
            this.btnBasket.Name = "btnBasket";
            this.btnBasket.Size = new System.Drawing.Size(90, 59);
            this.btnBasket.TabIndex = 20;
            this.btnBasket.Text = "Add from basket";
            this.btnBasket.UseVisualStyleBackColor = true;
            this.btnBasket.Click += new System.EventHandler(this.btnBasket_Click);
            // 
            // lstBasket
            // 
            this.lstBasket.FormattingEnabled = true;
            this.lstBasket.Location = new System.Drawing.Point(253, 40);
            this.lstBasket.Name = "lstBasket";
            this.lstBasket.Size = new System.Drawing.Size(113, 121);
            this.lstBasket.TabIndex = 21;
            this.lstBasket.SelectedIndexChanged += new System.EventHandler(this.lstBasket_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(246, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "Basket:";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(275, 360);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(81, 60);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save changes";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPay
            // 
            this.btnPay.Enabled = false;
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Location = new System.Drawing.Point(382, 363);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(72, 56);
            this.btnPay.TabIndex = 15;
            this.btnPay.Text = "Pay now";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(295, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Payment details:";
            // 
            // txtPayment
            // 
            this.txtPayment.Location = new System.Drawing.Point(298, 245);
            this.txtPayment.Multiline = true;
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(126, 84);
            this.txtPayment.TabIndex = 18;
            this.txtPayment.TextChanged += new System.EventHandler(this.txtPay_TextChanged);
            // 
            // lblStaff
            // 
            this.lblStaff.AutoSize = true;
            this.lblStaff.Location = new System.Drawing.Point(381, 40);
            this.lblStaff.Name = "lblStaff";
            this.lblStaff.Size = new System.Drawing.Size(99, 13);
            this.lblStaff.TabIndex = 24;
            this.lblStaff.Text = "STAFF OVERRIDE";
            this.lblStaff.Visible = false;
            // 
            // chkPaidY
            // 
            this.chkPaidY.AutoSize = true;
            this.chkPaidY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPaidY.Location = new System.Drawing.Point(386, 69);
            this.chkPaidY.Name = "chkPaidY";
            this.chkPaidY.Size = new System.Drawing.Size(85, 19);
            this.chkPaidY.TabIndex = 25;
            this.chkPaidY.Text = "Paid = true";
            this.chkPaidY.UseVisualStyleBackColor = true;
            this.chkPaidY.Visible = false;
            this.chkPaidY.CheckedChanged += new System.EventHandler(this.chkPaidY_CheckedChanged);
            // 
            // chkPaidN
            // 
            this.chkPaidN.AutoSize = true;
            this.chkPaidN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPaidN.Location = new System.Drawing.Point(384, 94);
            this.chkPaidN.Name = "chkPaidN";
            this.chkPaidN.Size = new System.Drawing.Size(84, 19);
            this.chkPaidN.TabIndex = 26;
            this.chkPaidN.Text = "Paid=false";
            this.chkPaidN.UseVisualStyleBackColor = true;
            this.chkPaidN.Visible = false;
            this.chkPaidN.CheckedChanged += new System.EventHandler(this.chkPaidN_CheckedChanged);
            // 
            // OrderEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 436);
            this.Controls.Add(this.chkPaidN);
            this.Controls.Add(this.chkPaidY);
            this.Controls.Add(this.lblStaff);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lstBasket);
            this.Controls.Add(this.btnBasket);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtPayment);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.rdoCollection);
            this.Controls.Add(this.rdoDelivery);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstShops);
            this.Controls.Add(this.lblShipping);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.boxMail);
            this.Controls.Add(this.txtDelivery);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lstItems);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OrderEdit";
            this.Text = "OrderEdit";
            this.Load += new System.EventHandler(this.OrderEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstItems;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox txtDelivery;
        private System.Windows.Forms.ComboBox boxMail;
        private System.Windows.Forms.Label lblShipping;
        private System.Windows.Forms.ListBox lstShops;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdoDelivery;
        private System.Windows.Forms.RadioButton rdoCollection;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnBasket;
        private System.Windows.Forms.ListBox lstBasket;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPayment;
        private System.Windows.Forms.Label lblStaff;
        private System.Windows.Forms.CheckBox chkPaidY;
        private System.Windows.Forms.CheckBox chkPaidN;
    }
}