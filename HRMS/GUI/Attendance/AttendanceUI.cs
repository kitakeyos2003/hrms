using System.Windows.Forms;

namespace HRMS.GUI
{
    public partial class AttendanceUI : Form, ITab
    {
        private Panel panel;
        public AttendanceUI(Panel panel)
        {
            this.panel = panel;
            InitializeComponent();
            this.BackColor = panel.BackColor;
        }

        public void Init()
        {
            
        }

        public void Open()
        {
            Show();
        }
    }
}
