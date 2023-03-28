namespace HRMS.GUI
{
    partial class AttendanceUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.listEmployee = new System.Windows.Forms.DataGridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnEdit = new FontAwesome.Sharp.IconButton();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.btnReset = new FontAwesome.Sharp.IconButton();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.txtKeyword = new RJCodeAdvance.RJControls.RJTextBox();
            this.EmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShiftStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShiftEndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActualStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActualEndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EarlyLeaveTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Overtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttendanceStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttendanceNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listEmployee)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(40, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 500);
            this.panel1.TabIndex = 1;
            this.panel1.Tag = "";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.listEmployee);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 50);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1000, 450);
            this.panel4.TabIndex = 2;
            // 
            // listEmployee
            // 
            this.listEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeID,
            this.FullName,
            this.Department,
            this.Date,
            this.ShiftStartTime,
            this.ShiftEndTime,
            this.ActualStartTime,
            this.ActualEndTime,
            this.LateTime,
            this.EarlyLeaveTime,
            this.Overtime,
            this.AttendanceStatus,
            this.AttendanceNote});
            this.listEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listEmployee.Location = new System.Drawing.Point(20, 20);
            this.listEmployee.Name = "listEmployee";
            this.listEmployee.Size = new System.Drawing.Size(940, 410);
            this.listEmployee.TabIndex = 4;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(20, 430);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(940, 20);
            this.panel7.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 20);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(20, 430);
            this.panel6.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnEdit);
            this.panel5.Controls.Add(this.btnDelete);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(960, 20);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(40, 430);
            this.panel5.TabIndex = 1;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btnEdit.IconColor = System.Drawing.Color.Black;
            this.btnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEdit.IconSize = 30;
            this.btnEdit.Location = new System.Drawing.Point(2, 6);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(30, 30);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDelete.IconColor = System.Drawing.Color.Red;
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelete.IconSize = 30;
            this.btnDelete.Location = new System.Drawing.Point(2, 42);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(30, 30);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1000, 20);
            this.panel3.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.btnReset);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.txtKeyword);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 50);
            this.panel2.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.btnAdd.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdd.IconSize = 30;
            this.btnAdd.Location = new System.Drawing.Point(962, 13);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(30, 30);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            this.btnReset.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.btnReset.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReset.IconSize = 30;
            this.btnReset.Location = new System.Drawing.Point(928, 13);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(30, 30);
            this.btnReset.TabIndex = 3;
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnSearch.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearch.IconSize = 30;
            this.btnSearch.Location = new System.Drawing.Point(892, 13);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(30, 30);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtKeyword
            // 
            this.txtKeyword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKeyword.BackColor = System.Drawing.SystemColors.Window;
            this.txtKeyword.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtKeyword.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.txtKeyword.BorderRadius = 15;
            this.txtKeyword.BorderSize = 1;
            this.txtKeyword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKeyword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtKeyword.Location = new System.Drawing.Point(740, 12);
            this.txtKeyword.Margin = new System.Windows.Forms.Padding(4);
            this.txtKeyword.Multiline = false;
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtKeyword.PasswordChar = false;
            this.txtKeyword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtKeyword.PlaceholderText = "Tìm kiếm";
            this.txtKeyword.Size = new System.Drawing.Size(152, 31);
            this.txtKeyword.TabIndex = 0;
            this.txtKeyword.Texts = "";
            this.txtKeyword.UnderlinedStyle = false;
            // 
            // EmployeeID
            // 
            this.EmployeeID.HeaderText = "Mã nhân viên";
            this.EmployeeID.Name = "EmployeeID";
            // 
            // FullName
            // 
            this.FullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.FullName.HeaderText = "Họ và tên";
            this.FullName.Name = "FullName";
            this.FullName.Width = 79;
            // 
            // Department
            // 
            this.Department.HeaderText = "Phòng ban";
            this.Department.Name = "Department";
            // 
            // Date
            // 
            this.Date.HeaderText = "Ngày làm việc";
            this.Date.Name = "Date";
            // 
            // ShiftStartTime
            // 
            this.ShiftStartTime.HeaderText = "T.gian bắt đầu ca làm việc";
            this.ShiftStartTime.Name = "ShiftStartTime";
            // 
            // ShiftEndTime
            // 
            this.ShiftEndTime.HeaderText = "T.gian k.thúc ca làm việc";
            this.ShiftEndTime.Name = "ShiftEndTime";
            // 
            // ActualStartTime
            // 
            this.ActualStartTime.HeaderText = "T.gian bắt đầu làm việc thực tế";
            this.ActualStartTime.Name = "ActualStartTime";
            // 
            // ActualEndTime
            // 
            this.ActualEndTime.HeaderText = "T.gian k.thúc làm việc thực tế";
            this.ActualEndTime.Name = "ActualEndTime";
            // 
            // LateTime
            // 
            this.LateTime.HeaderText = "T.gian đi làm trễ";
            this.LateTime.Name = "LateTime";
            // 
            // EarlyLeaveTime
            // 
            this.EarlyLeaveTime.HeaderText = "T.gian về sớm";
            this.EarlyLeaveTime.Name = "EarlyLeaveTime";
            // 
            // Overtime
            // 
            this.Overtime.HeaderText = "Giờ làm thêm";
            this.Overtime.Name = "Overtime";
            // 
            // AttendanceStatus
            // 
            this.AttendanceStatus.HeaderText = "Trạng thái điểm danh";
            this.AttendanceStatus.Name = "AttendanceStatus";
            // 
            // AttendanceNote
            // 
            this.AttendanceNote.HeaderText = "Ghi chú";
            this.AttendanceNote.Name = "AttendanceNote";
            // 
            // TimekeepingUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 580);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TimekeepingUI";
            this.Tag = "Quản lý chấm công";
            this.Text = "Chấm công";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listEmployee)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView listEmployee;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconButton btnEdit;
        private FontAwesome.Sharp.IconButton btnDelete;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnAdd;
        private FontAwesome.Sharp.IconButton btnReset;
        private FontAwesome.Sharp.IconButton btnSearch;
        private RJCodeAdvance.RJControls.RJTextBox txtKeyword;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShiftStartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShiftEndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActualStartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActualEndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn LateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn EarlyLeaveTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Overtime;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttendanceStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttendanceNote;
    }
}