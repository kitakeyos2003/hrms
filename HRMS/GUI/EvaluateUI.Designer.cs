namespace HRMS.GUI
{
    partial class EvaluateUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle64 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle65 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle66 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle67 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle68 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle69 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle70 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle71 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle72 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.listEvaluate = new System.Windows.Forms.DataGridView();
            this.EmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EvaluationPeriod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EvaluationCriteria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EvaluationScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManagerComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EvaluationResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImprovementPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lbPage = new System.Windows.Forms.Label();
            this.prePage = new FontAwesome.Sharp.IconButton();
            this.nextPage = new FontAwesome.Sharp.IconButton();
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
            this.cbPosition = new System.Windows.Forms.ComboBox();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.cbLimitPage = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listEvaluate)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.panel4.Controls.Add(this.listEvaluate);
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
            // listEvaluate
            // 
            this.listEvaluate.AllowUserToAddRows = false;
            this.listEvaluate.AllowUserToDeleteRows = false;
            this.listEvaluate.BackgroundColor = System.Drawing.Color.White;
            this.listEvaluate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listEvaluate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeID,
            this.FullName,
            this.Department,
            this.EvaluationPeriod,
            this.EvaluationCriteria,
            this.EvaluationScore,
            this.ManagerComment,
            this.EmployeeComment,
            this.EvaluationResult,
            this.ImprovementPlan});
            this.listEvaluate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listEvaluate.Location = new System.Drawing.Point(20, 20);
            this.listEvaluate.MultiSelect = false;
            this.listEvaluate.Name = "listEvaluate";
            this.listEvaluate.ReadOnly = true;
            this.listEvaluate.RowHeadersWidth = 62;
            this.listEvaluate.Size = new System.Drawing.Size(940, 410);
            this.listEvaluate.TabIndex = 4;
            this.listEvaluate.SelectionChanged += new System.EventHandler(this.listEvaluate_SelectionChanged);
            // 
            // EmployeeID
            // 
            dataGridViewCellStyle64.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeID.DefaultCellStyle = dataGridViewCellStyle64;
            this.EmployeeID.HeaderText = "ID";
            this.EmployeeID.MinimumWidth = 8;
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.ReadOnly = true;
            this.EmployeeID.Width = 150;
            // 
            // FullName
            // 
            dataGridViewCellStyle65.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullName.DefaultCellStyle = dataGridViewCellStyle65;
            this.FullName.HeaderText = "Họ và tên";
            this.FullName.MinimumWidth = 8;
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            this.FullName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FullName.Width = 150;
            // 
            // Department
            // 
            this.Department.HeaderText = "Phòng ban";
            this.Department.MinimumWidth = 8;
            this.Department.Name = "Department";
            this.Department.ReadOnly = true;
            this.Department.Width = 150;
            // 
            // EvaluationPeriod
            // 
            dataGridViewCellStyle66.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle66.Format = "d";
            dataGridViewCellStyle66.NullValue = null;
            this.EvaluationPeriod.DefaultCellStyle = dataGridViewCellStyle66;
            this.EvaluationPeriod.HeaderText = "Thời gian đánh giá";
            this.EvaluationPeriod.MinimumWidth = 8;
            this.EvaluationPeriod.Name = "EvaluationPeriod";
            this.EvaluationPeriod.ReadOnly = true;
            this.EvaluationPeriod.Width = 150;
            // 
            // EvaluationCriteria
            // 
            dataGridViewCellStyle67.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EvaluationCriteria.DefaultCellStyle = dataGridViewCellStyle67;
            this.EvaluationCriteria.HeaderText = "Tiêu chí đánh giá";
            this.EvaluationCriteria.MinimumWidth = 8;
            this.EvaluationCriteria.Name = "EvaluationCriteria";
            this.EvaluationCriteria.ReadOnly = true;
            this.EvaluationCriteria.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EvaluationCriteria.Width = 150;
            // 
            // EvaluationScore
            // 
            dataGridViewCellStyle68.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle68.Format = "N2";
            dataGridViewCellStyle68.NullValue = null;
            this.EvaluationScore.DefaultCellStyle = dataGridViewCellStyle68;
            this.EvaluationScore.HeaderText = "Điểm đánh giá";
            this.EvaluationScore.MinimumWidth = 8;
            this.EvaluationScore.Name = "EvaluationScore";
            this.EvaluationScore.ReadOnly = true;
            this.EvaluationScore.Width = 150;
            // 
            // ManagerComment
            // 
            dataGridViewCellStyle69.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManagerComment.DefaultCellStyle = dataGridViewCellStyle69;
            this.ManagerComment.HeaderText = "Nhận xét của quản lý";
            this.ManagerComment.MinimumWidth = 8;
            this.ManagerComment.Name = "ManagerComment";
            this.ManagerComment.ReadOnly = true;
            this.ManagerComment.Width = 150;
            // 
            // EmployeeComment
            // 
            dataGridViewCellStyle70.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeComment.DefaultCellStyle = dataGridViewCellStyle70;
            this.EmployeeComment.HeaderText = "Nhận xét của nhân viên";
            this.EmployeeComment.MinimumWidth = 8;
            this.EmployeeComment.Name = "EmployeeComment";
            this.EmployeeComment.ReadOnly = true;
            this.EmployeeComment.Width = 150;
            // 
            // EvaluationResult
            // 
            dataGridViewCellStyle71.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EvaluationResult.DefaultCellStyle = dataGridViewCellStyle71;
            this.EvaluationResult.HeaderText = "Kết quả đánh giá";
            this.EvaluationResult.MinimumWidth = 8;
            this.EvaluationResult.Name = "EvaluationResult";
            this.EvaluationResult.ReadOnly = true;
            this.EvaluationResult.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EvaluationResult.Width = 150;
            // 
            // ImprovementPlan
            // 
            dataGridViewCellStyle72.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImprovementPlan.DefaultCellStyle = dataGridViewCellStyle72;
            this.ImprovementPlan.HeaderText = "Kế hoạch cải thiện";
            this.ImprovementPlan.MinimumWidth = 8;
            this.ImprovementPlan.Name = "ImprovementPlan";
            this.ImprovementPlan.ReadOnly = true;
            this.ImprovementPlan.Width = 150;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.cbLimitPage);
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(20, 430);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(940, 20);
            this.panel7.TabIndex = 3;
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.Controls.Add(this.lbPage);
            this.panel9.Controls.Add(this.prePage);
            this.panel9.Controls.Add(this.nextPage);
            this.panel9.Location = new System.Drawing.Point(860, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(80, 20);
            this.panel9.TabIndex = 3;
            // 
            // lbPage
            // 
            this.lbPage.AutoSize = true;
            this.lbPage.Location = new System.Drawing.Point(32, 4);
            this.lbPage.Name = "lbPage";
            this.lbPage.Size = new System.Drawing.Size(13, 13);
            this.lbPage.TabIndex = 3;
            this.lbPage.Text = "1";
            // 
            // prePage
            // 
            this.prePage.FlatAppearance.BorderSize = 0;
            this.prePage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prePage.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleLeft;
            this.prePage.IconColor = System.Drawing.Color.Black;
            this.prePage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.prePage.IconSize = 20;
            this.prePage.Location = new System.Drawing.Point(0, 0);
            this.prePage.Name = "prePage";
            this.prePage.Size = new System.Drawing.Size(32, 20);
            this.prePage.TabIndex = 3;
            this.prePage.UseVisualStyleBackColor = true;
            this.prePage.Click += new System.EventHandler(this.prePage_Click);
            // 
            // nextPage
            // 
            this.nextPage.FlatAppearance.BorderSize = 0;
            this.nextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextPage.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleRight;
            this.nextPage.IconColor = System.Drawing.Color.Black;
            this.nextPage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.nextPage.IconSize = 20;
            this.nextPage.Location = new System.Drawing.Point(48, 0);
            this.nextPage.Name = "nextPage";
            this.nextPage.Size = new System.Drawing.Size(32, 20);
            this.nextPage.TabIndex = 0;
            this.nextPage.UseVisualStyleBackColor = true;
            this.nextPage.Click += new System.EventHandler(this.nextPage_Click);
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
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
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
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbPosition);
            this.panel3.Controls.Add(this.cbDepartment);
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
            this.panel8.Location = new System.Drawing.Point(697, 16);
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
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
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
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            // cbPosition
            // 
            this.cbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.Location = new System.Drawing.Point(147, 0);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(121, 21);
            this.cbPosition.TabIndex = 13;
            this.cbPosition.SelectedIndexChanged += new System.EventHandler(this.cbPosition_SelectedIndexChanged);
            // 
            // cbDepartment
            // 
            this.cbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Location = new System.Drawing.Point(20, 0);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(121, 21);
            this.cbDepartment.TabIndex = 12;
            this.cbDepartment.SelectedIndexChanged += new System.EventHandler(this.cbDepartment_SelectedIndexChanged);
            // 
            // cbLimitPage
            // 
            this.cbLimitPage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLimitPage.FormattingEnabled = true;
            this.cbLimitPage.Location = new System.Drawing.Point(825, -1);
            this.cbLimitPage.Name = "cbLimitPage";
            this.cbLimitPage.Size = new System.Drawing.Size(42, 21);
            this.cbLimitPage.TabIndex = 4;
            this.cbLimitPage.SelectedIndexChanged += new System.EventHandler(this.cbLimitPage_SelectedIndexChanged);
            // 
            // EvaluateUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 580);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EvaluateUI";
            this.Tag = "Đánh giá nhân viên";
            this.Text = "Đánh giá";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listEvaluate)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView listEvaluate;
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
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lbPage;
        private FontAwesome.Sharp.IconButton prePage;
        private FontAwesome.Sharp.IconButton nextPage;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
        private System.Windows.Forms.DataGridViewTextBoxColumn EvaluationPeriod;
        private System.Windows.Forms.DataGridViewTextBoxColumn EvaluationCriteria;
        private System.Windows.Forms.DataGridViewTextBoxColumn EvaluationScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManagerComment;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeComment;
        private System.Windows.Forms.DataGridViewTextBoxColumn EvaluationResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImprovementPlan;
        private System.Windows.Forms.ComboBox cbPosition;
        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.ComboBox cbLimitPage;
    }
}