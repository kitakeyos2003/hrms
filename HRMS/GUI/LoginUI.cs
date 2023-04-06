using HRMS.DAL;
using RestSharp;
using System;
using System.Drawing;
using System.Net;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HRMS.GUI
{
    public partial class LoginUI : Form
    {
        private int borderSize = 2;
        UserService service;

        public LoginUI()
        {
            service = new UserService();
            InitializeComponent();
            this.Padding = new Padding(borderSize);
            this.BackColor = Color.FromArgb(98, 102, 244);
            StartPosition = FormStartPosition.CenterScreen;
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;

            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                // Xóa title bar
                m.Result = IntPtr.Zero;
            }
            else
            {
                base.WndProc(ref m);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                btnLogin.Enabled = false;
                Alert alert = new Alert();
                string username = txtUsername.Texts;
                string password = txtPassword.Texts;
                if (username == null || username.Equals(""))
                {
                    alert.ShowAlert("Tài khoản không được bỏ trống!", Alert.EnumType.WARNING);
                    return;
                }
                if (password == null || password.Equals(""))
                {
                    alert.ShowAlert("Mật khẩu không được bỏ trống!", Alert.EnumType.WARNING);
                    return;
                }
                RestResponse<ApiResponse<Token>> res = service.Validate(username, password);
                if (res.StatusCode == HttpStatusCode.OK)
                {
                    ApiResponse<Token> data = res.Data;
                    if (data.Success)
                    {
                        ApplicationConfig.Token = data.Data;
                        Hide();
                        alert.ShowAlert(data.Message, Alert.EnumType.SUCCESS);
                        DataManager.GetInstance().LoadAll();
                        Dashboard dashboard = new Dashboard(this);
                        dashboard.Show();
                        dashboard.SetDefaultTab();
                    }
                    else
                    {
                        alert.ShowAlert(data.Message, Alert.EnumType.WARNING);
                    }
                } else
                {
                    alert.ShowAlert("Có lỗi xảy ra!", Alert.EnumType.ERROR);
                }
            }
            finally
            {
                btnLogin.Enabled = true;
            }
        }

    }
}
