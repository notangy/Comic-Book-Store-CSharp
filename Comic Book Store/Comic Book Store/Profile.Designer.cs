namespace Comic_Book_Store
{
    partial class Profile
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
            this.components = new System.ComponentModel.Container();
            this.imgAvatar = new System.Windows.Forms.PictureBox();
            this.btnPass = new System.Windows.Forms.Button();
            this.btnAvatar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.avatarDialog = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtPassword2 = new System.Windows.Forms.TextBox();
            this.lblVIP = new System.Windows.Forms.Label();
            this.boxPrefs = new System.Windows.Forms.ComboBox();
            this.lblWho = new System.Windows.Forms.Label();
            this.btnSavePref = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // imgAvatar
            // 
            this.imgAvatar.Location = new System.Drawing.Point(12, 33);
            this.imgAvatar.Name = "imgAvatar";
            this.imgAvatar.Size = new System.Drawing.Size(131, 134);
            this.imgAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgAvatar.TabIndex = 0;
            this.imgAvatar.TabStop = false;
            // 
            // btnPass
            // 
            this.btnPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPass.Location = new System.Drawing.Point(273, 33);
            this.btnPass.Name = "btnPass";
            this.btnPass.Size = new System.Drawing.Size(70, 77);
            this.btnPass.TabIndex = 2;
            this.btnPass.Text = "Change password";
            this.btnPass.UseVisualStyleBackColor = true;
            this.btnPass.Click += new System.EventHandler(this.btnPass_Click);
            // 
            // btnAvatar
            // 
            this.btnAvatar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvatar.Location = new System.Drawing.Point(12, 173);
            this.btnAvatar.Name = "btnAvatar";
            this.btnAvatar.Size = new System.Drawing.Size(124, 37);
            this.btnAvatar.TabIndex = 4;
            this.btnAvatar.Text = "Change avatar";
            this.btnAvatar.UseVisualStyleBackColor = true;
            this.btnAvatar.Click += new System.EventHandler(this.btnAvatar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Avatar:";
            // 
            // avatarDialog
            // 
            this.avatarDialog.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(153, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "New password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(153, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Re-enter password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(156, 40);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(105, 20);
            this.txtPassword.TabIndex = 8;
            // 
            // txtPassword2
            // 
            this.txtPassword2.Location = new System.Drawing.Point(156, 84);
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.Size = new System.Drawing.Size(105, 20);
            this.txtPassword2.TabIndex = 9;
            // 
            // lblVIP
            // 
            this.lblVIP.AutoSize = true;
            this.lblVIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVIP.Location = new System.Drawing.Point(12, 220);
            this.lblVIP.Name = "lblVIP";
            this.lblVIP.Size = new System.Drawing.Size(45, 16);
            this.lblVIP.TabIndex = 10;
            this.lblVIP.Text = "label4";
            // 
            // boxPrefs
            // 
            this.boxPrefs.FormattingEnabled = true;
            this.boxPrefs.Location = new System.Drawing.Point(175, 162);
            this.boxPrefs.Name = "boxPrefs";
            this.boxPrefs.Size = new System.Drawing.Size(121, 21);
            this.boxPrefs.TabIndex = 11;
            // 
            // lblWho
            // 
            this.lblWho.AutoSize = true;
            this.lblWho.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWho.Location = new System.Drawing.Point(149, 135);
            this.lblWho.Name = "lblWho";
            this.lblWho.Size = new System.Drawing.Size(192, 15);
            this.lblWho.TabIndex = 12;
            this.lblWho.Text = "Who is your favourite supoerhero?";
            // 
            // btnSavePref
            // 
            this.btnSavePref.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavePref.Location = new System.Drawing.Point(175, 189);
            this.btnSavePref.Name = "btnSavePref";
            this.btnSavePref.Size = new System.Drawing.Size(113, 47);
            this.btnSavePref.TabIndex = 13;
            this.btnSavePref.Text = "Save preference";
            this.btnSavePref.UseVisualStyleBackColor = true;
            this.btnSavePref.Click += new System.EventHandler(this.btnSavePref_Click);
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 273);
            this.Controls.Add(this.btnSavePref);
            this.Controls.Add(this.lblWho);
            this.Controls.Add(this.boxPrefs);
            this.Controls.Add(this.lblVIP);
            this.Controls.Add(this.txtPassword2);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAvatar);
            this.Controls.Add(this.btnPass);
            this.Controls.Add(this.imgAvatar);
            this.Name = "Profile";
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.Profile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgAvatar;
        private System.Windows.Forms.Button btnPass;
        private System.Windows.Forms.Button btnAvatar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog avatarDialog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtPassword2;
        private System.Windows.Forms.Label lblVIP;
        private System.Windows.Forms.ComboBox boxPrefs;
        private System.Windows.Forms.Label lblWho;
        private System.Windows.Forms.Button btnSavePref;
    }
}