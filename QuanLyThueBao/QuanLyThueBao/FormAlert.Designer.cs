namespace QuanLyThueBao
{
    partial class FormAlert
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
            this.lbMess = new System.Windows.Forms.Label();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.picType = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picType)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMess
            // 
            this.lbMess.AutoSize = true;
            this.lbMess.ForeColor = System.Drawing.Color.White;
            this.lbMess.Location = new System.Drawing.Point(78, 16);
            this.lbMess.Name = "lbMess";
            this.lbMess.Size = new System.Drawing.Size(47, 20);
            this.lbMess.TabIndex = 0;
            this.lbMess.Text = "mess";
            // 
            // picClose
            // 
            this.picClose.Image = global::QuanLyThueBao.Properties.Resources.close;
            this.picClose.Location = new System.Drawing.Point(419, 19);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(50, 50);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picClose.TabIndex = 1;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // picType
            // 
            this.picType.Image = global::QuanLyThueBao.Properties.Resources.success;
            this.picType.Location = new System.Drawing.Point(12, 14);
            this.picType.Name = "picType";
            this.picType.Size = new System.Drawing.Size(60, 60);
            this.picType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picType.TabIndex = 2;
            this.picType.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormAlert
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(485, 88);
            this.Controls.Add(this.picType);
            this.Controls.Add(this.picClose);
            this.Controls.Add(this.lbMess);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormAlert";
            this.Text = "FormAlert";
            this.Load += new System.EventHandler(this.FormAlert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMess;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.PictureBox picType;
        private System.Windows.Forms.Timer timer1;
    }
}