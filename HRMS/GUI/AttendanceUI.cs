﻿using System.Windows.Forms;

namespace HRMS.GUI
{
    public partial class AttendanceUI : Form
    {
        private Panel panel;
        public AttendanceUI(Panel panel)
        {
            this.panel = panel;
            InitializeComponent();
            this.BackColor = panel.BackColor;
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            listAttendance.Rows.Add();
        }

        private void btnFilter_Click(object sender, System.EventArgs e)
        {

        }
    }
}
