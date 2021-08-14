namespace QuanLyThueBao
{
    partial class FormSendMess
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.picClose = new QuanLyThueBao.RJCircularPictureBox();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.picAvt = new QuanLyThueBao.RJCircularPictureBox();
            this.txtName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.txtReceiver = new System.Windows.Forms.ComboBox();
            this.panelUser = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvt)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.picClose);
            this.panel1.Controls.Add(this.panelInfo);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtReceiver);
            this.panel1.Controls.Add(this.panelUser);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSend);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(555, 340);
            this.panel1.TabIndex = 0;
            // 
            // picClose
            // 
            this.picClose.BackColor = System.Drawing.Color.DodgerBlue;
            this.picClose.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.picClose.BorderColor = System.Drawing.Color.RoyalBlue;
            this.picClose.BorderColor2 = System.Drawing.Color.HotPink;
            this.picClose.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.picClose.BorderSize = 3;
            this.picClose.GradientAngle = 50F;
            this.picClose.Image = global::QuanLyThueBao.Properties.Resources.close;
            this.picClose.Location = new System.Drawing.Point(513, -2);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(41, 41);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picClose.TabIndex = 51;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            this.picClose.MouseLeave += new System.EventHandler(this.picClose_MouseLeave);
            this.picClose.MouseHover += new System.EventHandler(this.picClose_MouseHover);
            // 
            // panelInfo
            // 
            this.panelInfo.Controls.Add(this.picAvt);
            this.panelInfo.Controls.Add(this.txtName);
            this.panelInfo.Location = new System.Drawing.Point(65, 64);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(426, 69);
            this.panelInfo.TabIndex = 50;
            // 
            // picAvt
            // 
            this.picAvt.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.picAvt.BorderColor = System.Drawing.Color.RoyalBlue;
            this.picAvt.BorderColor2 = System.Drawing.Color.HotPink;
            this.picAvt.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.picAvt.BorderSize = 3;
            this.picAvt.GradientAngle = 50F;
            this.picAvt.Location = new System.Drawing.Point(3, -1);
            this.picAvt.Name = "picAvt";
            this.picAvt.Size = new System.Drawing.Size(70, 70);
            this.picAvt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvt.TabIndex = 46;
            this.picAvt.TabStop = false;
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtName.Location = new System.Drawing.Point(79, 24);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(0, 20);
            this.txtName.TabIndex = 45;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.txtContent);
            this.panel2.Location = new System.Drawing.Point(143, 138);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(348, 122);
            this.panel2.TabIndex = 49;
            // 
            // txtContent
            // 
            this.txtContent.BackColor = System.Drawing.Color.White;
            this.txtContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContent.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtContent.Location = new System.Drawing.Point(2, 2);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(344, 118);
            this.txtContent.TabIndex = 40;
            this.txtContent.UseSystemPasswordChar = true;
            this.txtContent.TextChanged += new System.EventHandler(this.txtContent_TextChanged);
            // 
            // txtReceiver
            // 
            this.txtReceiver.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtReceiver.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtReceiver.BackColor = System.Drawing.Color.White;
            this.txtReceiver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtReceiver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceiver.FormattingEnabled = true;
            this.txtReceiver.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtReceiver.Location = new System.Drawing.Point(144, 29);
            this.txtReceiver.Name = "txtReceiver";
            this.txtReceiver.Size = new System.Drawing.Size(346, 28);
            this.txtReceiver.TabIndex = 48;
            this.txtReceiver.TextChanged += new System.EventHandler(this.txtReceiver_TextChanged_1);
            // 
            // panelUser
            // 
            this.panelUser.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelUser.Location = new System.Drawing.Point(144, 57);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(346, 2);
            this.panelUser.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(69, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 46;
            this.label1.Text = "Gửi Đến:";
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(210, 283);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(133, 40);
            this.btnSend.TabIndex = 44;
            this.btnSend.Text = "Gửi";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(62, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 45;
            this.label2.Text = "Nội Dung:";
            // 
            // FormSendMess
            // 
            this.AcceptButton = this.btnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(557, 342);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSendMess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormSendMess_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvt)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelInfo;
        private RJCircularPictureBox picAvt;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.ComboBox txtReceiver;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label2;
        private RJCircularPictureBox picClose;

    }
}