namespace HRMS.GUI
{
    partial class AddContractUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddContractUI));
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNote = new RJCodeAdvance.RJControls.RJTextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.cbContractType = new RJCodeAdvance.RJControls.RJComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAdd = new RJCodeAdvance.RJControls.RJButton();
            this.panel16 = new System.Windows.Forms.Panel();
            this.dpEndDate = new RJCodeAdvance.RJControls.RJDatePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.dpStartDate = new RJCodeAdvance.RJControls.RJDatePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.cbEmployee = new RJCodeAdvance.RJControls.RJComboBox();
            this.lbEmployee = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.cbDepartment = new RJCodeAdvance.RJControls.RJComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBasicSalary = new RJCodeAdvance.RJControls.RJTextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtWorkingTime = new RJCodeAdvance.RJControls.RJTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Controls.Add(this.panel16);
            this.panel5.Controls.Add(this.panel15);
            this.panel5.Controls.Add(this.panel13);
            this.panel5.Controls.Add(this.panel12);
            this.panel5.Controls.Add(this.panel10);
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(188, 25);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(410, 337);
            this.panel5.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.txtNote);
            this.panel4.Location = new System.Drawing.Point(208, 222);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(158, 59);
            this.panel4.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ghi chú";
            // 
            // txtNote
            // 
            this.txtNote.BackColor = System.Drawing.SystemColors.Window;
            this.txtNote.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNote.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNote.BorderRadius = 0;
            this.txtNote.BorderSize = 1;
            this.txtNote.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNote.Location = new System.Drawing.Point(4, 24);
            this.txtNote.Margin = new System.Windows.Forms.Padding(4);
            this.txtNote.MaximumSize = new System.Drawing.Size(150, 31);
            this.txtNote.MinimumSize = new System.Drawing.Size(150, 31);
            this.txtNote.Multiline = false;
            this.txtNote.Name = "txtNote";
            this.txtNote.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNote.PasswordChar = false;
            this.txtNote.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNote.PlaceholderText = "Ghi chú";
            this.txtNote.Size = new System.Drawing.Size(150, 31);
            this.txtNote.TabIndex = 0;
            this.txtNote.Texts = "";
            this.txtNote.UnderlinedStyle = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.cbContractType);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Location = new System.Drawing.Point(44, 222);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(158, 59);
            this.panel7.TabIndex = 6;
            // 
            // cbContractType
            // 
            this.cbContractType.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbContractType.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbContractType.BorderSize = 1;
            this.cbContractType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbContractType.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbContractType.ForeColor = System.Drawing.Color.DimGray;
            this.cbContractType.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbContractType.Items.AddRange(new object[] {
            "1 Năm",
            "5 Năm",
            "10 Năm"});
            this.cbContractType.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbContractType.ListTextColor = System.Drawing.Color.DimGray;
            this.cbContractType.Location = new System.Drawing.Point(4, 25);
            this.cbContractType.MaximumSize = new System.Drawing.Size(150, 31);
            this.cbContractType.MinimumSize = new System.Drawing.Size(150, 31);
            this.cbContractType.Name = "cbContractType";
            this.cbContractType.Padding = new System.Windows.Forms.Padding(1);
            this.cbContractType.Size = new System.Drawing.Size(150, 31);
            this.cbContractType.TabIndex = 0;
            this.cbContractType.Texts = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Loại hợp đồng";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Location = new System.Drawing.Point(208, 284);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(158, 43);
            this.panel3.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAdd.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAdd.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAdd.BorderRadius = 0;
            this.btnAdd.BorderSize = 0;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(4, 9);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 31);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.dpEndDate);
            this.panel16.Controls.Add(this.label11);
            this.panel16.Location = new System.Drawing.Point(209, 99);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(158, 59);
            this.panel16.TabIndex = 3;
            // 
            // dpEndDate
            // 
            this.dpEndDate.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dpEndDate.BorderSize = 0;
            this.dpEndDate.CalendarFont = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpEndDate.CustomFormat = "dd/MM/yyyy";
            this.dpEndDate.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpEndDate.Location = new System.Drawing.Point(4, 24);
            this.dpEndDate.MaximumSize = new System.Drawing.Size(150, 31);
            this.dpEndDate.MinimumSize = new System.Drawing.Size(150, 31);
            this.dpEndDate.Name = "dpEndDate";
            this.dpEndDate.Size = new System.Drawing.Size(150, 31);
            this.dpEndDate.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.dpEndDate.TabIndex = 0;
            this.dpEndDate.TextColor = System.Drawing.Color.White;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Ngày kết thúc";
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.dpStartDate);
            this.panel15.Controls.Add(this.label10);
            this.panel15.Location = new System.Drawing.Point(44, 99);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(158, 59);
            this.panel15.TabIndex = 2;
            // 
            // dpStartDate
            // 
            this.dpStartDate.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dpStartDate.BorderSize = 0;
            this.dpStartDate.CalendarFont = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpStartDate.CustomFormat = "dd/MM/yyyy";
            this.dpStartDate.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpStartDate.Location = new System.Drawing.Point(4, 24);
            this.dpStartDate.MaximumSize = new System.Drawing.Size(150, 31);
            this.dpStartDate.MinimumSize = new System.Drawing.Size(150, 31);
            this.dpStartDate.Name = "dpStartDate";
            this.dpStartDate.Size = new System.Drawing.Size(150, 31);
            this.dpStartDate.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.dpStartDate.TabIndex = 0;
            this.dpStartDate.TextColor = System.Drawing.Color.White;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Ngày bắt đầu";
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.cbEmployee);
            this.panel13.Controls.Add(this.lbEmployee);
            this.panel13.Location = new System.Drawing.Point(209, 37);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(158, 59);
            this.panel13.TabIndex = 1;
            // 
            // cbEmployee
            // 
            this.cbEmployee.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbEmployee.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbEmployee.BorderSize = 1;
            this.cbEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmployee.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEmployee.ForeColor = System.Drawing.Color.DimGray;
            this.cbEmployee.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbEmployee.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbEmployee.ListTextColor = System.Drawing.Color.DimGray;
            this.cbEmployee.Location = new System.Drawing.Point(4, 25);
            this.cbEmployee.MaximumSize = new System.Drawing.Size(150, 31);
            this.cbEmployee.MinimumSize = new System.Drawing.Size(150, 31);
            this.cbEmployee.Name = "cbEmployee";
            this.cbEmployee.Padding = new System.Windows.Forms.Padding(1);
            this.cbEmployee.Size = new System.Drawing.Size(150, 31);
            this.cbEmployee.TabIndex = 0;
            this.cbEmployee.Texts = "";
            // 
            // lbEmployee
            // 
            this.lbEmployee.AllowDrop = true;
            this.lbEmployee.AutoSize = true;
            this.lbEmployee.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmployee.Location = new System.Drawing.Point(1, 7);
            this.lbEmployee.Name = "lbEmployee";
            this.lbEmployee.Size = new System.Drawing.Size(64, 13);
            this.lbEmployee.TabIndex = 3;
            this.lbEmployee.Text = "Nhân viên";
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.cbDepartment);
            this.panel12.Controls.Add(this.label6);
            this.panel12.Location = new System.Drawing.Point(44, 37);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(158, 59);
            this.panel12.TabIndex = 0;
            // 
            // cbDepartment
            // 
            this.cbDepartment.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbDepartment.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbDepartment.BorderSize = 1;
            this.cbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartment.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDepartment.ForeColor = System.Drawing.Color.DimGray;
            this.cbDepartment.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbDepartment.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbDepartment.ListTextColor = System.Drawing.Color.DimGray;
            this.cbDepartment.Location = new System.Drawing.Point(4, 25);
            this.cbDepartment.MaximumSize = new System.Drawing.Size(150, 31);
            this.cbDepartment.MinimumSize = new System.Drawing.Size(150, 31);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Padding = new System.Windows.Forms.Padding(1);
            this.cbDepartment.Size = new System.Drawing.Size(150, 31);
            this.cbDepartment.TabIndex = 0;
            this.cbDepartment.Texts = "";
            this.cbDepartment.OnSelectedIndexChanged += new System.EventHandler(this.cbDepartment_OnSelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Phòng ban";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.label4);
            this.panel10.Controls.Add(this.txtBasicSalary);
            this.panel10.Location = new System.Drawing.Point(209, 160);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(158, 59);
            this.panel10.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lương cơ bản";
            // 
            // txtBasicSalary
            // 
            this.txtBasicSalary.BackColor = System.Drawing.SystemColors.Window;
            this.txtBasicSalary.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtBasicSalary.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtBasicSalary.BorderRadius = 0;
            this.txtBasicSalary.BorderSize = 1;
            this.txtBasicSalary.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBasicSalary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBasicSalary.Location = new System.Drawing.Point(4, 24);
            this.txtBasicSalary.Margin = new System.Windows.Forms.Padding(4);
            this.txtBasicSalary.MaximumSize = new System.Drawing.Size(150, 31);
            this.txtBasicSalary.MinimumSize = new System.Drawing.Size(150, 31);
            this.txtBasicSalary.Multiline = false;
            this.txtBasicSalary.Name = "txtBasicSalary";
            this.txtBasicSalary.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBasicSalary.PasswordChar = false;
            this.txtBasicSalary.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBasicSalary.PlaceholderText = "Lương";
            this.txtBasicSalary.Size = new System.Drawing.Size(150, 31);
            this.txtBasicSalary.TabIndex = 0;
            this.txtBasicSalary.Texts = "";
            this.txtBasicSalary.UnderlinedStyle = true;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.label3);
            this.panel9.Controls.Add(this.txtWorkingTime);
            this.panel9.Location = new System.Drawing.Point(44, 160);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(158, 59);
            this.panel9.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Thời gian làm việc (giờ)";
            // 
            // txtWorkingTime
            // 
            this.txtWorkingTime.BackColor = System.Drawing.SystemColors.Window;
            this.txtWorkingTime.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtWorkingTime.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtWorkingTime.BorderRadius = 0;
            this.txtWorkingTime.BorderSize = 1;
            this.txtWorkingTime.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWorkingTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtWorkingTime.Location = new System.Drawing.Point(4, 24);
            this.txtWorkingTime.Margin = new System.Windows.Forms.Padding(4);
            this.txtWorkingTime.MaximumSize = new System.Drawing.Size(150, 31);
            this.txtWorkingTime.MinimumSize = new System.Drawing.Size(150, 31);
            this.txtWorkingTime.Multiline = false;
            this.txtWorkingTime.Name = "txtWorkingTime";
            this.txtWorkingTime.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtWorkingTime.PasswordChar = false;
            this.txtWorkingTime.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtWorkingTime.PlaceholderText = "Thời gian làm";
            this.txtWorkingTime.Size = new System.Drawing.Size(150, 31);
            this.txtWorkingTime.TabIndex = 0;
            this.txtWorkingTime.Texts = "";
            this.txtWorkingTime.UnderlinedStyle = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnMinimize);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(188, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(410, 25);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(173)))), ((int)(((byte)(202)))));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnMinimize.IconColor = System.Drawing.Color.White;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 15;
            this.btnMinimize.Location = new System.Drawing.Point(341, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(35, 20);
            this.btnMinimize.TabIndex = 0;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(131)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 15;
            this.btnClose.Location = new System.Drawing.Point(375, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 20);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 362);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::HRMS.Properties.Resources.logo;
            this.pictureBox3.Location = new System.Drawing.Point(12, 25);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(160, 86);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // AddContractUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 362);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddContractUI";
            this.Text = "Thêm hợp đồng";
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private RJCodeAdvance.RJControls.RJButton btnAdd;
        private System.Windows.Forms.Panel panel16;
        private RJCodeAdvance.RJControls.RJDatePicker dpEndDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel15;
        private RJCodeAdvance.RJControls.RJDatePicker dpStartDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel13;
        private RJCodeAdvance.RJControls.RJComboBox cbEmployee;
        private System.Windows.Forms.Label lbEmployee;
        private System.Windows.Forms.Panel panel12;
        private RJCodeAdvance.RJControls.RJComboBox cbDepartment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label4;
        private RJCodeAdvance.RJControls.RJTextBox txtBasicSalary;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label3;
        private RJCodeAdvance.RJControls.RJTextBox txtWorkingTime;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel7;
        private RJCodeAdvance.RJControls.RJComboBox cbContractType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private RJCodeAdvance.RJControls.RJTextBox txtNote;
    }
}