using System.Windows.Forms;

namespace HRMS.GUI
{
    public partial class RecruitmentUI : Form, ITab
    {
        private Panel panel;
        public RecruitmentUI(Panel panel)
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
