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


        //Overridden methods
        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;//Standar Title Bar - Snap Window
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MINIMIZE = 0xF020; //Minimize form (Before)
            const int SC_RESTORE = 0xF120; //Restore form (Before)
            const int WM_NCHITTEST = 0x0084;//Win32, Mouse Input Notification: Determine what part of the window corresponds to a point, allows to resize the form.
            const int resizeAreaSize = 10;

            #region Form Resize
            // Resize/WM_NCHITTEST values
            const int HTCLIENT = 1; //Represents the client area of the window
            const int HTLEFT = 10;  //Left border of a window, allows resize horizontally to the left
            const int HTRIGHT = 11; //Right border of a window, allows resize horizontally to the right
            const int HTTOP = 12;   //Upper-horizontal border of a window, allows resize vertically up
            const int HTTOPLEFT = 13;//Upper-left corner of a window border, allows resize diagonally to the left
            const int HTTOPRIGHT = 14;//Upper-right corner of a window border, allows resize diagonally to the right
            const int HTBOTTOM = 15; //Lower-horizontal border of a window, allows resize vertically down
            const int HTBOTTOMLEFT = 16;//Lower-left corner of a window border, allows resize diagonally to the left
            const int HTBOTTOMRIGHT = 17;//Lower-right corner of a window border, allows resize diagonally to the right

            ///<Doc> More Information: https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest </Doc>

            if (m.Msg == WM_NCHITTEST)
            { //If the windows m is WM_NCHITTEST
                base.WndProc(ref m);
                if (this.WindowState == FormWindowState.Normal)//Resize the form if it is in normal state
                {
                    if ((int)m.Result == HTCLIENT)//If the result of the m (mouse pointer) is in the client area of the window
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32()); //Gets screen point coordinates(X and Y coordinate of the pointer)                           
                        Point clientPoint = this.PointToClient(screenPoint); //Computes the location of the screen point into client coordinates                          

                        if (clientPoint.Y <= resizeAreaSize)//If the pointer is at the top of the form (within the resize area- X coordinate)
                        {
                            if (clientPoint.X <= resizeAreaSize) //If the pointer is at the coordinate X=0 or less than the resizing area(X=10) in 
                                m.Result = (IntPtr)HTTOPLEFT; //Resize diagonally to the left
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))//If the pointer is at the coordinate X=11 or less than the width of the form(X=Form.Width-resizeArea)
                                m.Result = (IntPtr)HTTOP; //Resize vertically up
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTTOPRIGHT;
                        }
                        else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) //If the pointer is inside the form at the Y coordinate(discounting the resize area size)
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize horizontally to the left
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > (this.Width - resizeAreaSize))//Resize horizontally to the right
                                m.Result = (IntPtr)HTRIGHT;
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize diagonally to the left
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) //Resize vertically down
                                m.Result = (IntPtr)HTBOTTOM;
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                    }
                }
                return;
            }
            #endregion

            //Remove border and keep snap window
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }

            //Keep form size when it is minimized and restored. Since the form is resized because it takes into account the size of the title bar and borders.
            if (m.Msg == WM_SYSCOMMAND)
            {
                /// <see cref="https://docs.microsoft.com/en-us/windows/win32/menurc/wm-syscommand"/>
                /// Quote:
                /// In WM_SYSCOMMAND messages, the four low - order bits of the wParam parameter 
                /// are used internally by the system.To obtain the correct result when testing 
                /// the value of wParam, an application must combine the value 0xFFF0 with the 
                /// wParam value by using the bitwise AND operator.
                int wParam = (m.WParam.ToInt32() & 0xFFF0);

                if (wParam == SC_MINIMIZE)  //Before
                    formSize = this.ClientSize;
                if (wParam == SC_RESTORE)// Restored form(Before)
                    this.Size = formSize;
            }
            base.WndProc(ref m);
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
                    tab.Init();
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
