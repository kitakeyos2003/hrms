using HRMS.DAL;
using HRMS.DAL.Models;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HRMS.GUI
{
    public partial class ContractUI : Form
    {
        private Panel panel;
        public ContractUI(Panel panel)
        {
            this.panel = panel;
            InitializeComponent();
            this.BackColor = panel.BackColor;
            InitDataGridView();
        }

        public void InitDataGridView()
        {
            List<Contract> contracts = DataManager.GetInstance().Contracts;
            FillDataGridView(contracts);

        }

        private void FillDataGridView(List<Contract> contracts)
        {
            listContract.Rows.Clear();
            foreach (Contract contract in contracts)
            {
                listContract.Rows.Add(contract.ContractID, contract.Employee.FullName, contract.Employee.Position.Name, contract.StartDate.ToString("dd/MM/yyyy"), contract.EndDate.ToString("dd/MM/yyyy"), contract.WorkingTime, contract.BasicSalary, GetContractType(contract.ContractType), contract.Note);
            }
        }

        public string GetContractType(int type)
        {
            if (type == 0)
            {
                return "1 năm";
            }
            return "Vô thời hạn";
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            listContract.Rows.Add();
        }
    }
}
