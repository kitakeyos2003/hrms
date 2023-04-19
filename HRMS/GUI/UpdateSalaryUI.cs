using HRMS.DAL;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HRMS.GUI
{
    public partial class UpdateSalaryUI : Form
    {
        DataGridViewRow Row;
        Salary Salary;

        public UpdateSalaryUI(DataGridViewRow row, Salary salary)
        {
            this.Salary = salary;
            this.Row = row;
            InitializeComponent();
            this.Padding = new Padding(2);
            this.BackColor = Color.FromArgb(98, 102, 244);
            StartPosition = FormStartPosition.CenterScreen;
            Init();
        }

        public void Init()
        {
            dpPaymentDate.Value = DateTime.Now;
            txtSalaryID.Texts = Salary.SalaryID.ToString();
            cbPaymentMethod.SelectedIndex = Salary.PaymentMethod;
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
            Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DateTime paymentDate = dpPaymentDate.Value;
            int paymentMethod = cbPaymentMethod.SelectedIndex;
            Salary.PaymentMethod = paymentMethod;
            Salary.PaymentDate = paymentDate;
            bool r = DataManager.GetInstance().SalaryService.Update(Salary);
            if (r)
            {
                UpdateRow();
                Close();
                Alert alert = new Alert();
                alert.ShowAlert("Cập nhật thành công!", Alert.EnumType.SUCCESS);
            }
        }
        private void UpdateRow()
        {
            Row.Cells["PaymentDate"].Value = Salary.PaymentDate;
            Row.Cells["PaymentMethod"].Value = Salary.PaymentMethod;
        }
    }
}
