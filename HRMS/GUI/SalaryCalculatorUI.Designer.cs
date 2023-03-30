﻿namespace HRMS.GUI
{
    partial class SalaryCalculatorUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.listSalary = new System.Windows.Forms.DataGridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnEdit = new FontAwesome.Sharp.IconButton();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btnReset = new FontAwesome.Sharp.IconButton();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.txtKeyword = new RJCodeAdvance.RJControls.RJTextBox();
            this.EmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BasicSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Allowance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bonus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrossSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NetSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listSalary)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel8.SuspendLayout();
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
            this.panel4.Controls.Add(this.listSalary);
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
            // listSalary
            // 
            this.listSalary.AllowUserToAddRows = false;
            this.listSalary.AllowUserToDeleteRows = false;
            this.listSalary.BackgroundColor = System.Drawing.Color.White;
            this.listSalary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listSalary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeID,
            this.FullName,
            this.Position,
            this.Department,
            this.BasicSalary,
            this.Allowance,
            this.Bonus,
            this.GrossSalary,
            this.Tax,
            this.NetSalary,
            this.PaymentDate,
            this.PaymentMethod});
            this.listSalary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listSalary.Location = new System.Drawing.Point(20, 20);
            this.listSalary.Name = "listSalary";
            this.listSalary.ReadOnly = true;
            this.listSalary.RowHeadersWidth = 62;
            this.listSalary.Size = new System.Drawing.Size(940, 410);
            this.listSalary.TabIndex = 4;
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
            this.btnEdit.Location = new System.Drawing.Point(2, 5);
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
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 50);
            this.panel2.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnAdd);
            this.panel8.Controls.Add(this.iconButton1);
            this.panel8.Controls.Add(this.btnReset);
            this.panel8.Controls.Add(this.btnSearch);
            this.panel8.Controls.Add(this.txtKeyword);
            this.panel8.Location = new System.Drawing.Point(702, 13);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(295, 34);
            this.panel8.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.btnAdd.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdd.IconSize = 30;
            this.btnAdd.Location = new System.Drawing.Point(262, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(30, 30);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.iconButton1.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.Location = new System.Drawing.Point(1, 3);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(30, 30);
            this.iconButton1.TabIndex = 9;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            this.btnReset.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.btnReset.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReset.IconSize = 30;
            this.btnReset.Location = new System.Drawing.Point(226, 3);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(30, 30);
            this.btnReset.TabIndex = 8;
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnSearch.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearch.IconSize = 30;
            this.btnSearch.Location = new System.Drawing.Point(190, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(30, 30);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtKeyword
            // 
            this.txtKeyword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtKeyword.BackColor = System.Drawing.SystemColors.Window;
            this.txtKeyword.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtKeyword.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.txtKeyword.BorderRadius = 15;
            this.txtKeyword.BorderSize = 1;
            this.txtKeyword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKeyword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtKeyword.Location = new System.Drawing.Point(38, 2);
            this.txtKeyword.Margin = new System.Windows.Forms.Padding(4);
            this.txtKeyword.Multiline = false;
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtKeyword.PasswordChar = false;
            this.txtKeyword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtKeyword.PlaceholderText = "Tìm kiếm";
            this.txtKeyword.Size = new System.Drawing.Size(152, 31);
            this.txtKeyword.TabIndex = 6;
            this.txtKeyword.Texts = "";
            this.txtKeyword.UnderlinedStyle = false;
            // 
            // EmployeeID
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.EmployeeID.DefaultCellStyle = dataGridViewCellStyle1;
            this.EmployeeID.HeaderText = "Mã nhân viên";
            this.EmployeeID.MinimumWidth = 8;
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.ReadOnly = true;
            this.EmployeeID.Width = 150;
            // 
            // FullName
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullName.DefaultCellStyle = dataGridViewCellStyle2;
            this.FullName.HeaderText = "Họ và tên";
            this.FullName.MinimumWidth = 8;
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            this.FullName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FullName.Width = 150;
            // 
            // Position
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Position.DefaultCellStyle = dataGridViewCellStyle3;
            this.Position.HeaderText = "Chức vụ";
            this.Position.MinimumWidth = 8;
            this.Position.Name = "Position";
            this.Position.ReadOnly = true;
            this.Position.Width = 150;
            // 
            // Department
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Department.DefaultCellStyle = dataGridViewCellStyle4;
            this.Department.HeaderText = "Phòng ban";
            this.Department.MinimumWidth = 8;
            this.Department.Name = "Department";
            this.Department.ReadOnly = true;
            this.Department.Width = 150;
            // 
            // BasicSalary
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.Format = "C0";
            dataGridViewCellStyle5.NullValue = null;
            this.BasicSalary.DefaultCellStyle = dataGridViewCellStyle5;
            this.BasicSalary.HeaderText = "Lương cơ bản";
            this.BasicSalary.MinimumWidth = 8;
            this.BasicSalary.Name = "BasicSalary";
            this.BasicSalary.ReadOnly = true;
            this.BasicSalary.Width = 150;
            // 
            // Allowance
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.Format = "C0";
            dataGridViewCellStyle6.NullValue = null;
            this.Allowance.DefaultCellStyle = dataGridViewCellStyle6;
            this.Allowance.HeaderText = "Phụ cấp";
            this.Allowance.MinimumWidth = 8;
            this.Allowance.Name = "Allowance";
            this.Allowance.ReadOnly = true;
            this.Allowance.Width = 150;
            // 
            // Bonus
            // 
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.Format = "C0";
            dataGridViewCellStyle7.NullValue = null;
            this.Bonus.DefaultCellStyle = dataGridViewCellStyle7;
            this.Bonus.HeaderText = "Tiền thưởng";
            this.Bonus.MinimumWidth = 8;
            this.Bonus.Name = "Bonus";
            this.Bonus.ReadOnly = true;
            this.Bonus.Width = 150;
            // 
            // GrossSalary
            // 
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.Format = "C0";
            dataGridViewCellStyle8.NullValue = null;
            this.GrossSalary.DefaultCellStyle = dataGridViewCellStyle8;
            this.GrossSalary.HeaderText = "Tổng thu nhập";
            this.GrossSalary.MinimumWidth = 8;
            this.GrossSalary.Name = "GrossSalary";
            this.GrossSalary.ReadOnly = true;
            this.GrossSalary.Width = 150;
            // 
            // Tax
            // 
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tax.DefaultCellStyle = dataGridViewCellStyle9;
            this.Tax.HeaderText = "Thuế";
            this.Tax.MinimumWidth = 8;
            this.Tax.Name = "Tax";
            this.Tax.ReadOnly = true;
            this.Tax.Width = 150;
            // 
            // NetSalary
            // 
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.Format = "C0";
            dataGridViewCellStyle10.NullValue = null;
            this.NetSalary.DefaultCellStyle = dataGridViewCellStyle10;
            this.NetSalary.HeaderText = "Số tiền được nhận";
            this.NetSalary.MinimumWidth = 8;
            this.NetSalary.Name = "NetSalary";
            this.NetSalary.ReadOnly = true;
            this.NetSalary.Width = 150;
            // 
            // PaymentDate
            // 
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.Format = "d";
            dataGridViewCellStyle11.NullValue = null;
            this.PaymentDate.DefaultCellStyle = dataGridViewCellStyle11;
            this.PaymentDate.HeaderText = "Ngày thanh toán";
            this.PaymentDate.MinimumWidth = 8;
            this.PaymentDate.Name = "PaymentDate";
            this.PaymentDate.ReadOnly = true;
            this.PaymentDate.Width = 150;
            // 
            // PaymentMethod
            // 
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentMethod.DefaultCellStyle = dataGridViewCellStyle12;
            this.PaymentMethod.HeaderText = "P.thức thanh toán";
            this.PaymentMethod.MinimumWidth = 8;
            this.PaymentMethod.Name = "PaymentMethod";
            this.PaymentMethod.ReadOnly = true;
            this.PaymentMethod.Width = 150;
            // 
            // SalaryCalculatorUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 580);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SalaryCalculatorUI";
            this.Tag = "Tính tiền lương";
            this.Text = "Tính tiền lương";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listSalary)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView listSalary;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconButton btnEdit;
        private FontAwesome.Sharp.IconButton btnDelete;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel8;
        private FontAwesome.Sharp.IconButton btnAdd;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnReset;
        private FontAwesome.Sharp.IconButton btnSearch;
        private RJCodeAdvance.RJControls.RJTextBox txtKeyword;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
        private System.Windows.Forms.DataGridViewTextBoxColumn BasicSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn Allowance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bonus;
        private System.Windows.Forms.DataGridViewTextBoxColumn GrossSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tax;
        private System.Windows.Forms.DataGridViewTextBoxColumn NetSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentMethod;
    }
}