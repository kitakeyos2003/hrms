namespace HRMS.GUI
{
    partial class UpdateSalaryUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateSalaryUI));
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnUpdate = new RJCodeAdvance.RJControls.RJButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cbPaymentMethod = new RJCodeAdvance.RJControls.RJComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dpPaymentDate = new RJCodeAdvance.RJControls.RJDatePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSalaryID = new RJCodeAdvance.RJControls.RJTextBox();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(188, 25);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(400, 171);
            this.panel5.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnUpdate);
            this.panel3.Location = new System.Drawing.Point(204, 104);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(158, 59);
            this.panel3.TabIndex = 8;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnUpdate.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnUpdate.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnUpdate.BorderRadius = 0;
            this.btnUpdate.BorderSize = 0;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(3, 23);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(150, 31);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.TextColor = System.Drawing.Color.White;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.cbPaymentMethod);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Location = new System.Drawing.Point(40, 104);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(158, 59);
            this.panel6.TabIndex = 7;
            // 
            // cbPaymentMethod
            // 
            this.cbPaymentMethod.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbPaymentMethod.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbPaymentMethod.BorderSize = 1;
            this.cbPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbPaymentMethod.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPaymentMethod.ForeColor = System.Drawing.Color.DimGray;
            this.cbPaymentMethod.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbPaymentMethod.Items.AddRange(new object[] {
            "Tiền mặt",
            "Ngân hàng"});
            this.cbPaymentMethod.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbPaymentMethod.ListTextColor = System.Drawing.Color.DimGray;
            this.cbPaymentMethod.Location = new System.Drawing.Point(4, 25);
            this.cbPaymentMethod.MaximumSize = new System.Drawing.Size(150, 31);
            this.cbPaymentMethod.MinimumSize = new System.Drawing.Size(150, 31);
            this.cbPaymentMethod.Name = "cbPaymentMethod";
            this.cbPaymentMethod.Padding = new System.Windows.Forms.Padding(1);
            this.cbPaymentMethod.Size = new System.Drawing.Size(150, 31);
            this.cbPaymentMethod.TabIndex = 0;
            this.cbPaymentMethod.Texts = "";
            // 
            // label7
            // 
            this.label7.AllowDrop = true;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "P.thức thanh toán";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dpPaymentDate);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Location = new System.Drawing.Point(204, 39);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(158, 59);
            this.panel7.TabIndex = 6;
            // 
            // dpPaymentDate
            // 
            this.dpPaymentDate.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dpPaymentDate.BorderSize = 0;
            this.dpPaymentDate.CalendarFont = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpPaymentDate.CustomFormat = "dd/MM/yyyy";
            this.dpPaymentDate.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpPaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpPaymentDate.Location = new System.Drawing.Point(4, 24);
            this.dpPaymentDate.MaximumSize = new System.Drawing.Size(150, 31);
            this.dpPaymentDate.MinimumSize = new System.Drawing.Size(150, 31);
            this.dpPaymentDate.Name = "dpPaymentDate";
            this.dpPaymentDate.Size = new System.Drawing.Size(150, 31);
            this.dpPaymentDate.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.dpPaymentDate.TabIndex = 0;
            this.dpPaymentDate.TextColor = System.Drawing.Color.White;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ngày thanh toán";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.White;
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(188, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(400, 25);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
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
            this.btnMinimize.Location = new System.Drawing.Point(331, 0);
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
            this.btnClose.Location = new System.Drawing.Point(365, 0);
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
            this.panel1.Size = new System.Drawing.Size(188, 196);
            this.panel1.TabIndex = 2;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtSalaryID);
            this.panel2.Location = new System.Drawing.Point(40, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(158, 59);
            this.panel2.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã lương";
            // 
            // txtSalaryID
            // 
            this.txtSalaryID.BackColor = System.Drawing.SystemColors.Window;
            this.txtSalaryID.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtSalaryID.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSalaryID.BorderRadius = 0;
            this.txtSalaryID.BorderSize = 1;
            this.txtSalaryID.Enabled = false;
            this.txtSalaryID.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalaryID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSalaryID.Location = new System.Drawing.Point(4, 24);
            this.txtSalaryID.Margin = new System.Windows.Forms.Padding(4);
            this.txtSalaryID.MaximumSize = new System.Drawing.Size(150, 31);
            this.txtSalaryID.MinimumSize = new System.Drawing.Size(150, 31);
            this.txtSalaryID.Multiline = false;
            this.txtSalaryID.Name = "txtSalaryID";
            this.txtSalaryID.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSalaryID.PasswordChar = false;
            this.txtSalaryID.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSalaryID.PlaceholderText = "";
            this.txtSalaryID.Size = new System.Drawing.Size(150, 31);
            this.txtSalaryID.TabIndex = 0;
            this.txtSalaryID.Texts = "";
            this.txtSalaryID.UnderlinedStyle = true;
            // 
            // UpdateSalaryUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 196);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateSalaryUI";
            this.Text = "Cập nhật lương";
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private RJCodeAdvance.RJControls.RJButton btnUpdate;
        private System.Windows.Forms.Panel panel6;
        private RJCodeAdvance.RJControls.RJComboBox cbPaymentMethod;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel7;
        private RJCodeAdvance.RJControls.RJDatePicker dpPaymentDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private RJCodeAdvance.RJControls.RJTextBox txtSalaryID;
    }
}