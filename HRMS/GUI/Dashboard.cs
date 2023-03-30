using FontAwesome.Sharp;
using HRMS.GUI;
using System;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HRMS
{
    public partial class Dashboard : Form
    {
        private int borderSize = 2;
        private Size formSize;
        private LoginUI login;
        private HomeUI home;
        private EmployeeUI employee;
        private CandidateUI candidate;
        private EvaluateUI evaluate;
        private AttendanceUI attendance;
        private SalaryCalculatorUI salaryCalculator;
        private AboutMeUI aboutMe;
        private ContractUI contract;
        IconButton selected;
        public Dashboard(LoginUI login)
        {
            this.login = login;
            InitializeComponent();
            Init();
            CollapseMenu();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Init()
        {
            this.Padding = new Padding(borderSize);
            this.BackColor = Color.FromArgb(98, 102, 244);
            home = new HomeUI(panelDesktop);
            employee = new EmployeeUI(panelDesktop);
            candidate = new CandidateUI(panelDesktop);
            evaluate = new EvaluateUI(panelDesktop);
            attendance = new AttendanceUI(panelDesktop);
            salaryCalculator = new SalaryCalculatorUI(panelDesktop);
            aboutMe = new AboutMeUI(panelDesktop);
            contract = new ContractUI(panelDesktop);
            AddControl(home);
            AddControl(employee);
            AddControl(candidate);
            AddControl(evaluate);
            AddControl(attendance);
            AddControl(salaryCalculator);
            AddControl(aboutMe);
            AddControl(contract);
        }

        private void AddControl(Form control)
        {
            control.TopLevel = false;
            control.AutoScroll = true;
            panelDesktop.Controls.Add(control);
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

        private void Form1_Load(object sender, EventArgs e)
        {
            formSize = this.ClientSize;
        }

        private void CollapseMenu()
        {
            if (this.panelMenu.Width >= 200) //Collapse menu
            {
                panelMenu.Width = 60;
                logo.Visible = false;
                btnMenu.Dock = DockStyle.Top;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
            }
            else
            { //Expand menu
                panelMenu.Width = 200;
                logo.Visible = true;
                btnMenu.Dock = DockStyle.None;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "   " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            AdjustForm();
        }

        private void AdjustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized: //Maximized form (After)
                    this.Padding = new Padding(8, 8, 8, 0);
                    break;
                case FormWindowState.Normal: //Restored form (After)
                    if (this.Padding.Top != borderSize)
                        this.Padding = new Padding(borderSize);
                    break;
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            formSize = this.ClientSize;
            this.WindowState = FormWindowState.Minimized;
        }

        /*private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                formSize = this.ClientSize;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.Size = formSize;
            }
        }*/

        private void btnClose_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.AccessToken = null;
            Application.RefreshToken = null;
            Hide();
            login.Show();
        }

        private void OpenNewTabAndCloseCurrentTab(object sender, EventArgs e)
        {
            if (selected != null)
            {
                HideTab(selected);
            }
            OpenTab((IconButton)sender);
        }

        private void HideTab(IconButton selected)
        {
            ITab tab = GetTabSelected(selected);
            if (tab != null)
            {
                selected.BackColor = Color.FromArgb(0, 145, 255);
                selected.Enabled = true;
                tab.Hide();
            }
        }

        private void OpenTab(IconButton selected)
        {
            Form form = (Form)GetTabSelected(selected);
            if (form != null)
            {
                this.Text = form.Text;
                this.lbTitle.Text = form.Tag.ToString();
                this.selected = selected;
                selected.BackColor = Color.FromArgb(0, 110, 220);
                selected.Enabled = false;
                SetLocationForFormChildren(form, panelDesktop);
                if (form is ITab tab)
                {
                    tab.Open();
                }
            }
        }

        private ITab GetTabSelected(IconButton selected)
        {
            if (selected != null)
            {
                if (selected == btnHome)
                {
                    return home;
                }
                else if (selected == btnEmployee)
                {
                    return employee;
                }
                else if (selected == btnCandidate)
                {
                    return candidate;
                }
                else if (selected == btnEvaluate)
                {
                    return evaluate;
                }
                else if (selected == btnAttendance)
                {
                    return attendance;
                }
                else if (selected == btnSalaryCalculator)
                {
                    return salaryCalculator;
                }
                else if (selected == btnAboutMe)
                {
                    return aboutMe;
                }
                else if (selected == btnContract)
                {
                    return contract;
                }
            }
            return null;
        }
        public void SetDefaultTab()
        {
            OpenTab(btnHome);
        }

        private void PanelResize(object sender, EventArgs e)
        {
            Form form = (Form)GetTabSelected(selected);
            if (form != null)
            {
                SetLocationForFormChildren(form, panelDesktop);
            }
        }

        public void SetLocationForFormChildren(Form children, Panel panel)
        {
            int x = panel.Width / 2 - children.Width / 2;
            int y = 0;
            if (x < 0)
            {
                x = 0;
            }
            children.Location = new Point(x, y);
        }
    }




}
