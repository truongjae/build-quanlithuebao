namespace QuanLyThueBao
{
    partial class FormPhoneCalling
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
            this.btnCallCancel = new System.Windows.Forms.PictureBox();
            this.lbTimeNow = new System.Windows.Forms.Label();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.lbMinute = new System.Windows.Forms.Label();
            this.picAvt = new QuanLyThueBao.RJCircularPictureBox();
            this.txtName = new System.Windows.Forms.Label();
            this.timeCountSecond = new System.Windows.Forms.Timer(this.components);
            this.timeNow = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btnCallCancel)).BeginInit();
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvt)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCallCancel
            // 
            this.btnCallCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCallCancel.Image = global::QuanLyThueBao.Properties.Resources.callcancel;
            this.btnCallCancel.Location = new System.Drawing.Point(146, 523);
            this.btnCallCancel.Name = "btnCallCancel";
            this.btnCallCancel.Size = new System.Drawing.Size(63, 63);
            this.btnCallCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCallCancel.TabIndex = 0;
            this.btnCallCancel.TabStop = false;
            this.btnCallCancel.Click += new System.EventHandler(this.btnCallCancel_Click);
            // 
            // lbTimeNow
            // 
            this.lbTimeNow.AutoSize = true;
            this.lbTimeNow.BackColor = System.Drawing.Color.Transparent;
            this.lbTimeNow.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbTimeNow.ForeColor = System.Drawing.Color.White;
            this.lbTimeNow.Location = new System.Drawing.Point(38, 29);
            this.lbTimeNow.Name = "lbTimeNow";
            this.lbTimeNow.Size = new System.Drawing.Size(45, 19);
            this.lbTimeNow.TabIndex = 1;
            this.lbTimeNow.Text = "00:00";
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.Transparent;
            this.panelInfo.Controls.Add(this.lbMinute);
            this.panelInfo.Controls.Add(this.picAvt);
            this.panelInfo.Controls.Add(this.txtName);
            this.panelInfo.Location = new System.Drawing.Point(27, 77);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(300, 88);
            this.panelInfo.TabIndex = 52;
            // 
            // lbMinute
            // 
            this.lbMinute.AutoSize = true;
            this.lbMinute.BackColor = System.Drawing.Color.Transparent;
            this.lbMinute.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMinute.ForeColor = System.Drawing.Color.LightGray;
            this.lbMinute.Location = new System.Drawing.Point(96, 51);
            this.lbMinute.Name = "lbMinute";
            this.lbMinute.Size = new System.Drawing.Size(65, 28);
            this.lbMinute.TabIndex = 47;
            this.lbMinute.Text = "00:00";
            // 
            // picAvt
            // 
            this.picAvt.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.picAvt.BorderColor = System.Drawing.Color.RoyalBlue;
            this.picAvt.BorderColor2 = System.Drawing.Color.HotPink;
            this.picAvt.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.picAvt.BorderSize = 1;
            this.picAvt.GradientAngle = 50F;
            this.picAvt.Location = new System.Drawing.Point(9, 2);
            this.picAvt.Name = "picAvt";
            this.picAvt.Size = new System.Drawing.Size(70, 70);
            this.picAvt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvt.TabIndex = 46;
            this.picAvt.TabStop = false;
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(76, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(118, 38);
            this.txtName.TabIndex = 45;
            this.txtName.Text = "Truong";
            // 
            // timeCountSecond
            // 
            this.timeCountSecond.Interval = 1000;
            this.timeCountSecond.Tick += new System.EventHandler(this.timeCountSecond_Tick);
            // 
            // timeNow
            // 
            this.timeNow.Tick += new System.EventHandler(this.timeNow_Tick);
            // 
            // FormPhoneCalling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::QuanLyThueBao.Properties.Resources.phonecalling;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(354, 711);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.lbTimeNow);
            this.Controls.Add(this.btnCallCancel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPhoneCalling";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPhoneCalling";
            ((System.ComponentModel.ISupportInitialize)(this.btnCallCancel)).EndInit();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnCallCancel;
        private System.Windows.Forms.Label lbTimeNow;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label lbMinute;
        private RJCircularPictureBox picAvt;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.Timer timeCountSecond;
        private System.Windows.Forms.Timer timeNow;
    }
}