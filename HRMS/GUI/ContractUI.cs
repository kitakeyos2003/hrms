using HRMS.BUS.Helper;
using HRMS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HRMS.GUI
{
    public partial class ContractUI : Form, IPage
    {
        private Panel panel; 
        public DataGridViewRow SelectedRow { get; private set; }
        private int page = 1, limit = ApplicationConfig.MAX_PAGE[0];
        List<Department> Departments;
        List<Position> Positions;
        Department department;
        Position position;
        public ContractUI(Panel panel)
        {
            this.panel = panel;
            InitializeComponent();
            this.BackColor = panel.BackColor;
            Init();
            InitPage();
        }

        public void Init()
        {
            foreach (int limit in ApplicationConfig.MAX_PAGE)
            {
                cbLimitPage.Items.Add(limit);
            }
            cbLimitPage.SelectedIndex = 0;
            limit = ApplicationConfig.MAX_PAGE[cbLimitPage.SelectedIndex];

            cbDepartment.Items.Clear();
            Departments = DataManager.GetInstance().Departments;
            cbDepartment.Items.Add("Tất cả");
            if (Departments.Count > 0)
            {
                for (int i = 0; i < Departments.Count; i++)
                {
                    Department department = Departments[i];
                    cbDepartment.Items.Add(department.Name);
                }
            }
            cbDepartment.SelectedIndex = 0;

            cbPosition.Items.Clear();
            Positions = DataManager.GetInstance().Positions;
            cbPosition.Items.Add("Tất cả");
            if (Positions.Count > 0)
            {
                for (int i = 0; i < Positions.Count; i++)
                {
                    Position position = Positions[i];
                    cbPosition.Items.Add(position.Name);
                }
            }
            cbPosition.SelectedIndex = 0;
        }

        public void InitPage()
        {
            lbPage.Text = page.ToString();
            List<Contract> contracts = DataManager.GetInstance().Contracts.FindAll(c => IsMatch(c));
            int maxPage = PageHelper.TotalPages(contracts.Count, limit);
            if (page <= 1)
            {
                prePage.Enabled = false;
            }
            else
            {
                prePage.Enabled = true;
            }
            if (page >= maxPage)
            {
                nextPage.Enabled = false;
            }
            else
            {
                nextPage.Enabled = true;
            }
            int[] array = PageHelper.GetStartIndexAndLength(page, limit, contracts.Count);
            int startIndex = array[0];
            int length = array[1];

            List<Contract> list = contracts.GetRange(startIndex, length);
            FillDataGridView(list);

        }

        private void FillDataGridView(List<Contract> list)
        {
            listContract.Rows.Clear();
            foreach (Contract contract in list)
            {
                AddContract(contract);
            }
        }

        public string GetContractType(int type)
        {
            if (type == 0)
            {
                return "1 năm";
            } else if (type == 1)
            {
                return "5 năm";
            }
            return "10 năm";
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            AddContractUI addContractUI = new AddContractUI(this);
            addContractUI.ShowDialog();
        }

        private void btnReset_Click(object sender, System.EventArgs e)
        {
            txtKeyword.Texts = string.Empty;
            DataManager.GetInstance().LoadAllContract();
            InitPage();
            Alert alert = new Alert();
            alert.ShowAlert("Làm mới thành công!", Alert.EnumType.SUCCESS);
        }

        private void prePage_Click(object sender, EventArgs e)
        {
            PreviousPage();
        }

        private void nextPage_Click(object sender, EventArgs e)
        {
            NextPage();
        }


        public void PreviousPage()
        {
            page--;
            if (page < 1)
            {
                page = 1;
            }
            InitPage();
        }
        public void NextPage()
        {
            List<Contract> contracts = DataManager.GetInstance().Contracts.FindAll(c => IsMatch(c));
            int maxPage = PageHelper.TotalPages(contracts.Count, limit);
            page++;
            if (page > maxPage)
            {
                page = maxPage;
            }
            InitPage();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (SelectedRow != null)
            {
                try
                {
                    int cID = int.Parse(SelectedRow.Cells[0].Value.ToString());
                    Contract contract = DataManager.GetInstance().Contracts.SingleOrDefault(e2 => e2.ContractID == cID);
                    if (contract != null)
                    {
                        bool r = DataManager.GetInstance().ContractService.Delete(contract.ContractID);
                        if (r)
                        {
                            DataManager.GetInstance().Contracts.Remove(contract);
                            InitPage();
                            SelectedRow = null;
                        }
                    }
                }
                catch
                {
                    Alert alert = new Alert();
                    alert.ShowAlert("Có lỗi xảy ra", Alert.EnumType.ERROR);
                }
            }
        }

        private void listContract_SelectionChanged(object sender, EventArgs e)
        {
            if (listContract.SelectedRows.Count > 0)
            {
                SelectedRow = listContract.SelectedRows[0];
            }
            else
            {
                SelectedRow = null;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (SelectedRow != null)
            {
                int cID = int.Parse(SelectedRow.Cells[0].Value.ToString());
                Contract contract = DataManager.GetInstance().Contracts.SingleOrDefault(em => em.ContractID == cID);
                if (contract != null)
                {
                    UpdateContractUI updateContractUI = new UpdateContractUI(SelectedRow, contract);
                    updateContractUI.ShowDialog();
                }
            }
        }

        private void cbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDepartment.SelectedIndex > 0)
            {
                department = Departments[cbDepartment.SelectedIndex - 1];
            }
            else
            {
                department = null;
            }
            InitPage();
        }

        private void cbPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPosition.SelectedIndex > 0)
            {
                position = Positions[cbPosition.SelectedIndex - 1];
            }
            else
            {
                position = null;
            }
            InitPage();
        }

        public void AddContract(Contract contract)
        {
            if (IsMatch(contract)) {
                if (listContract.Rows.Count < limit)
                {
                    listContract.Rows.Add(contract.ContractID, contract.Employee.FullName, contract.Employee.Position.Name, contract.StartDate.ToString("dd/MM/yyyy"), contract.EndDate.ToString("dd/MM/yyyy"), contract.WorkingTime, contract.BasicSalary, GetContractType(contract.ContractType), contract.Note);
                } else
                {
                    NextPage();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtKeyword.Texts;
            Search(keyword);
        }
        private void Search(string searchText)
        {
            InitPage();
            if (!string.IsNullOrEmpty(searchText))
            {
                listContract.ClearSelection();
                List<DataGridViewRow> list = new List<DataGridViewRow>();
                foreach (DataGridViewRow row in listContract.Rows)
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
                listContract.Rows.Clear();
                foreach (DataGridViewRow row in list)
                {
                    listContract.Rows.Add(row);
                }
            }
        }

        private void cbLimitPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLimitPage.SelectedIndex >= 0)
            {

                limit = ApplicationConfig.MAX_PAGE[cbLimitPage.SelectedIndex];
                InitPage();
            }
        }

        private void txtKeyword__TextChanged(object sender, EventArgs e)
        {
            string keyword = txtKeyword.Texts;
            Search(keyword);
        }

        private bool IsMatch(Contract contract)
        {
            return (department == null || department.Id == contract.Employee.Department.Id) && (position == null || position.Id == contract.Employee.Position.Id);
        }
    }
}
