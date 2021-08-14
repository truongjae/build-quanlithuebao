namespace QuanLyThueBao
{
    partial class FormShowListNotification
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
            this.SuspendLayout();
            // 
            // flpanelListMess
            // 
            this.flpanelListMess.AutoScroll = true;
            this.flpanelListMess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpanelListMess.Location = new System.Drawing.Point(0, 0);
            this.flpanelListMess.Name = "flpanelListMess";
            this.flpanelListMess.Size = new System.Drawing.Size(1211, 544);
            this.flpanelListMess.TabIndex = 1;
            // 
            // FormShowListNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1211, 544);
            this.Controls.Add(this.flpanelListMess);
            this.Name = "FormShowListNotification";
            this.Text = "Thông Báo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpanelListMess;
    }
}