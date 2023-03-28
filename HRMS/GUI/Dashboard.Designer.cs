namespace HRMS
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnAboutMe = new FontAwesome.Sharp.IconButton();
            this.btnLogout = new FontAwesome.Sharp.IconButton();
            this.btnEvaluate = new FontAwesome.Sharp.IconButton();
            this.btnSalaryCalculator = new FontAwesome.Sharp.IconButton();
            this.btnAttendance = new FontAwesome.Sharp.IconButton();
            this.btnContract = new FontAwesome.Sharp.IconButton();
            this.btnCandidate = new FontAwesome.Sharp.IconButton();
            this.btnEmployee = new FontAwesome.Sharp.IconButton();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMenu = new FontAwesome.Sharp.IconButton();
            this.logo = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.panelMenu.Controls.Add(this.btnAboutMe);
            this.panelMenu.Controls.Add(this.btnLogout);
            this.panelMenu.Controls.Add(this.btnEvaluate);
            this.panelMenu.Controls.Add(this.btnSalaryCalculator);
            this.panelMenu.Controls.Add(this.btnAttendance);
            this.panelMenu.Controls.Add(this.btnContract);
            this.panelMenu.Controls.Add(this.btnCandidate);
            this.panelMenu.Controls.Add(this.btnEmployee);
            this.panelMenu.Controls.Add(this.btnHome);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 561);
            this.panelMenu.TabIndex = 0;
            // 
            // btnAboutMe
            // 
            this.btnAboutMe.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAboutMe.FlatAppearance.BorderSize = 0;
            this.btnAboutMe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAboutMe.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAboutMe.ForeColor = System.Drawing.Color.White;
            this.btnAboutMe.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.btnAboutMe.IconColor = System.Drawing.Color.White;
            this.btnAboutMe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAboutMe.IconSize = 25;
            this.btnAboutMe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAboutMe.Location = new System.Drawing.Point(0, 469);
            this.btnAboutMe.Name = "btnAboutMe";
            this.btnAboutMe.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAboutMe.Size = new System.Drawing.Size(200, 46);
            this.btnAboutMe.TabIndex = 8;
            this.btnAboutMe.Tag = "Giới thiệu";
            this.btnAboutMe.Text = "Giới thiệu";
            this.btnAboutMe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAboutMe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAboutMe.UseVisualStyleBackColor = true;
            this.btnAboutMe.Click += new System.EventHandler(this.OpenNewTabAndCloseCurrentTab);
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnLogout.IconColor = System.Drawing.Color.White;
            this.btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogout.IconSize = 25;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 515);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 10);
            this.btnLogout.Size = new System.Drawing.Size(200, 46);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Tag = "Đăng Xuất";
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnPerformanceReview
            // 
            this.btnEvaluate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEvaluate.FlatAppearance.BorderSize = 0;
            this.btnEvaluate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEvaluate.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvaluate.ForeColor = System.Drawing.Color.White;
            this.btnEvaluate.IconChar = FontAwesome.Sharp.IconChar.Wpforms;
            this.btnEvaluate.IconColor = System.Drawing.Color.White;
            this.btnEvaluate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEvaluate.IconSize = 25;
            this.btnEvaluate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEvaluate.Location = new System.Drawing.Point(0, 350);
            this.btnEvaluate.Name = "btnPerformanceReview";
            this.btnEvaluate.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEvaluate.Size = new System.Drawing.Size(200, 46);
            this.btnEvaluate.TabIndex = 6;
            this.btnEvaluate.Tag = "Đánh giá";
            this.btnEvaluate.Text = "Đánh giá";
            this.btnEvaluate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEvaluate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEvaluate.UseVisualStyleBackColor = true;
            this.btnEvaluate.Click += new System.EventHandler(this.OpenNewTabAndCloseCurrentTab);
            // 
            // btnSalaryCalculator
            // 
            this.btnSalaryCalculator.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSalaryCalculator.FlatAppearance.BorderSize = 0;
            this.btnSalaryCalculator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalaryCalculator.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalaryCalculator.ForeColor = System.Drawing.Color.White;
            this.btnSalaryCalculator.IconChar = FontAwesome.Sharp.IconChar.BalanceScale;
            this.btnSalaryCalculator.IconColor = System.Drawing.Color.White;
            this.btnSalaryCalculator.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalaryCalculator.IconSize = 25;
            this.btnSalaryCalculator.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalaryCalculator.Location = new System.Drawing.Point(0, 304);
            this.btnSalaryCalculator.Name = "btnSalaryCalculator";
            this.btnSalaryCalculator.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSalaryCalculator.Size = new System.Drawing.Size(200, 46);
            this.btnSalaryCalculator.TabIndex = 7;
            this.btnSalaryCalculator.Tag = "Tiền lương";
            this.btnSalaryCalculator.Text = "Tiền lương";
            this.btnSalaryCalculator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalaryCalculator.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalaryCalculator.UseVisualStyleBackColor = true;
            this.btnSalaryCalculator.Click += new System.EventHandler(this.OpenNewTabAndCloseCurrentTab);
            // 
            // btnTimekeeping
            // 
            this.btnAttendance.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAttendance.FlatAppearance.BorderSize = 0;
            this.btnAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttendance.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttendance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAttendance.IconChar = FontAwesome.Sharp.IconChar.ClipboardCheck;
            this.btnAttendance.IconColor = System.Drawing.Color.White;
            this.btnAttendance.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAttendance.IconSize = 25;
            this.btnAttendance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAttendance.Location = new System.Drawing.Point(0, 258);
            this.btnAttendance.Name = "btnTimekeeping";
            this.btnAttendance.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAttendance.Size = new System.Drawing.Size(200, 46);
            this.btnAttendance.TabIndex = 5;
            this.btnAttendance.Tag = "Chấm công";
            this.btnAttendance.Text = "Chấm công";
            this.btnAttendance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAttendance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAttendance.UseVisualStyleBackColor = true;
            this.btnAttendance.Click += new System.EventHandler(this.OpenNewTabAndCloseCurrentTab);
            // 
            // btnContract
            // 
            this.btnContract.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnContract.FlatAppearance.BorderSize = 0;
            this.btnContract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContract.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContract.ForeColor = System.Drawing.Color.White;
            this.btnContract.IconChar = FontAwesome.Sharp.IconChar.FileSignature;
            this.btnContract.IconColor = System.Drawing.Color.White;
            this.btnContract.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnContract.IconSize = 25;
            this.btnContract.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContract.Location = new System.Drawing.Point(0, 212);
            this.btnContract.Name = "btnContract";
            this.btnContract.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnContract.Size = new System.Drawing.Size(200, 46);
            this.btnContract.TabIndex = 4;
            this.btnContract.Tag = "Hợp đồng";
            this.btnContract.Text = "Hợp đồng";
            this.btnContract.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContract.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnContract.UseVisualStyleBackColor = true;
            this.btnContract.Click += new System.EventHandler(this.OpenNewTabAndCloseCurrentTab);
            // 
            // btnRecruitment
            // 
            this.btnCandidate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCandidate.FlatAppearance.BorderSize = 0;
            this.btnCandidate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCandidate.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCandidate.ForeColor = System.Drawing.Color.White;
            this.btnCandidate.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnCandidate.IconColor = System.Drawing.Color.White;
            this.btnCandidate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCandidate.IconSize = 25;
            this.btnCandidate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCandidate.Location = new System.Drawing.Point(0, 166);
            this.btnCandidate.Name = "btnRecruitment";
            this.btnCandidate.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCandidate.Size = new System.Drawing.Size(200, 46);
            this.btnCandidate.TabIndex = 3;
            this.btnCandidate.Tag = "Tuyển dụng";
            this.btnCandidate.Text = "Tuyển dụng";
            this.btnCandidate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCandidate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCandidate.UseVisualStyleBackColor = true;
            this.btnCandidate.Click += new System.EventHandler(this.OpenNewTabAndCloseCurrentTab);
            // 
            // btnPersonnel
            // 
            this.btnEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmployee.FlatAppearance.BorderSize = 0;
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployee.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ForeColor = System.Drawing.Color.White;
            this.btnEmployee.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnEmployee.IconColor = System.Drawing.Color.White;
            this.btnEmployee.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEmployee.IconSize = 25;
            this.btnEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployee.Location = new System.Drawing.Point(0, 120);
            this.btnEmployee.Name = "btnPersonnel";
            this.btnEmployee.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEmployee.Size = new System.Drawing.Size(200, 46);
            this.btnEmployee.TabIndex = 2;
            this.btnEmployee.Tag = "Nhân sự";
            this.btnEmployee.Text = "Nhân sự";
            this.btnEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.OpenNewTabAndCloseCurrentTab);
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.HomeUser;
            this.btnHome.IconColor = System.Drawing.Color.White;
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.IconSize = 25;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 74);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(200, 46);
            this.btnHome.TabIndex = 1;
            this.btnHome.Tag = "Trang chủ";
            this.btnHome.Text = "Trang chủ";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.OpenNewTabAndCloseCurrentTab);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Controls.Add(this.logo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 74);
            this.panel1.TabIndex = 0;
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.IconChar = FontAwesome.Sharp.IconChar.AlignJustify;
            this.btnMenu.IconColor = System.Drawing.Color.White;
            this.btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenu.IconSize = 30;
            this.btnMenu.Location = new System.Drawing.Point(140, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(60, 60);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // logo
            // 
            this.logo.Image = global::HRMS.Properties.Resources.logo;
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(108, 60);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.White;
            this.panelTitleBar.Controls.Add(this.lbTitle);
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(200, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(934, 57);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(26, 15);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(161, 25);
            this.lbTitle.TabIndex = 5;
            this.lbTitle.Text = "DASHBOARD";
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
            this.btnMinimize.Location = new System.Drawing.Point(864, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(35, 20);
            this.btnMinimize.TabIndex = 4;
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
            this.btnClose.Location = new System.Drawing.Point(899, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 20);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.AutoScroll = true;
            this.panelDesktop.AutoSize = true;
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(200, 57);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panelDesktop.Size = new System.Drawing.Size(934, 504);
            this.panelDesktop.TabIndex = 2;
            this.panelDesktop.Resize += new System.EventHandler(this.PanelResize);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 561);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1148, 594);
            this.Name = "Dashboard";
            this.Text = "Quản lý nhân sự";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnMenu;
        private FontAwesome.Sharp.IconButton btnLogout;
        private FontAwesome.Sharp.IconButton btnSalaryCalculator;
        private FontAwesome.Sharp.IconButton btnEvaluate;
        private FontAwesome.Sharp.IconButton btnAttendance;
        private FontAwesome.Sharp.IconButton btnCandidate;
        private FontAwesome.Sharp.IconButton btnEmployee;
        private FontAwesome.Sharp.IconButton btnHome;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.PictureBox logo;
        private FontAwesome.Sharp.IconButton btnContract;
        private FontAwesome.Sharp.IconButton btnAboutMe;
    }
}

