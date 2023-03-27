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
    public partial class EmployeeUI : Form
    {
        private Panel panel;
        DataGridViewRow selectRow;
        public EmployeeUI(Panel panel)
        {
            this.panel = panel;
            InitializeComponent();
            this.BackColor = panel.BackColor;
            listEmployee.Rows.Add("1111", "Nguyen Van A", "24/02/2003", "Nam", "0344505191", "Bắc Ninh", "Marketing", "Trưởng phòng");
        }

        private void listEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (listEmployee.SelectedRows.Count > 0)
            {
                Alert alert = new Alert();
                alert.ShowAlert("select", Alert.EnumType.INFO);
                selectRow = listEmployee.SelectedRows[0];
            }
        }

        private void txtEdit_Click(object sender, EventArgs e)
        {

        }

        private void txtDelete_Click(object sender, EventArgs e)
        {
            if (selectRow != null)
            {
                Alert alert = new Alert();
                alert.ShowAlert("delete", Alert.EnumType.SUCCESS);
                listEmployee.Rows.Remove(selectRow);
            }
        }
    }
}
