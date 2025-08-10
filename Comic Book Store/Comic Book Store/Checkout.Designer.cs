namespace Comic_Book_Store
{
    partial class Checkout
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
            this.btnPay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtDelivery = new System.Windows.Forms.TextBox();
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFinal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.boxMail = new System.Windows.Forms.ComboBox();
            this.lblPoints = new System.Windows.Forms.Label();
            this.chkDelivery = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPay
            // 
            this.btnPay.Enabled = false;
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Location = new System.Drawing.Point(105, 227);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(72, 39);
            this.btnPay.TabIndex = 0;
            this.btnPay.Text = "Pay now";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter payment details:";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(14, 227);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 39);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save order";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtDelivery
            // 
            this.txtDelivery.Enabled = false;
            this.txtDelivery.Location = new System.Drawing.Point(216, 167);
            this.txtDelivery.Multiline = true;
            this.txtDelivery.Name = "txtDelivery";
            this.txtDelivery.Size = new System.Drawing.Size(119, 58);
            this.txtDelivery.TabIndex = 3;
            // 
            // txtPayment
            // 
            this.txtPayment.Location = new System.Drawing.Point(12, 126);
            this.txtPayment.Multiline = true;
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(165, 72);
            this.txtPayment.TabIndex = 5;
            this.txtPayment.TextChanged += new System.EventHandler(this.txtPayment_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(214, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Delivery address:";
            // 
            // lblFinal
            // 
            this.lblFinal.AutoSize = true;
            this.lblFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinal.Location = new System.Drawing.Point(18, 21);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(82, 20);
            this.lblFinal.TabIndex = 8;
            this.lblFinal.Text = "Your total:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(225, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mail service:";
            // 
            // boxMail
            // 
            this.boxMail.Enabled = false;
            this.boxMail.FormattingEnabled = true;
            this.boxMail.Location = new System.Drawing.Point(216, 267);
            this.boxMail.Name = "boxMail";
            this.boxMail.Size = new System.Drawing.Size(119, 21);
            this.boxMail.TabIndex = 10;
            this.boxMail.SelectedIndexChanged += new System.EventHandler(this.boxMail_SelectedIndexChanged);
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints.Location = new System.Drawing.Point(18, 50);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(53, 20);
            this.lblPoints.TabIndex = 11;
            this.lblPoints.Text = "Points";
            // 
            // chkDelivery
            // 
            this.chkDelivery.AutoSize = true;
            this.chkDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDelivery.Location = new System.Drawing.Point(203, 109);
            this.chkDelivery.Name = "chkDelivery";
            this.chkDelivery.Size = new System.Drawing.Size(147, 19);
            this.chkDelivery.TabIndex = 12;
            this.chkDelivery.Text = "Choose home delivery";
            this.chkDelivery.UseVisualStyleBackColor = true;
            this.chkDelivery.CheckedChanged += new System.EventHandler(this.chkDelivery_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(200, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Your order will be ready at:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(201, 37);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(59, 16);
            this.lblAddress.TabIndex = 14;
            this.lblAddress.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(248, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Or...";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.Location = new System.Drawing.Point(214, 295);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(84, 15);
            this.lblMail.TabIndex = 16;
            this.lblMail.Text = "Shipping cost:";
            this.lblMail.Visible = false;
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 334);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkDelivery);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.boxMail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblFinal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPayment);
            this.Controls.Add(this.txtDelivery);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPay);
            this.Name = "Checkout";
            this.Text = "Checkout";
            this.Load += new System.EventHandler(this.Checkout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtDelivery;
        private System.Windows.Forms.TextBox txtPayment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox boxMail;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.CheckBox chkDelivery;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label lblFinal;
        private System.Windows.Forms.Label lblMail;
    }
}