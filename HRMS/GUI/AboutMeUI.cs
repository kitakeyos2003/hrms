using HRMS.DAL.Models;
using RestSharp;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HRMS.GUI
{
    public partial class AboutMeUI : Form
    {
        private Panel panel;
        public AboutMeUI(Panel panel)
        {
            this.panel = panel;
            InitializeComponent();
            this.BackColor = panel.BackColor;
            SetInfo();
        }


        private void SetInfo()
        {
            string version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            txtVersion.Text = string.Format("Phiên bản {0}", version);
            var client = new RestClient(ApplicationConfig.BASE_URL);
            client.AddDefaultHeader("Content-Type", "application/json");
            var request = new RestRequest("/version", Method.Get);
            var response = client.Execute<Version>(request);
            Version v = response.Data;
            if (v != null)
            {
                if (version.Equals(v.VersionNumber))
                {
                    title.Text = "Bạn đang dùng phiên bản mới nhất";
                } else
                {
                    title.Text = string.Format("Đã có phiên bản mới:  {0}", v.VersionNumber);
                }
                lbDescription.Text = v.Description;
                string contact = "";
                if (v.PhoneNumber != null)
                {
                    contact = string.Format("Số điện thoại:  {0}", v.PhoneNumber);
                }
                if (v.Email != null)
                {
                    if (v.PhoneNumber != null)
                    {
                        contact += "\n";
                    }
                    contact += string.Format("Email:  {0}", v.Email);
                }
                lbContact.Text = contact;
            }

        }
    }
}