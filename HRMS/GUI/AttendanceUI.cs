using HRMS.DAL;
using HRMS.DAL.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HRMS.GUI
{
    public partial class AttendanceUI : Form
    {
        
        private Panel panel;
        public DataGridViewRow SelectedRow { get; private set; }
        private int page = 1, limit = 20;
        public AttendanceUI(Panel panel)
        {
            this.panel = panel;
            InitializeComponent();
            this.BackColor = panel.BackColor;
            InitPage();
        }

        public void InitPage()
        {
            lbPage.Text = page.ToString();
            List<Attendance> attendences = DataManager.GetInstance().Attendances;
            int maxPage = attendences.Count / limit;
            if (attendences.Count % limit != 0)
            {
                maxPage += 1;
            }
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

            int startIndex = (page - 1) * limit;
            int length = limit;
            if (startIndex + length > attendences.Count)
            {
                length = attendences.Count - startIndex;
            }

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

        }

        private void prePage_Click(object sender, EventArgs e)
        {
            PreviousPage();
        }

        private void nextPage_Click(object sender, EventArgs e)
        {
            NextPage();
        }

        internal void AddAttendance(Attendance na)
        {
            if (listAttendance.Rows.Count < limit)
            {
                listAttendance.Rows.Add(na.AttendanceID, na.Employee.FullName, na.Employee.Department.Name, na.Date.ToString("dd/MM/yyyy"), na.ShiftStartTime.ToString("HH:mm:ss"), na.ShiftEndTime.ToString("HH:mm:ss"), na.ActualStartTime.ToString("HH:mm:ss"), na.ActualEndTime.ToString("HH:mm:ss"), na.Overtime, na.AttendanceStatus == 1 ? "Điểm danh thành công" : "Chưa điểm danh", na.AttendanceNote);
            }
            else
            {
                NextPage();
            }
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
            List<Attendance> attendances = DataManager.GetInstance().Attendances;
            int maxPage = attendances.Count / limit;
            if (attendances.Count % limit != 0)
            {
                maxPage += 1;
            }
            page++;
            if (page > maxPage)
            {
                page = maxPage;
            }
            InitPage();
        }
    }
}
