using HRMS.BUS.Helper;
using HRMS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HRMS.GUI
{
    public partial class AttendanceUI : Form, IPage
    {
        
        private Panel panel;
        public DataGridViewRow SelectedRow { get; private set; }
        private int page = 1, limit;
        List<Department> Departments;
        List<Position> Positions;
        Department department;
        Position position;

        public AttendanceUI(Panel panel)
        {
            this.panel = panel;
            InitializeComponent();
            this.BackColor = panel.BackColor;
            Init();
            InitPage();
        }

        public void Init()
        {
            foreach (int limit in ApplicationConfig.MAX_PAGE) {
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
            List<Attendance> attendences = DataManager.GetInstance().Attendances.FindAll(attendance => IsMatch(attendance));
            int maxPage = PageHelper.TotalPages(attendences.Count, limit);
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
            int[] array = PageHelper.GetStartIndexAndLength(page, limit, attendences.Count);
            int startIndex = array[0];
            int length = array[1];
            List<Attendance> list = attendences.GetRange(startIndex, length);
            FillDataGridView(list);

        }

        private void FillDataGridView(List<Attendance> list)
        {
            listAttendance.Rows.Clear();
            foreach (Attendance attendance in list)
            {
                AddAttendance(attendance);
            }
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            AddAttendanceUI addAttendanceUI = new AddAttendanceUI(this);
            addAttendanceUI.ShowDialog();
        }

        private void btnFilter_Click(object sender, System.EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, System.EventArgs e)
        {
            if (SelectedRow != null)
            {
                int attendanceID = int.Parse(SelectedRow.Cells[0].Value.ToString());
                Attendance attendance = DataManager.GetInstance().Attendances.SingleOrDefault(em => em.AttendanceID == attendanceID);
                if (attendance != null)
                {
                    UpdateAttendanceUI updateEmployeeUI = new UpdateAttendanceUI(SelectedRow, attendance);
                    updateEmployeeUI.ShowDialog();
                }
            }
        }

        internal void AddAttendance(Attendance attendance)
        {
            if (IsMatch(attendance))
            {
                if (listAttendance.Rows.Count < limit)
                {
                    listAttendance.Rows.Add(attendance.AttendanceID, attendance.Employee.FullName, attendance.Employee.Department.Name, attendance.Date.ToString("dd/MM/yyyy"), attendance.ShiftStartTime.ToString("dd/MM/yyyy HH:mm:ss"), attendance.ShiftEndTime.ToString("dd/MM/yyyy HH:mm:ss"), attendance.ActualStartTime.ToString("dd/MM/yyyy HH:mm:ss"), attendance.ActualEndTime.ToString("dd/MM/yyyy HH:mm:ss"), attendance.Overtime, attendance.AttendanceStatus == 1 ? "Điểm danh thành công" : "Chưa điểm danh", attendance.AttendanceNote);
                }
                else
                {
                    NextPage();
                }
            }
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
            List<Attendance> attendances = DataManager.GetInstance().Attendances.FindAll(attendance => IsMatch(attendance));
            int maxPage = PageHelper.TotalPages(attendances.Count, limit);
            page++;
            if (page > maxPage)
            {
                page = maxPage;
            }
            InitPage();
        }

        private void listAttendance_SelectionChanged(object sender, EventArgs e)
        {
            if (listAttendance.SelectedRows.Count > 0)
            {
                SelectedRow = listAttendance.SelectedRows[0];
            }
            else
            {
                SelectedRow = null;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (SelectedRow != null)
            {
                try
                {
                    int aID = int.Parse(SelectedRow.Cells[0].Value.ToString());
                    Attendance attendance = DataManager.GetInstance().Attendances.SingleOrDefault(e2 => e2.AttendanceID == aID);
                    if (attendance != null)
                    {
                        bool r = DataManager.GetInstance().AttendanceService.Delete(attendance.AttendanceID);
                        if (r)
                        {
                            DataManager.GetInstance().Attendances.Remove(attendance);
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtKeyword.Texts = string.Empty;
            DataManager.GetInstance().LoadAllAttendance();
            InitPage();
            Alert alert = new Alert();
            alert.ShowAlert("Làm mới thành công!", Alert.EnumType.SUCCESS);
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
                listAttendance.ClearSelection();
                List<DataGridViewRow> list = new List<DataGridViewRow>();
                foreach (DataGridViewRow row in listAttendance.Rows)
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
                listAttendance.Rows.Clear();
                foreach (DataGridViewRow row in list)
                {
                    listAttendance.Rows.Add(row);
                }
            }
        }

        private void cbLimitPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if  (cbLimitPage.SelectedIndex >=  0)
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

        private bool IsMatch(Attendance attendance)
        {
            return (department == null || department.Id == attendance.Employee.Department.Id) && (position == null || position.Id == attendance.Employee.Position.Id);
        }

    }
}
