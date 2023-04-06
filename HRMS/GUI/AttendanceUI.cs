using System.Windows.Forms;

namespace HRMS.GUI
{
    public partial class AttendanceUI : Form
    {
        private Panel panel;
        public AttendanceUI(Panel panel)
        {
            this.panel = panel;
            InitializeComponent();
            this.BackColor = panel.BackColor;
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            AddAttendanceUI addAttendanceUI = new AddAttendanceUI(this);
            addAttendanceUI.ShowDialog();
        }

        private void btnFilter_Click(object sender, System.EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, System.EventArgs e)
        {

        }
    }
}
