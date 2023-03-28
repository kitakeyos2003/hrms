using System.Windows.Forms;

namespace HRMS.GUI
{
    public partial class SalaryCalculatorUI : Form, ITab
    {
        private Panel panel;
        public SalaryCalculatorUI(Panel panel)
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
