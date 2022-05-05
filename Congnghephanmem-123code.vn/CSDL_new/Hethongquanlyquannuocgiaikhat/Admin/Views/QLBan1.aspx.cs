using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Views_demo : System.Web.UI.Page
{
    QLQuanNuocGiaiKhatDataContext qlqn;
    private static bool mode;
    //khong dc mo
    protected void setcontrol(bool edit)
    {
        //txtTenChuyenMuc.Enabled = edit;
        ////txtTrangthai.Enabled = edit;
        //ckbStatus.Enabled = !edit;
        btnNew.Enabled = edit;
    }
    public void display()
    {
        qlqn = new QLQuanNuocGiaiKhatDataContext();
        var qlb = from item in qlqn.Tables
                  select item;
        gvChuyenMuc.DataSource = qlb;
        gvChuyenMuc.DataBind();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        display();
        //setcontrol(true);
    }
    protected void gvChuyenMuc_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int row = Convert.ToInt32(e.CommandArgument);
        if (mode==true)
        {
            qlqn = new QLQuanNuocGiaiKhatDataContext();
            Table tb = new Table();
            tb.name = txtTenChuyenMuc.ToString();
            tb.status = ckbStatus.Checked;
            qlqn.SubmitChanges();
            Console.Write(ckbStatus.Checked);
            
        }
        if (e.CommandName == "btnSua")
        {
            txtMaChuyenMuc.Text = gvChuyenMuc.Rows[row].Cells[0].Text;
            txtTenChuyenMuc.Text =HttpUtility.HtmlDecode((string) (gvChuyenMuc.Rows[row].Cells[1].Text));
            //txtTrangthai.Text = gvChuyenMuc.Rows[row].Cells[2].Text;
            Table tb = new Table();
            tb.name = txtTenChuyenMuc.ToString();
            tb.status = ckbStatus.Checked;
            qlqn.SubmitChanges();
           
        }
        else if (e.CommandName == "btnXoa")
        {
            string s = gvChuyenMuc.Rows[row].Cells[0].Text;
            qlqn = new QLQuanNuocGiaiKhatDataContext();
            var qlb = from item in qlqn.Tables
                      where item.idTable == Convert.ToInt32(s)
                      select item;
            Table ban = qlb.First();
            if (qlb != null)
            {               
                qlqn.Tables.DeleteOnSubmit(ban);                
                qlqn.SubmitChanges();
                lblError.Text = "Xóa thành công !";
                display();
            }
            mode = false;
        }
    }
    protected void btnSaveChanges_Click(object sender, EventArgs e)
    {
        if (txtTenChuyenMuc.Text.Trim() == "") return;
        qlqn = new QLQuanNuocGiaiKhatDataContext();
        if (mode==true)
        {
            Table ban = new Table();
            ban.name = txtTenChuyenMuc.Text;
            if (ckbStatus.Checked==true)
            {
                ban.status = true;
            }
            else
            {
                ban.status = false;
            }
            qlqn.Tables.InsertOnSubmit(ban);
            qlqn.SubmitChanges();
            lblError.Text = "Thêm thành công !";
            display();
        }
        else
        {
            var qlb = from item in qlqn.Tables
                      where item.idTable == Convert.ToInt32(txtMaChuyenMuc.Text)
                      select item;
            Table ban = qlb.First();
            ban.name = txtTenChuyenMuc.Text;
            if (ckbStatus.Checked == true)
            {
                ban.status = true;
            }
            else
            {
                ban.status = false;
            }
            qlqn.SubmitChanges();
            lblError.Text = "Sửa thành công !";
            display();
        }       
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("demo.aspx");
    }
    protected void btnNew_Click(object sender, EventArgs e)
    {
        mode = true;
        setcontrol(false);
        txtMaChuyenMuc.Text = "";
        txtTenChuyenMuc.Text = "";
       
    }  
}