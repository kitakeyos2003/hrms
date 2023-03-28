using System.Windows.Forms;

namespace HRMS.GUI
{
    public partial class PerformanceReviewUI : Form, ITab
    {
        private Panel panel;
        public PerformanceReviewUI(Panel panel)
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
