namespace QuanLyThueBao
{
    partial class FormForgotPW
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
            this.btnSendCode = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.lbFgPw = new System.Windows.Forms.Label();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.panelUser = new System.Windows.Forms.Panel();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.panelCode = new System.Windows.Forms.Panel();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.picBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSendCode
            // 
            this.btnSendCode.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSendCode.FlatAppearance.BorderSize = 0;
            this.btnSendCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendCode.ForeColor = System.Drawing.Color.White;
            this.btnSendCode.Location = new System.Drawing.Point(393, 102);
            this.btnSendCode.Name = "btnSendCode";
            this.btnSendCode.Size = new System.Drawing.Size(155, 46);
            this.btnSendCode.TabIndex = 13;
            this.btnSendCode.Text = "Nhận Mã Xác Nhận";
            this.btnSendCode.UseVisualStyleBackColor = false;
            this.btnSendCode.Click += new System.EventHandler(this.btnSendCode_Click);
            // 
            // btnA
            // 
            this.btnA.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnA.FlatAppearance.BorderSize = 0;
            this.btnA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA.ForeColor = System.Drawing.Color.White;
            this.btnA.Location = new System.Drawing.Point(304, 180);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(113, 32);
            this.btnA.TabIndex = 14;
            this.btnA.Text = "Xác Nhận";
            this.btnA.UseVisualStyleBackColor = false;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // lbFgPw
            // 
            this.lbFgPw.AutoSize = true;
            this.lbFgPw.Font = new System.Drawing.Font("Segoe Print", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFgPw.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbFgPw.Location = new System.Drawing.Point(115, 30);
            this.lbFgPw.Name = "lbFgPw";
            this.lbFgPw.Size = new System.Drawing.Size(356, 62);
            this.lbFgPw.TabIndex = 15;
            this.lbFgPw.Text = "password recovery";
            // 
            // picUser
            // 
            this.picUser.Image = global::QuanLyThueBao.Properties.Resources.username;
            this.picUser.Location = new System.Drawing.Point(39, 111);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(35, 35);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUser.TabIndex = 18;
            this.picUser.TabStop = false;
            // 
            // panelUser
            // 
            this.panelUser.BackColor = System.Drawing.Color.White;
            this.panelUser.Location = new System.Drawing.Point(83, 142);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(297, 2);
            this.panelUser.TabIndex = 17;
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.Color.White;
            this.txtUser.Location = new System.Drawing.Point(85, 115);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(297, 28);
            this.txtUser.TabIndex = 16;
            // 
            // panelCode
            // 
            this.panelCode.BackColor = System.Drawing.Color.White;
            this.panelCode.Location = new System.Drawing.Point(170, 210);
            this.panelCode.Name = "panelCode";
            this.panelCode.Size = new System.Drawing.Size(121, 2);
            this.panelCode.TabIndex = 20;
            // 
            // txtCode
            // 
            this.txtCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.ForeColor = System.Drawing.Color.White;
            this.txtCode.Location = new System.Drawing.Point(170, 182);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(121, 28);
            this.txtCode.TabIndex = 19;
            // 
            // picBack
            // 
            this.picBack.Image = global::QuanLyThueBao.Properties.Resources.back;
            this.picBack.Location = new System.Drawing.Point(9, 9);
            this.picBack.Name = "picBack";
            this.picBack.Size = new System.Drawing.Size(40, 40);
            this.picBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBack.TabIndex = 21;
            this.picBack.TabStop = false;
            this.picBack.Click += new System.EventHandler(this.picBack_Click);
            // 
            // FormForgotPW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(587, 235);
            this.Controls.Add(this.picBack);
            this.Controls.Add(this.panelCode);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.picUser);
            this.Controls.Add(this.panelUser);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lbFgPw);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.btnSendCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormForgotPW";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormForgotPW_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormForgotPW_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSendCode;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Label lbFgPw;
        private System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Panel panelCode;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.PictureBox picBack;
    }
}