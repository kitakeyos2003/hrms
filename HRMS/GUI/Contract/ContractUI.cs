using System.Windows.Forms;

namespace HRMS.GUI
{
    public partial class ContractUI : Form, ITab
    {
        private Panel panel;
        public ContractUI(Panel panel)
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
