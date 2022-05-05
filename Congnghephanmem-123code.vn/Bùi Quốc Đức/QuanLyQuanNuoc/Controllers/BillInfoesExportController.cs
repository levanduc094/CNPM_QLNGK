using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using QuanLyQuanNuoc.Models;
using System.Web.UI.WebControls;
using System.IO;
using System.Web.UI;
//using System.Web.UI;

namespace QuanLyQuanNuoc.Controllers
{
    public class BillInfoesExportController : Controller
    {
        private CNPM_QLNGKEntities1 db = new CNPM_QLNGKEntities1();

        // GET: BillInfoesExport
        public ActionResult Index()
        {
            var billInfoes = db.BillInfoes.Include(b => b.Bill).Include(b => b.Drink).Include(b => b.Employee).Include(b => b.Food);
            return View(billInfoes.ToList());
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
        [HttpPost]
        public ActionResult ExportToExcel()
        {
            var gv = new GridView();
            gv.DataSource = db.BillInfoes.Include(b => b.Bill).Include(b => b.Drink).Include(b => b.Employee).Include(b => b.Food).ToList();
            gv.DataBind();
            Response.Clear();
            Response.Buffer = true;
            //Response.AddHeader("content-disposition",
            // "attachment;filename=GridViewExport.xls");
            Response.Charset = "utf-8";
            Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
            Response.AddHeader("content-disposition", "attachment;filename=GridViewExport.xls");
            //Mã hóa chữa sang UTF8
            Response.ContentEncoding = System.Text.Encoding.UTF8;
            Response.BinaryWrite(System.Text.Encoding.UTF8.GetPreamble());

            StringWriter sw = new StringWriter();
            HtmlTextWriter hw = new HtmlTextWriter(sw);

            for (int i = 0; i < gv.Rows.Count; i++)
            {
                //Apply text style to each Row
                gv.Rows[i].Attributes.Add("class", "textmode");
            }
            //Add màu nền cho header của file excel
            gv.HeaderRow.BackColor = System.Drawing.Color.DarkBlue;
            //Màu chữ cho header của file excel
            gv.HeaderStyle.ForeColor = System.Drawing.Color.White;

            gv.HeaderRow.Cells[0].Text = "Mã chi tiết hóa đơn";
            gv.HeaderRow.Cells[1].Text = "mã hóa đơn";
            gv.HeaderRow.Cells[2].Text = "Mã thức ăn";
            gv.HeaderRow.Cells[3].Text = "Số lượng thức ăn";
            gv.HeaderRow.Cells[4].Text = "Mã nhân viên";
            gv.HeaderRow.Cells[5].Text = "Số lượng đồ uống";
            gv.HeaderRow.Cells[6].Text = "Tổng tiền";
            gv.HeaderRow.Cells[7].Text = "Mã Đồ uống";



            gv.RenderControl(hw);

            Response.Output.Write(sw.ToString());
            Response.Flush();
            Response.End();
            return View("View");
        }
    }
}
