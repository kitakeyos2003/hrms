using System.Windows.Forms;

namespace HRMS.GUI
{
    public partial class SalaryCalculatorUI : Form
    {
        private Panel panel;
        public SalaryCalculatorUI(Panel panel)
        {
            this.panel = panel;
            InitializeComponent();
            this.BackColor = panel.BackColor;
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            AddSalaryUI addSalaryUI = new AddSalaryUI(this);
            addSalaryUI.ShowDialog();
        }
    }
}
