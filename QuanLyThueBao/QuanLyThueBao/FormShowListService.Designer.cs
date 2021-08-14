namespace QuanLyThueBao
{
    partial class FormShowListService
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
            this.flpanelListSv = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpanelListSv
            // 
            this.flpanelListSv.AutoScroll = true;
            this.flpanelListSv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.flpanelListSv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpanelListSv.Location = new System.Drawing.Point(0, 0);
            this.flpanelListSv.Name = "flpanelListSv";
            this.flpanelListSv.Size = new System.Drawing.Size(1227, 583);
            this.flpanelListSv.TabIndex = 0;
            // 
            // FormShowListService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 583);
            this.Controls.Add(this.flpanelListSv);
            this.Name = "FormShowListService";
            this.Text = "DS Dịch Vụ";
            this.Load += new System.EventHandler(this.FormShowListService_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpanelListSv;

    }
}