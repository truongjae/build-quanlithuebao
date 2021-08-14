namespace QuanLyThueBao
{
    partial class FormShowListMess
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
            this.flpanelListMess = new System.Windows.Forms.FlowLayoutPanel();
            this.btnWriteMess = new QuanLyThueBao.RJCircularPictureBox();
            this.flpanelListMess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnWriteMess)).BeginInit();
            this.SuspendLayout();
            // 
            // flpanelListMess
            // 
            this.flpanelListMess.AutoScroll = true;
            this.flpanelListMess.Controls.Add(this.btnWriteMess);
            this.flpanelListMess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpanelListMess.Location = new System.Drawing.Point(0, 0);
            this.flpanelListMess.Name = "flpanelListMess";
            this.flpanelListMess.Size = new System.Drawing.Size(1211, 544);
            this.flpanelListMess.TabIndex = 0;
            // 
            // btnWriteMess
            // 
            this.btnWriteMess.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.btnWriteMess.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnWriteMess.BorderColor2 = System.Drawing.Color.HotPink;
            this.btnWriteMess.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.btnWriteMess.BorderSize = 3;
            this.btnWriteMess.GradientAngle = 50F;
            this.btnWriteMess.Location = new System.Drawing.Point(3, 3);
            this.btnWriteMess.Name = "btnWriteMess";
            this.btnWriteMess.Size = new System.Drawing.Size(63, 63);
            this.btnWriteMess.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnWriteMess.TabIndex = 0;
            this.btnWriteMess.TabStop = false;
            this.btnWriteMess.Click += new System.EventHandler(this.btnWriteMess_Click);
            // 
            // FormShowListMess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1211, 544);
            this.Controls.Add(this.flpanelListMess);
            this.Name = "FormShowListMess";
            this.Text = "DS Tin Nhắn";
            this.Load += new System.EventHandler(this.FormShowListMess_Load);
            this.flpanelListMess.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnWriteMess)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpanelListMess;
        private RJCircularPictureBox btnWriteMess;
    }
}