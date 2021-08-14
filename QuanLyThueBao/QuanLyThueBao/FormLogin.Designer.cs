namespace QuanLyThueBao
{
    partial class FormLogin
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
            this.txtUser = new System.Windows.Forms.TextBox();
            this.linkForgotPw = new System.Windows.Forms.LinkLabel();
            this.showPw = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbLogin = new System.Windows.Forms.Label();
            this.panelUser = new System.Windows.Forms.Panel();
            this.panelPw = new System.Windows.Forms.Panel();
            this.txtPw = new System.Windows.Forms.TextBox();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnLogin = new System.Windows.Forms.PictureBox();
            this.picKey = new System.Windows.Forms.PictureBox();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.picWorld = new System.Windows.Forms.PictureBox();
            this.picOne = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWorld)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOne)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.Color.White;
            this.txtUser.Location = new System.Drawing.Point(79, 246);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(297, 28);
            this.txtUser.TabIndex = 1;
            // 
            // linkForgotPw
            // 
            this.linkForgotPw.AutoSize = true;
            this.linkForgotPw.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkForgotPw.LinkColor = System.Drawing.Color.White;
            this.linkForgotPw.Location = new System.Drawing.Point(166, 473);
            this.linkForgotPw.Name = "linkForgotPw";
            this.linkForgotPw.Size = new System.Drawing.Size(123, 18);
            this.linkForgotPw.TabIndex = 5;
            this.linkForgotPw.TabStop = true;
            this.linkForgotPw.Text = "Quên Mật Khẩu ?";
            this.linkForgotPw.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkForgotPw_LinkClicked);
            // 
            // showPw
            // 
            this.showPw.AutoSize = true;
            this.showPw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPw.ForeColor = System.Drawing.Color.White;
            this.showPw.Location = new System.Drawing.Point(79, 357);
            this.showPw.Name = "showPw";
            this.showPw.Size = new System.Drawing.Size(135, 20);
            this.showPw.TabIndex = 8;
            this.showPw.Text = "Hiển Thị Mật Khẩu";
            this.showPw.UseVisualStyleBackColor = true;
            this.showPw.CheckedChanged += new System.EventHandler(this.showPw_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.picWorld);
            this.panel1.Controls.Add(this.picOne);
            this.panel1.Location = new System.Drawing.Point(101, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 80);
            this.panel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(5, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 51);
            this.label1.TabIndex = 11;
            this.label1.Text = "TOP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Font = new System.Drawing.Font("Segoe Print", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogin.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbLogin.Location = new System.Drawing.Point(144, 139);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(167, 85);
            this.lbLogin.TabIndex = 12;
            this.lbLogin.Text = "Login";
            // 
            // panelUser
            // 
            this.panelUser.BackColor = System.Drawing.Color.White;
            this.panelUser.Location = new System.Drawing.Point(79, 274);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(297, 2);
            this.panelUser.TabIndex = 13;
            // 
            // panelPw
            // 
            this.panelPw.BackColor = System.Drawing.Color.White;
            this.panelPw.Location = new System.Drawing.Point(79, 336);
            this.panelPw.Name = "panelPw";
            this.panelPw.Size = new System.Drawing.Size(297, 2);
            this.panelPw.TabIndex = 16;
            // 
            // txtPw
            // 
            this.txtPw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtPw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPw.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPw.ForeColor = System.Drawing.Color.White;
            this.txtPw.Location = new System.Drawing.Point(79, 308);
            this.txtPw.Name = "txtPw";
            this.txtPw.Size = new System.Drawing.Size(297, 28);
            this.txtPw.TabIndex = 2;
            this.txtPw.UseSystemPasswordChar = true;
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.Font = new System.Drawing.Font("Microsoft JhengHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMax.ForeColor = System.Drawing.Color.White;
            this.btnMax.Location = new System.Drawing.Point(391, -4);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(30, 30);
            this.btnMax.TabIndex = 21;
            this.btnMax.Text = "o";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft JhengHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(424, -4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "o";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Font = new System.Drawing.Font("Microsoft JhengHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMin.ForeColor = System.Drawing.Color.White;
            this.btnMin.Location = new System.Drawing.Point(355, -4);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(30, 30);
            this.btnMin.TabIndex = 19;
            this.btnMin.Text = "o";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(167, 620);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(121, 15);
            this.linkLabel1.TabIndex = 22;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "©opyright TruongJae";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnLogin
            // 
            this.btnLogin.Image = global::QuanLyThueBao.Properties.Resources.login;
            this.btnLogin.Location = new System.Drawing.Point(202, 397);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(50, 50);
            this.btnLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnLogin.TabIndex = 18;
            this.btnLogin.TabStop = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
            // 
            // picKey
            // 
            this.picKey.Image = global::QuanLyThueBao.Properties.Resources.key;
            this.picKey.Location = new System.Drawing.Point(31, 305);
            this.picKey.Name = "picKey";
            this.picKey.Size = new System.Drawing.Size(35, 35);
            this.picKey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picKey.TabIndex = 17;
            this.picKey.TabStop = false;
            // 
            // picUser
            // 
            this.picUser.Image = global::QuanLyThueBao.Properties.Resources.username;
            this.picUser.Location = new System.Drawing.Point(31, 243);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(35, 35);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUser.TabIndex = 14;
            this.picUser.TabStop = false;
            // 
            // picWorld
            // 
            this.picWorld.Image = global::QuanLyThueBao.Properties.Resources.world;
            this.picWorld.Location = new System.Drawing.Point(172, 0);
            this.picWorld.Name = "picWorld";
            this.picWorld.Size = new System.Drawing.Size(80, 80);
            this.picWorld.TabIndex = 10;
            this.picWorld.TabStop = false;
            // 
            // picOne
            // 
            this.picOne.Image = global::QuanLyThueBao.Properties.Resources.top1;
            this.picOne.Location = new System.Drawing.Point(92, 0);
            this.picOne.Name = "picOne";
            this.picOne.Size = new System.Drawing.Size(80, 80);
            this.picOne.TabIndex = 9;
            this.picOne.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(455, 647);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.picKey);
            this.Controls.Add(this.panelPw);
            this.Controls.Add(this.txtPw);
            this.Controls.Add(this.picUser);
            this.Controls.Add(this.panelUser);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.showPw);
            this.Controls.Add(this.linkForgotPw);
            this.Controls.Add(this.txtUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(455, 647);
            this.MinimumSize = new System.Drawing.Size(455, 647);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormLogin_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWorld)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOne)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.LinkLabel linkForgotPw;
        private System.Windows.Forms.CheckBox showPw;
        private System.Windows.Forms.PictureBox picOne;
        private System.Windows.Forms.PictureBox picWorld;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.PictureBox picKey;
        private System.Windows.Forms.Panel panelPw;
        private System.Windows.Forms.TextBox txtPw;
        private System.Windows.Forms.PictureBox btnLogin;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}