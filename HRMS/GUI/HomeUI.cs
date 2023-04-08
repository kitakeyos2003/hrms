using HRMS.BUS;
using HRMS.DAL.Models;
using RestSharp;
using System.Net;
using System.Windows.Forms;

namespace HRMS.GUI
{
    public partial class HomeUI : Form
    {
        private Panel panel;
        HomeService service;
        public HomeUI(Panel panel)
        {
            service = new HomeService();
            this.panel = panel;
            InitializeComponent();
            this.BackColor = panel.BackColor;
            Init();
        }


        private void Init()
        {
            RestResponse<Home> res = service.GetInfo();
            if (res.StatusCode == HttpStatusCode.OK)
            {
                lbTotalEmployees.Text = res.Data.TotalEmployees.ToString("N0");
                lbNewEmployeesThisMonth.Text = res.Data.NewEmployeesThisMonth.ToString("N0");
                lbNewEmployeesLastMonth.Text = res.Data.NewEmployeesLastMonth.ToString("N0");
                lbSuccessfulProbationThisMonth.Text = res.Data.SuccessfulProbationThisMonth.ToString("N0");
                lbSuccessfulProbationLastMonth.Text = res.Data.SuccessfulProbationLastMonth.ToString("N0");
                lbResignedThisMonth.Text = res.Data.ResignedThisMonth.ToString("N0");
                lbResignedLastMonth.Text = res.Data.ResignedLastMonth.ToString("N0");
                ibNewEmployeesPercentChange.Text = (((res.Data.NewEmployeesThisMonth - res.Data.NewEmployeesLastMonth) / res.Data.NewEmployeesLastMonth) * 100) + "%";
                ibSuccessfulProbationPercentChange.Text = (((res.Data.SuccessfulProbationThisMonth - res.Data.SuccessfulProbationLastMonth) / res.Data.SuccessfulProbationLastMonth) * 100) + "%";
                ibResignedPercentChange.Text = (((res.Data.ResignedThisMonth - res.Data.ResignedLastMonth) / res.Data.ResignedLastMonth) * 100) + "%";
            }
        }
    }
}
