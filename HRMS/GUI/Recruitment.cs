using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMS.GUI
{
    public partial class Recruitment : Form
    {
        private Panel panel;
        public Recruitment(Panel panel)
        {
            this.panel = panel;
            InitializeComponent();
            this.Width = panel.Width;
            this.Height = panel.Height;
            this.BackColor = panel.BackColor;
        }
    }
}
