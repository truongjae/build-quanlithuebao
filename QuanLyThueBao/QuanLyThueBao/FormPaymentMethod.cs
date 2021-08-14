using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyThueBao
{
    public partial class FormPaymentMethod : Form
    {
        private string myPhone;
        private Notification notification;
        public FormPaymentMethod(string myPhone)
        {
            InitializeComponent();
            this.myPhone = myPhone;
            notification = new Notification(this.myPhone);
        }

        public void Alert(string msg, FormAlert.enmType type)
        {
            FormAlert frm = new FormAlert();
            frm.showAlert(msg, type);
        }
        private void btnBocBatHo_Click(object sender, EventArgs e)
        {
            FormBocBatHo formBocBatHo = new FormBocBatHo();
            formBocBatHo.ShowDialog();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void success()
        {
            notification.updateBill(notification);
            this.Alert("Thanh Toán Thành Công", FormAlert.enmType.Success);
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            success();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            success();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            success();
        }
    }
}
