using System.Windows.Forms;

namespace HRMS.GUI
{
    public partial class EvaluateUI : Form
    {
        private Panel panel;
        public EvaluateUI(Panel panel)
        {
            this.panel = panel;
            InitializeComponent();
            this.BackColor = panel.BackColor;
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            AddEvaluateUI addEvaluateUI = new AddEvaluateUI(this);
            addEvaluateUI.ShowDialog();
        }
    }
}
