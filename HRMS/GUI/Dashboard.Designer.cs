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
            this.btnLogout = new FontAwesome.Sharp.IconButton();
            this.btnSalaryCalculator = new FontAwesome.Sharp.IconButton();
            this.btnPerformanceReview = new FontAwesome.Sharp.IconButton();
            this.btnTimekeeping = new FontAwesome.Sharp.IconButton();
            this.btnRecruitment = new FontAwesome.Sharp.IconButton();
            this.btnPersonnel = new FontAwesome.Sharp.IconButton();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMenu = new FontAwesome.Sharp.IconButton();
            this.logo = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnMaximize = new FontAwesome.Sharp.IconButton();
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
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.panelMenu.Controls.Add(this.btnLogout);
            this.panelMenu.Controls.Add(this.btnSalaryCalculator);
            this.panelMenu.Controls.Add(this.btnPerformanceReview);
            this.panelMenu.Controls.Add(this.btnTimekeeping);
            this.panelMenu.Controls.Add(this.btnRecruitment);
            this.panelMenu.Controls.Add(this.btnPersonnel);
            this.panelMenu.Controls.Add(this.btnHome);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 561);
            this.panelMenu.TabIndex = 0;
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
            this.btnLogout.IconSize = 30;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 515);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 10);
            this.btnLogout.Size = new System.Drawing.Size(200, 46);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Tag = "Đăng Xuất";
            this.btnLogout.Text = "Đăng Xuất";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
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
            this.btnSalaryCalculator.IconSize = 30;
            this.btnSalaryCalculator.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalaryCalculator.Location = new System.Drawing.Point(0, 304);
            this.btnSalaryCalculator.Name = "btnSalaryCalculator";
            this.btnSalaryCalculator.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSalaryCalculator.Size = new System.Drawing.Size(200, 46);
            this.btnSalaryCalculator.TabIndex = 6;
            this.btnSalaryCalculator.Tag = "Tiền Lương";
            this.btnSalaryCalculator.Text = "Tiền Lương";
            this.btnSalaryCalculator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalaryCalculator.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalaryCalculator.UseVisualStyleBackColor = true;
            this.btnSalaryCalculator.Click += new System.EventHandler(this.ChoiceTab);
            // 
            // btnPerformanceReview
            // 
            this.btnPerformanceReview.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPerformanceReview.FlatAppearance.BorderSize = 0;
            this.btnPerformanceReview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerformanceReview.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerformanceReview.ForeColor = System.Drawing.Color.White;
            this.btnPerformanceReview.IconChar = FontAwesome.Sharp.IconChar.Smile;
            this.btnPerformanceReview.IconColor = System.Drawing.Color.White;
            this.btnPerformanceReview.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPerformanceReview.IconSize = 30;
            this.btnPerformanceReview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPerformanceReview.Location = new System.Drawing.Point(0, 258);
            this.btnPerformanceReview.Name = "btnPerformanceReview";
            this.btnPerformanceReview.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPerformanceReview.Size = new System.Drawing.Size(200, 46);
            this.btnPerformanceReview.TabIndex = 5;
            this.btnPerformanceReview.Tag = "Đánh Giá";
            this.btnPerformanceReview.Text = "Đánh Giá";
            this.btnPerformanceReview.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPerformanceReview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPerformanceReview.UseVisualStyleBackColor = true;
            this.btnPerformanceReview.Click += new System.EventHandler(this.ChoiceTab);
            // 
            // btnTimekeeping
            // 
            this.btnTimekeeping.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTimekeeping.FlatAppearance.BorderSize = 0;
            this.btnTimekeeping.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimekeeping.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimekeeping.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnTimekeeping.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btnTimekeeping.IconColor = System.Drawing.Color.White;
            this.btnTimekeeping.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTimekeeping.IconSize = 30;
            this.btnTimekeeping.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimekeeping.Location = new System.Drawing.Point(0, 212);
            this.btnTimekeeping.Name = "btnTimekeeping";
            this.btnTimekeeping.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTimekeeping.Size = new System.Drawing.Size(200, 46);
            this.btnTimekeeping.TabIndex = 4;
            this.btnTimekeeping.Tag = "Chấm Công";
            this.btnTimekeeping.Text = "Chấm Công";
            this.btnTimekeeping.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimekeeping.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimekeeping.UseVisualStyleBackColor = true;
            this.btnTimekeeping.Click += new System.EventHandler(this.ChoiceTab);
            // 
            // btnRecruitment
            // 
            this.btnRecruitment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRecruitment.FlatAppearance.BorderSize = 0;
            this.btnRecruitment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecruitment.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecruitment.ForeColor = System.Drawing.Color.White;
            this.btnRecruitment.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.btnRecruitment.IconColor = System.Drawing.Color.White;
            this.btnRecruitment.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRecruitment.IconSize = 30;
            this.btnRecruitment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecruitment.Location = new System.Drawing.Point(0, 166);
            this.btnRecruitment.Name = "btnRecruitment";
            this.btnRecruitment.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnRecruitment.Size = new System.Drawing.Size(200, 46);
            this.btnRecruitment.TabIndex = 3;
            this.btnRecruitment.Tag = "Tuyển Dụng";
            this.btnRecruitment.Text = "Tuyển Dụng";
            this.btnRecruitment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecruitment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRecruitment.UseVisualStyleBackColor = true;
            this.btnRecruitment.Click += new System.EventHandler(this.ChoiceTab);
            // 
            // btnPersonnel
            // 
            this.btnPersonnel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPersonnel.FlatAppearance.BorderSize = 0;
            this.btnPersonnel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonnel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonnel.ForeColor = System.Drawing.Color.White;
            this.btnPersonnel.IconChar = FontAwesome.Sharp.IconChar.Person;
            this.btnPersonnel.IconColor = System.Drawing.Color.White;
            this.btnPersonnel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPersonnel.IconSize = 30;
            this.btnPersonnel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonnel.Location = new System.Drawing.Point(0, 120);
            this.btnPersonnel.Name = "btnPersonnel";
            this.btnPersonnel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPersonnel.Size = new System.Drawing.Size(200, 46);
            this.btnPersonnel.TabIndex = 2;
            this.btnPersonnel.Tag = "Nhân Sự";
            this.btnPersonnel.Text = "Nhân Sự";
            this.btnPersonnel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonnel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPersonnel.UseVisualStyleBackColor = true;
            this.btnPersonnel.Click += new System.EventHandler(this.ChoiceTab);
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
            this.btnHome.IconSize = 30;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 74);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(200, 46);
            this.btnHome.TabIndex = 1;
            this.btnHome.Tag = "Trang Chủ";
            this.btnHome.Text = "Trang Chủ";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.ChoiceTab);
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
            this.btnMenu.Location = new System.Drawing.Point(140, -3);
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
            this.panelTitleBar.Controls.Add(this.label1);
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.btnMaximize);
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(200, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(934, 57);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "DASHBOARD";
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
            this.btnMinimize.Location = new System.Drawing.Point(829, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(35, 20);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.Maximize;
            this.btnMaximize.IconColor = System.Drawing.Color.White;
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximize.IconSize = 15;
            this.btnMaximize.Location = new System.Drawing.Point(864, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(35, 20);
            this.btnMaximize.TabIndex = 3;
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
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
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(200, 57);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panelDesktop.Size = new System.Drawing.Size(934, 504);
            this.panelDesktop.TabIndex = 2;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 561);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1148, 594);
            this.Name = "Dashboard";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnMenu;
        private FontAwesome.Sharp.IconButton btnLogout;
        private FontAwesome.Sharp.IconButton btnSalaryCalculator;
        private FontAwesome.Sharp.IconButton btnPerformanceReview;
        private FontAwesome.Sharp.IconButton btnTimekeeping;
        private FontAwesome.Sharp.IconButton btnRecruitment;
        private FontAwesome.Sharp.IconButton btnPersonnel;
        private FontAwesome.Sharp.IconButton btnHome;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox logo;
    }
}

