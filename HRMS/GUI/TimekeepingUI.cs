using System.Windows.Forms;

namespace HRMS.GUI
{
    public partial class TimekeepingUI : Form, ITab
    {
        private Panel panel;
        public TimekeepingUI(Panel panel)
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
