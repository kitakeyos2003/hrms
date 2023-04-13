using System;
using System.Collections.Generic;
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtKeyword.Texts;
            Search(keyword);
        }
        private void Search(string searchText)
        {
            if (!string.IsNullOrEmpty(searchText))
            {
                listSalary.ClearSelection();
                List<DataGridViewRow> list = new List<DataGridViewRow>();
                foreach (DataGridViewRow row in listSalary.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null && cell.Value.ToString().ToLower().Contains(searchText.ToLower()))
                        {
                            list.Add(row);
                            break;
                        }
                    }
                }
                listSalary.Rows.Clear();
                foreach (DataGridViewRow row in list)
                {
                    listSalary.Rows.Add(row);
                }
            }
            else
            {
                InitPage();
            }
        }

        private void InitPage()
        {
           
        }
    }
}
