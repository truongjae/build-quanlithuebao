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
using System.Diagnostics;
namespace QuanLyThueBao
{
    public partial class FormManager : Form
    {
      
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        private string username;
        public FormManager(string username)
        {
            InitializeComponent();
            this.username = username;
           //this.FormBorderStyle = FormBorderStyle.FixedSingle;
            random = new Random();
            btnCloseChildForm.Visible = false;
            hideAllMenu();
            //panelMenuReport.Hide();
            //this.Text = string.Empty;
            //this.ControlBox = false;
        }
        public void loadSpeedTest()
        {
            try
            {
                var watch = new Stopwatch();
                byte[] data;
                using (var client = new System.Net.WebClient())
                {
                    watch.Start();
                    data = client.DownloadData("http://dl.google.com/googletalk/googletalk-setup.exe?t=" + DateTime.Now.Ticks);
                    watch.Stop();
                }
                var speed = data.LongLength / watch.Elapsed.TotalSeconds;
                lbDownload.Text = watch.Elapsed.ToString();
                lbFileSize.Text = data.Length.ToString("N0");
                lbSpeed.Text = speed.ToString("N0") + "bps";
            }
            catch { }
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
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
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

        private void FormManager_Load(object sender, EventArgs e)
        {
           this.Alert("Xin Chào, Bạn Đang Đăng Nhập\nTài Khoản " + this.username, FormAlert.enmType.Success);
            // xep hang khach hang theo thang
           Statistical statistical = new Statistical();
           statistical.showTop(tableTop);
           lbTop.Text = "Top 5 Khách Hàng Tiềm Năng Tháng " + DateTime.Now.Month.ToString();
           topNetwork();
           topPayment();
           infoAll();
        }
        private void btnPhone_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormPhone(), sender);
            hideAllMenu();
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null) activeForm.Close();
            Reset();
            hideSubMenu();
            ///
            Statistical statistical = new Statistical();
            statistical.showTop(tableTop);
            lbTop.Text = "Top 5 Khách Hàng Tiềm Năng Tháng " + DateTime.Now.Month.ToString();
            topNetwork();
            topPayment();
            infoAll();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormCustomer(), sender);
            hideAllMenu();
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormService(), sender);
            hideAllMenu();
        }

        private void btnNetwork_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormNetwork(), sender);
            hideAllMenu();
        }

        private void btnRegion_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormRegion(), sender);
            hideAllMenu();
        }

        private void btnCard_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormCard(), sender);
            hideAllMenu();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
            hideAllMenu();
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void btnReport_Click(object sender, EventArgs e)
        {
            //OpenChildForm(null, sender);
            showSubMenu(panelMenuReport);
            panelMenu.ScrollControlIntoView(btnOption);
        }

        private void btnOption_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMenuOption);
            panelMenu.ScrollControlIntoView(btnLogout);
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

        private void btnAccount_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormAccount(this.username), sender);
            hideAllMenu();
        }

        private void btnChangePw_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormChangePassLogin(this.username), sender);
            hideAllMenu();
        }

        private void btnReportBill_Click(object sender, EventArgs e)
        {
                //OpenChildForm(new FormReportBill(), sender);
                //hideAllMenu();
                FormReportBill formReportBill = new FormReportBill();
                this.Hide();
                formReportBill.ShowDialog();
                this.Show();
        }

        private void btnReportAllBill_Click(object sender, EventArgs e)
        {
               // OpenChildForm(new FormShowListAllBill(), sender);
               // hideAllMenu();
            FormShowListAllBill formShowListAllBill = new FormShowListAllBill();
            formShowListAllBill.ShowDialog();
        }
        // thong ke xep hang nha mang
        public void topNetwork()
        {
            chartNetwork.Series.Clear();
            chartNetwork.Titles.Clear();
            Title title = new Title();
            title.Font = new Font("Arial", 14, FontStyle.Regular);
            title.ForeColor = Color.White;
            title.Text = "Biểu Đồ Báo Cáo Số Lượng Thuê Bao Theo Nhà Mạng";
            chartNetwork.Titles.Add(title);
            chartNetwork.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Black;
            chartNetwork.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
            chartNetwork.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.Blue;
            chartNetwork.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;
            chartNetwork.ChartAreas[0].RecalculateAxesScale();
            //
            Connection connection = new Connection();
            string sql = "select nw.id_network,count(nw.id_network) as count_phone from network nw join phone p on p.id_network = nw.id_network group by (nw.id_network)";
            DataTable DT = connection.getDataTable(sql);
            List<TopNetwork> listNetwork = new List<TopNetwork>();
            foreach (DataRow row in DT.Rows)
            {
                string network = row["id_network"].ToString();
                long count =Int64.Parse(row["count_phone"].ToString());
                listNetwork.Add(new TopNetwork(network, count));
            }
            
            foreach (TopNetwork nw in listNetwork)
            {
                Series series =chartNetwork.Series.Add(nw.Network);
                series.Points.Add(nw.Count);
            }
           
        }
        class TopNetwork
        {
            private string network;
            private long count;
            public string Network
            {
                get { return network; }
                set { network = value; }
            }
            public long Count
            {
                get { return count; }
                set { count = value; }
            }
            public TopNetwork() { }
            public TopNetwork(string network, long count)
            {
                this.network = network;
                this.count = count;
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
        // thong tin doanh thu
        private void topPayment()
        {
            chartPayment.Series.Clear();
            chartPayment.Titles.Clear();
            Title title = new Title();
            title.Font = new Font("Arial", 12, FontStyle.Regular);
            title.ForeColor = Color.Black;
            title.Text = "Doanh Thu Theo Tháng";
            chartPayment.Titles.Add(title);
            Series series = this.chartPayment.Series.Add("Tháng");
            series.ChartType = SeriesChartType.Spline;
            Connection connection = new Connection();
            string sql;
            DataTable DT;
            for (int i = 1; i <= 12; i++)
            {
                sql = "select sum(payment) as sum_payment from spending where MONTH(date) = " + i;
                DT = connection.getDataTable(sql);
                long pay = 0;
                if (DT.Rows.Count > 0)
                {
                    if(DT.Rows[0]["sum_payment"].ToString().Equals(string.Empty) == false)
                        pay = Int64.Parse(DT.Rows[0]["sum_payment"].ToString());
                }
                series.Points.AddXY("Tháng " + i.ToString(), pay);
            }
        }
        // thong tin tong hop
        public void infoAll()
        {
            Connection connection = new Connection();
            string sql = "select count(phone_number) as count_phone from phone";
            DataTable DT = connection.getDataTable(sql);
            if (DT.Rows.Count > 0)
                lbCountPhone.Text = "Tổng Số Thuê Bao: " + DT.Rows[0]["count_phone"].ToString();
            else
                lbCountPhone.Text = "Tổng Số Thuê Bao: 0";
            //
             sql = "select count(id_network) as count_network from network";
             DT = connection.getDataTable(sql);
            if (DT.Rows.Count > 0)
                lbCountNetwork.Text = "Tổng Số Nhà Mạng: " + DT.Rows[0]["count_network"].ToString();
            else
                lbCountNetwork.Text = "Tổng Số Nhà Mạng: 0";
            //
             sql = "select count(id_card) as count_customer from customer";
             DT = connection.getDataTable(sql);
            if (DT.Rows.Count > 0)
                lbCountCustomer.Text = "Tổng Số Khách Hàng: " + DT.Rows[0]["count_customer"].ToString();
            else
                lbCountCustomer.Text = "Tổng Số Khách Hàng: 0";
            //
             sql = "select count(id_service) as count_service from service";
             DT = connection.getDataTable(sql);
            if (DT.Rows.Count > 0)
                lbCountService.Text = "Tổng Số Dịch Vụ: " + DT.Rows[0]["count_service"].ToString();
            else
                lbCountService.Text = "Tổng Số Dịch Vụ: 0";
            sql = "select count(id_service) as count_service from service";
             DT = connection.getDataTable(sql);
            if (DT.Rows.Count > 0)
                lbCountService.Text = "Tổng Số Dịch Vụ: " + DT.Rows[0]["count_service"].ToString();
            else
                lbCountService.Text = "Tổng Số Dịch Vụ: 0";
            //
            sql = "select sum(payment) as sum_payment from spending where MONTH(date) = " + DateTime.Now.Month;
            DT = connection.getDataTable(sql);

            if (DT.Rows.Count > 0)
            {
                if (DT.Rows[0]["sum_payment"].ToString().Equals(string.Empty) == false)
                    lbSumPayment.Text = "Tổng Doanh Thu Tháng " + DateTime.Now.Month + ":  " + DT.Rows[0]["sum_payment"].ToString() + " VNĐ";
                else
                    lbSumPayment.Text = "Tổng Doanh Thu Tháng " + DateTime.Now.Month + ":  0 VNĐ";
            }
            
        }

        private void timeSpeedTest_Tick(object sender, EventArgs e)
        {
            loadSpeedTest();
        }
    }
}
