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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.listEvaluate = new System.Windows.Forms.DataGridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnEdit = new FontAwesome.Sharp.IconButton();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.btnReset = new FontAwesome.Sharp.IconButton();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.txtKeyword = new RJCodeAdvance.RJControls.RJTextBox();
            this.EmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EvaluationPeriod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EvaluationCriteria = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.EvaluationScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManagerComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EvaluationResult = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ImprovementPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listEvaluate)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(60, 62);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1500, 769);
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
            this.panel4.Location = new System.Drawing.Point(0, 77);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1500, 692);
            this.panel4.TabIndex = 2;
            // 
            // listEvaluate
            // 
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
            this.listEvaluate.Location = new System.Drawing.Point(30, 31);
            this.listEvaluate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listEvaluate.Name = "listEvaluate";
            this.listEvaluate.RowHeadersWidth = 62;
            this.listEvaluate.Size = new System.Drawing.Size(1410, 630);
            this.listEvaluate.TabIndex = 4;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(30, 661);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1410, 31);
            this.panel7.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 31);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(30, 661);
            this.panel6.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnEdit);
            this.panel5.Controls.Add(this.btnDelete);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(1440, 31);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(60, 661);
            this.panel5.TabIndex = 1;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.IconChar = FontAwesome.Sharp.IconChar.SdCard;
            this.btnEdit.IconColor = System.Drawing.Color.Black;
            this.btnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEdit.IconSize = 30;
            this.btnEdit.Location = new System.Drawing.Point(3, 7);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(45, 46);
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
            this.btnDelete.Location = new System.Drawing.Point(3, 64);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(45, 46);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1500, 31);
            this.panel3.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.iconButton1);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.btnReset);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.txtKeyword);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1500, 77);
            this.panel2.TabIndex = 0;
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.iconButton1.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.Location = new System.Drawing.Point(1054, 20);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(45, 46);
            this.iconButton1.TabIndex = 6;
            this.iconButton1.UseVisualStyleBackColor = true;
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
            this.btnAdd.Location = new System.Drawing.Point(1443, 20);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(45, 46);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.btnReset.Location = new System.Drawing.Point(1392, 20);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(45, 46);
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
            this.btnSearch.Location = new System.Drawing.Point(1338, 20);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(45, 46);
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
            this.txtKeyword.Location = new System.Drawing.Point(1110, 18);
            this.txtKeyword.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtKeyword.Multiline = false;
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.txtKeyword.PasswordChar = false;
            this.txtKeyword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtKeyword.PlaceholderText = "Tìm kiếm";
            this.txtKeyword.Size = new System.Drawing.Size(228, 47);
            this.txtKeyword.TabIndex = 0;
            this.txtKeyword.Texts = "";
            this.txtKeyword.UnderlinedStyle = false;
            // 
            // EmployeeID
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.FullName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FullName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.FullName.Width = 150;
            // 
            // Department
            // 
            this.Department.HeaderText = "Phòng ban";
            this.Department.MinimumWidth = 8;
            this.Department.Name = "Department";
            this.Department.Width = 150;
            // 
            // EvaluationPeriod
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.EvaluationPeriod.DefaultCellStyle = dataGridViewCellStyle3;
            this.EvaluationPeriod.HeaderText = "Thời gian đánh giá";
            this.EvaluationPeriod.MinimumWidth = 8;
            this.EvaluationPeriod.Name = "EvaluationPeriod";
            this.EvaluationPeriod.Width = 150;
            // 
            // EvaluationCriteria
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EvaluationCriteria.DefaultCellStyle = dataGridViewCellStyle4;
            this.EvaluationCriteria.HeaderText = "Tiêu chí đánh giá";
            this.EvaluationCriteria.MinimumWidth = 8;
            this.EvaluationCriteria.Name = "EvaluationCriteria";
            this.EvaluationCriteria.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EvaluationCriteria.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.EvaluationCriteria.Width = 150;
            // 
            // EvaluationScore
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.EvaluationScore.DefaultCellStyle = dataGridViewCellStyle5;
            this.EvaluationScore.HeaderText = "Điểm đánh giá";
            this.EvaluationScore.MinimumWidth = 8;
            this.EvaluationScore.Name = "EvaluationScore";
            this.EvaluationScore.Width = 150;
            // 
            // ManagerComment
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManagerComment.DefaultCellStyle = dataGridViewCellStyle6;
            this.ManagerComment.HeaderText = "Nhận xét của quản lý";
            this.ManagerComment.MinimumWidth = 8;
            this.ManagerComment.Name = "ManagerComment";
            this.ManagerComment.Width = 150;
            // 
            // EmployeeComment
            // 
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeComment.DefaultCellStyle = dataGridViewCellStyle7;
            this.EmployeeComment.HeaderText = "Nhận xét của nhân viên";
            this.EmployeeComment.MinimumWidth = 8;
            this.EmployeeComment.Name = "EmployeeComment";
            this.EmployeeComment.Width = 150;
            // 
            // EvaluationResult
            // 
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EvaluationResult.DefaultCellStyle = dataGridViewCellStyle8;
            this.EvaluationResult.HeaderText = "Kết quả đánh giá";
            this.EvaluationResult.MinimumWidth = 8;
            this.EvaluationResult.Name = "EvaluationResult";
            this.EvaluationResult.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EvaluationResult.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.EvaluationResult.Width = 150;
            // 
            // ImprovementPlan
            // 
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImprovementPlan.DefaultCellStyle = dataGridViewCellStyle9;
            this.ImprovementPlan.HeaderText = "Kế hoạch cải thiện";
            this.ImprovementPlan.MinimumWidth = 8;
            this.ImprovementPlan.Name = "ImprovementPlan";
            this.ImprovementPlan.Width = 150;
            // 
            // EvaluateUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1620, 892);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EvaluateUI";
            this.Tag = "Đánh giá nhân viên";
            this.Text = "Đánh giá";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listEvaluate)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
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
        private FontAwesome.Sharp.IconButton btnAdd;
        private FontAwesome.Sharp.IconButton btnReset;
        private FontAwesome.Sharp.IconButton btnSearch;
        private RJCodeAdvance.RJControls.RJTextBox txtKeyword;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeID;
        private System.Windows.Forms.DataGridViewComboBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
        private System.Windows.Forms.DataGridViewTextBoxColumn EvaluationPeriod;
        private System.Windows.Forms.DataGridViewComboBoxColumn EvaluationCriteria;
        private System.Windows.Forms.DataGridViewTextBoxColumn EvaluationScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManagerComment;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeComment;
        private System.Windows.Forms.DataGridViewComboBoxColumn EvaluationResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImprovementPlan;
    }
}