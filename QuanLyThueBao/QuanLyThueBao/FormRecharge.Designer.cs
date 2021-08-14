namespace QuanLyThueBao
{
    partial class FormRecharge
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
            this.txtCard = new System.Windows.Forms.TextBox();
            this.lbRecharge = new System.Windows.Forms.Label();
            this.btnA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(499, 267);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 2);
            this.panel1.TabIndex = 43;
            // 
            // txtCard
            // 
            this.txtCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtCard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCard.ForeColor = System.Drawing.Color.White;
            this.txtCard.Location = new System.Drawing.Point(501, 240);
            this.txtCard.Name = "txtCard";
            this.txtCard.Size = new System.Drawing.Size(400, 28);
            this.txtCard.TabIndex = 40;
            // 
            // lbRecharge
            // 
            this.lbRecharge.AutoSize = true;
            this.lbRecharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecharge.ForeColor = System.Drawing.Color.White;
            this.lbRecharge.Location = new System.Drawing.Point(354, 249);
            this.lbRecharge.Name = "lbRecharge";
            this.lbRecharge.Size = new System.Drawing.Size(141, 20);
            this.lbRecharge.TabIndex = 36;
            this.lbRecharge.Text = "Nhập Mã Thẻ Nạp:";
            // 
            // btnA
            // 
            this.btnA.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnA.FlatAppearance.BorderSize = 0;
            this.btnA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA.ForeColor = System.Drawing.Color.White;
            this.btnA.Location = new System.Drawing.Point(574, 317);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(133, 40);
            this.btnA.TabIndex = 35;
            this.btnA.Text = "Xác Nhận";
            this.btnA.UseVisualStyleBackColor = false;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // FormRecharge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1096, 569);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtCard);
            this.Controls.Add(this.lbRecharge);
            this.Controls.Add(this.btnA);
            this.Name = "FormRecharge";
            this.Text = "Nạp Tiền";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCard;
        private System.Windows.Forms.Label lbRecharge;
        private System.Windows.Forms.Button btnA;
    }
}