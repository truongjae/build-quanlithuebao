using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLyThueBao
{
    public partial class FormUsers : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        private string username;
        public FormUsers(string username)
        {
            InitializeComponent();
            this.username = username;
            random = new Random();
            this.BackColor = Color.White;
            btnCloseChildForm.Visible = false;
            hideAllMenu();
            titleUser.Text = "TK: "+this.username;
            if (checkTypeAccount(this.username) == false) // check thue bao tra truoc
            {
                btnCard.Hide();
                btnHistoryRecharge.Hide();
                panelMenuReport.Height = 101;
            }
        }

        public bool checkTypeAccount(string username)
        {
            Connection connection = new Connection();
            DataTable DT = connection.getDataTable("select * from phone where phone_number=N'" + username + "' and type=N'Trả Trước'");
            return DT.Rows.Count > 0;
        }
        public void Alert(string msg, FormAlert.enmType type)
        {
            FormAlert frm = new FormAlert();
            frm.showAlert(msg, type);
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnCloseChildForm.Visible = true;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = System.Drawing.Color.DodgerBlue;
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            this.BackColor = Color.FromArgb(46, 51, 73);
            try
            {
                if (activeForm != null)
                    activeForm.Close();
                ActivateButton(btnSender);
                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                this.panelDesktop.Controls.Add(childForm);
                this.panelDesktop.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
                labelTitle.Text = childForm.Text;
            }
            catch
            {
                labelTitle.Text = "";
            }

        }
        private void Reset()
        {
            DisableButton();
            labelTitle.Text = "Trang Chủ";
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            btnCloseChildForm.Visible = false;
        }

        private void hideAllMenu()
        {
            panelMenuReport.Visible = false;
            panelMenuOption.Visible = false;
            
        }
        private void hideSubMenu()
        {
            if (panelMenuReport.Visible) panelMenuReport.Visible = false;
            if (panelMenuOption.Visible) panelMenuOption.Visible = false;
        }
        private void showSubMenu(Panel panel)
        {
            if (panel.Visible == false)
            {
                hideSubMenu();
                panel.Visible = true;
            }
            else panel.Visible = false;
            
        }
        private void btnPhone_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormInfoUser(this.username), sender);
            hideAllMenu();
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null) activeForm.Close();
            Reset();
            hideSubMenu();
            this.BackColor = Color.White;
            FormUsers_Load(sender, e);
        }

        private void btnOption_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMenuOption);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMenuReport);
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            bool result = new FormDialog("Bạn Có Muốn Đăng Xuất Không").resultAns();
            if (result)
            {
                Login lg = new Login();
                lg.deleteCookie();
                this.Close();
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
                Application.Exit();
                hideAllMenu();
        }

        private void btnChangePw_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormChangePassLogin(this.username), sender);
            hideAllMenu();
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormShowListService(this.username,1), sender);
            hideAllMenu();
        }

        private void btnServiceReged_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormShowListService(this.username, 0), sender);
            hideAllMenu();
        }

        private void btnCard_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormRecharge(this.username), sender);
            hideAllMenu();
        }

        private void btnHistoryRecharge_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormShowListRecharge(this.username), sender);
            hideAllMenu();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {

        }
        private void btnMess_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new FormShowListMess(this.username), sender);
            btnMess.BackColor = Color.White;
            hideAllMenu();
            SendMess sm = new SendMess(this.username);
            sm.updateMessReaded(sm);
            FormUsers_Load(sender, e);
        }

        private void FormUsers_Load(object sender, EventArgs e)
        {
            lbCall.Visible = false;
            lbMess.Visible = false;
            lbNotification.Visible = false;
            SendMess sm = new SendMess(this.username);
            int countMess = sm.countMessUnread(sm);
            if (countMess > 0)
            {
                lbMess.Visible = true;
                lbMess.Text = countMess.ToString();
            }

            Call call = new Call(this.username);
            int countCallCancel = call.countCallCancel(call);
            if (countCallCancel > 0)
            {
                lbCall.Visible = true;
                lbCall.Text = countCallCancel.ToString();
            }
            Notification notification = new Notification(this.username);
            if (notification.checkBill(notification))
            {
                lbNotification.Visible = true;
                lbNotification.Text = "1";
            }
            topCall();
            topMess();
        }

        private void btnCall_Click_1(object sender, EventArgs e)
        {
            //FormSmartphone fSmartphone = new FormSmartphone(this.username);
            //fSmartphone.ShowDialog();
            OpenChildForm(new FormShowListCall(this.username), sender);
            btnCall.BackColor = Color.White;
            hideAllMenu();
            Call call = new Call(this.username);
            call.updateCallCancel(call);
            FormUsers_Load(sender, e);
        }

        private void btnNotification_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new FormShowListNotification(this.username), sender);
            hideAllMenu();
            btnNotification.BackColor = Color.White;
            FormUsers_Load(sender, e);
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
                //OpenChildForm(new FormShowListAllBill(this.username), sender);
                //hideAllMenu();
            FormShowListAllBill formShowListAllBill = new FormShowListAllBill(this.username);
            formShowListAllBill.ShowDialog();
        }
        public void topCall()
        {
            chartCall.Series.Clear();
            chartCall.Titles.Clear();
            Title title = new Title();
            title.Font = new Font("Arial", 14, FontStyle.Regular);
            title.ForeColor = Color.White;
            title.Text = "Biểu Đồ Báo Cáo Lượng Phút Gọi Theo Tháng";
            chartCall.Titles.Add(title);
            chartCall.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Black;
            chartCall.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
            chartCall.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.Blue;
            chartCall.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;
            chartCall.ChartAreas[0].RecalculateAxesScale();
            Connection connection = new Connection();
            string sql;
            DataTable DT;
            for (int i = 1; i <= 12; i++)
            {
                sql = "select sum(minutes) as sum_minutes from called where phone_out = '" + this.username + "' and status = '1' and MONTH(time_start) = " + i;
                DT = connection.getDataTable(sql);
                long sumMinutes = 0;
                if (DT.Rows.Count > 0)
                {
                    if (DT.Rows[0]["sum_minutes"].ToString().Equals(string.Empty) == false)
                        sumMinutes = Int64.Parse(DT.Rows[0]["sum_minutes"].ToString());
                }
                Series series = chartCall.Series.Add("Tháng "+i);
                series.Points.Add(sumMinutes);
            }

        }
        public void topMess()
        {
            chartMess.Series.Clear();
            chartMess.Titles.Clear();
            Title title = new Title();
            title.Font = new Font("Arial", 12, FontStyle.Regular);
            title.ForeColor = Color.Black;
            title.Text = "Biểu Đồ Báo Cáo Số Tin Nhắn Theo Tháng";
            chartMess.Titles.Add(title);
            Series series = this.chartMess.Series.Add("Tháng");
            series.ChartType = SeriesChartType.Spline;
            Connection connection = new Connection();
            string sql;
            DataTable DT;
            for (int i = 1; i <= 12; i++)
            {
                sql = "select count(*) as count_mess from sended where phone_out = '" + this.username + "' and MONTH(time_send) = " + i;
                DT = connection.getDataTable(sql);
                long countMess = 0;
                if (DT.Rows.Count > 0)
                {
                    if (DT.Rows[0]["count_mess"].ToString().Equals(string.Empty) == false)
                        countMess = Int64.Parse(DT.Rows[0]["count_mess"].ToString());
                }
                series.Points.AddXY("Tháng " + i.ToString(), countMess);
            }
        }

        private void timeNow_Tick(object sender, EventArgs e)
        {
            lbTimeNow.Text = DateTime.Now.ToString("HH:mm:ss");
            string dayOfWeek = "";
            switch ((int)DateTime.Now.DayOfWeek)
            {
                case 0:
                    dayOfWeek = "Chủ Nhật";
                    break;
                case 1:
                    dayOfWeek = "Thứ Hai";
                    break;
                case 2:
                    dayOfWeek = "Thứ Ba";
                    break;
                case 3:
                    dayOfWeek = "Thứ Tư";
                    break;
                case 4:
                    dayOfWeek = "Thứ Năm";
                    break;
                case 5:
                    dayOfWeek = "Thứ Sáu";
                    break;
                case 6:
                    dayOfWeek = "Thứ Bảy";
                    break;
            }
            lbDateNow.Text = dayOfWeek + ", Ngày " + DateTime.Now.Day + " Tháng " + DateTime.Now.Month + " Năm " + DateTime.Now.Year;
        }


    }
}
