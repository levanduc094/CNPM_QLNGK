using Microsoft.Reporting.WebForms;
using QuanLyQuanNuoc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuanLyQuanNuoc.Views.Shared
{
    public partial class WebUserControl1 : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Employee> books = null;
                using (CNPM_QLNGKEntities1 db = new CNPM_QLNGKEntities1())
                {
                    books = db.Employees.OrderBy(s => s.idEmp).ToList();
                    ReportViewer1.LocalReport.DataSources.Clear();
                    ReportDataSource rdc = new ReportDataSource("DataSet1", books);
                    ReportViewer1.LocalReport.DataSources.Add(rdc);
                    double sumLineTotal = (double)db.BillInfoes.Sum(od => od.totalPrice);
                    ReportParameter p4 = new ReportParameter("sumprice", sumLineTotal.ToString());
                    ReportViewer1.LocalReport.SetParameters(new ReportParameter[] { p4 });
                    ReportViewer1.LocalReport.Refresh();
                }
            }
        }
    }
}
    