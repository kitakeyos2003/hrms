using HRMS.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMS.GUI.alert
{
    public partial class Alert : Form
    {
        private EnumAction action;
        private int x, y;
        public Alert()
        {
            InitializeComponent();
        }

        public void ShowAlert(string message, EnumType type)
        {
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            string fname;
            for (int i = 1; i < 10; i++)
            {
                fname = "alert" + i.ToString();
                Alert alert = (Alert)Application.OpenForms[fname];
                if (alert == null)
                {
                    this.Name = fname;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i  - 5 * i;
                    this.Location = new Point(x, y);
                    break;
                }
            }
            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;

            switch (type)
            {
                case EnumType.SUCCESS:
                    this.pictureBox1.Image = Resources.success;
                    this.BackColor = Color.SeaGreen;
                    break;
                case EnumType.ERROR:
                    this.pictureBox1.Image = Resources.error;
                    this.BackColor = Color.DarkRed;
                    break;
                case EnumType.INFO:
                    this.pictureBox1.Image = Resources.info;
                    this.BackColor = Color.RoyalBlue;
                    break;
                case EnumType.WARNING:
                    this.pictureBox1.Image = Resources.warning;
                    this.BackColor = Color.DarkOrange;
                    break;
            }

            this.lblMsg.Text = message;
            this.Show();
            this.action = EnumAction.START;
            this.timer.Interval = 1;
            timer.Start();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            timer.Interval = 1;
            action = EnumAction.CLOSE;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            switch (this.action)
            {
                case EnumAction.WAIT:
                    timer.Interval = 5000;
                    action = EnumAction.CLOSE;
                    break;
                case EnumAction.START:
                    this.timer.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.x < this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if (this.Opacity == 1.0)
                        {
                            action = EnumAction.WAIT;
                        }
                    }
                    break;
                case EnumAction.CLOSE:
                    timer.Interval = 1;
                    this.Opacity -= 0.1;

                    this.Left -= 3;
                    if (base.Opacity == 0.0)
                    {
                        base.Close();
                    }
                    break;
            }
        }

        public enum EnumAction
        {
            WAIT, START, CLOSE
        }

        public enum EnumType
        {
            SUCCESS,
            WARNING,
            ERROR,
            INFO
        }
    }
}
