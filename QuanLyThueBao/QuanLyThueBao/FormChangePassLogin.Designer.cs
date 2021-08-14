namespace QuanLyThueBao
{
    partial class FormChangePassLogin
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
            this.txtTitle = new System.Windows.Forms.Label();
            this.showPw = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtRePw = new System.Windows.Forms.TextBox();
            this.panelUser = new System.Windows.Forms.Panel();
            this.txtNewPw = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnA = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtOldPw = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.AutoSize = true;
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.ForeColor = System.Drawing.Color.White;
            this.txtTitle.Location = new System.Drawing.Point(12, 9);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(37, 24);
            this.txtTitle.TabIndex = 35;
            this.txtTitle.Text = "title";
            // 
            // showPw
            // 
            this.showPw.AutoSize = true;
            this.showPw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPw.ForeColor = System.Drawing.Color.White;
            this.showPw.Location = new System.Drawing.Point(525, 342);
            this.showPw.Name = "showPw";
            this.showPw.Size = new System.Drawing.Size(135, 20);
            this.showPw.TabIndex = 34;
            this.showPw.Text = "Hiển Thị Mật Khẩu";
            this.showPw.UseVisualStyleBackColor = true;
            this.showPw.CheckedChanged += new System.EventHandler(this.showPw_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(460, 319);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 2);
            this.panel1.TabIndex = 33;
            // 
            // txtRePw
            // 
            this.txtRePw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtRePw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRePw.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRePw.ForeColor = System.Drawing.Color.White;
            this.txtRePw.Location = new System.Drawing.Point(462, 292);
            this.txtRePw.Name = "txtRePw";
            this.txtRePw.Size = new System.Drawing.Size(400, 28);
            this.txtRePw.TabIndex = 32;
            this.txtRePw.UseSystemPasswordChar = true;
            // 
            // panelUser
            // 
            this.panelUser.BackColor = System.Drawing.Color.White;
            this.panelUser.Location = new System.Drawing.Point(460, 269);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(400, 2);
            this.panelUser.TabIndex = 31;
            // 
            // txtNewPw
            // 
            this.txtNewPw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtNewPw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewPw.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPw.ForeColor = System.Drawing.Color.White;
            this.txtNewPw.Location = new System.Drawing.Point(462, 241);
            this.txtNewPw.Name = "txtNewPw";
            this.txtNewPw.Size = new System.Drawing.Size(400, 28);
            this.txtNewPw.TabIndex = 30;
            this.txtNewPw.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(346, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Mật Khẩu Mới:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(380, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Nhập Lại:";
            // 
            // btnA
            // 
            this.btnA.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnA.FlatAppearance.BorderSize = 0;
            this.btnA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA.ForeColor = System.Drawing.Color.White;
            this.btnA.Location = new System.Drawing.Point(551, 380);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(133, 40);
            this.btnA.TabIndex = 27;
            this.btnA.Text = "Xác Nhận";
            this.btnA.UseVisualStyleBackColor = false;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(460, 220);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 2);
            this.panel2.TabIndex = 34;
            // 
            // txtOldPw
            // 
            this.txtOldPw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtOldPw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOldPw.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOldPw.ForeColor = System.Drawing.Color.White;
            this.txtOldPw.Location = new System.Drawing.Point(462, 193);
            this.txtOldPw.Name = "txtOldPw";
            this.txtOldPw.Size = new System.Drawing.Size(400, 28);
            this.txtOldPw.TabIndex = 33;
            this.txtOldPw.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(351, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Mật Khẩu Cũ:";
            // 
            // FormChangePassLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1087, 550);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtOldPw);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.showPw);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtRePw);
            this.Controls.Add(this.panelUser);
            this.Controls.Add(this.txtNewPw);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnA);
            this.Name = "FormChangePassLogin";
            this.Text = "Đổi Mật Khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtTitle;
        private System.Windows.Forms.CheckBox showPw;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtRePw;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.TextBox txtNewPw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtOldPw;
        private System.Windows.Forms.Label label3;
    }
}