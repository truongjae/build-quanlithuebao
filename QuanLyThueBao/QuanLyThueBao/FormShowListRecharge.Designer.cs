namespace QuanLyThueBao
{
    partial class FormShowListRecharge
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
            this.flpanelListRec = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpanelListRec
            // 
            this.flpanelListRec.AutoScroll = true;
            this.flpanelListRec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpanelListRec.Location = new System.Drawing.Point(0, 0);
            this.flpanelListRec.Name = "flpanelListRec";
            this.flpanelListRec.Size = new System.Drawing.Size(1211, 544);
            this.flpanelListRec.TabIndex = 0;
            // 
            // FormShowListRecharge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1211, 544);
            this.Controls.Add(this.flpanelListRec);
            this.Name = "FormShowListRecharge";
            this.Text = "LS Nạp Thẻ";
            this.Load += new System.EventHandler(this.FormShowListRecharge_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpanelListRec;
    }
}