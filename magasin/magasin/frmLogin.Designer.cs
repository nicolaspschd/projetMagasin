﻿namespace magasin
{
    partial class frmLogin
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
            this.btnInscription = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tbxLogin = new System.Windows.Forms.TextBox();
            this.tbxMdp = new System.Windows.Forms.TextBox();
            this.lblMdpInfo = new System.Windows.Forms.Label();
            this.lblAvert = new System.Windows.Forms.Label();
            this.lblLoginInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInscription
            // 
            this.btnInscription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(86)))));
            this.btnInscription.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInscription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(208)))), ((int)(((byte)(192)))));
            this.btnInscription.Location = new System.Drawing.Point(153, 117);
            this.btnInscription.Name = "btnInscription";
            this.btnInscription.Size = new System.Drawing.Size(172, 23);
            this.btnInscription.TabIndex = 4;
            this.btnInscription.Text = "Inscription";
            this.btnInscription.UseVisualStyleBackColor = false;
            this.btnInscription.Click += new System.EventHandler(this.btnInscription_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(86)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(208)))), ((int)(((byte)(192)))));
            this.btnLogin.Location = new System.Drawing.Point(153, 88);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(172, 23);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbxLogin
            // 
            this.tbxLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(86)))));
            this.tbxLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(208)))), ((int)(((byte)(192)))));
            this.tbxLogin.Location = new System.Drawing.Point(153, 12);
            this.tbxLogin.Name = "tbxLogin";
            this.tbxLogin.Size = new System.Drawing.Size(172, 26);
            this.tbxLogin.TabIndex = 0;
            this.tbxLogin.TextChanged += new System.EventHandler(this.tbxMdp_TextChanged);
            // 
            // tbxMdp
            // 
            this.tbxMdp.AccessibleDescription = "";
            this.tbxMdp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(86)))));
            this.tbxMdp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxMdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMdp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(208)))), ((int)(((byte)(192)))));
            this.tbxMdp.Location = new System.Drawing.Point(153, 44);
            this.tbxMdp.Name = "tbxMdp";
            this.tbxMdp.PasswordChar = '*';
            this.tbxMdp.Size = new System.Drawing.Size(172, 26);
            this.tbxMdp.TabIndex = 1;
            this.tbxMdp.Tag = "";
            this.tbxMdp.TextChanged += new System.EventHandler(this.tbxMdp_TextChanged);
            // 
            // lblMdpInfo
            // 
            this.lblMdpInfo.AutoSize = true;
            this.lblMdpInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMdpInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(208)))), ((int)(((byte)(192)))));
            this.lblMdpInfo.Location = new System.Drawing.Point(14, 49);
            this.lblMdpInfo.Name = "lblMdpInfo";
            this.lblMdpInfo.Size = new System.Drawing.Size(90, 16);
            this.lblMdpInfo.TabIndex = 0;
            this.lblMdpInfo.Text = "Mot de passe";
            // 
            // lblAvert
            // 
            this.lblAvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(208)))), ((int)(((byte)(192)))));
            this.lblAvert.Location = new System.Drawing.Point(12, 100);
            this.lblAvert.Name = "lblAvert";
            this.lblAvert.Size = new System.Drawing.Size(135, 40);
            this.lblAvert.TabIndex = 5;
            this.lblAvert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLoginInfo
            // 
            this.lblLoginInfo.AutoSize = true;
            this.lblLoginInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(208)))), ((int)(((byte)(192)))));
            this.lblLoginInfo.Location = new System.Drawing.Point(14, 17);
            this.lblLoginInfo.Name = "lblLoginInfo";
            this.lblLoginInfo.Size = new System.Drawing.Size(41, 16);
            this.lblLoginInfo.TabIndex = 0;
            this.lblLoginInfo.Text = "Login";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(337, 153);
            this.Controls.Add(this.lblAvert);
            this.Controls.Add(this.tbxMdp);
            this.Controls.Add(this.tbxLogin);
            this.Controls.Add(this.lblMdpInfo);
            this.Controls.Add(this.lblLoginInfo);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnInscription);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInscription;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox tbxLogin;
        private System.Windows.Forms.TextBox tbxMdp;
        private System.Windows.Forms.Label lblMdpInfo;
        private System.Windows.Forms.Label lblAvert;
        private System.Windows.Forms.Label lblLoginInfo;
    }
}