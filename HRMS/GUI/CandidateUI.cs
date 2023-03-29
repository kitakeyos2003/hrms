using System.Windows.Forms;

namespace HRMS.GUI
{
    public partial class CandidateUI : Form, ITab
    {
        private Panel panel;
        public CandidateUI(Panel panel)
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

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            listCandidate.Rows.Add();
        }
    }
}
