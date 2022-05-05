using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Views_QLDanhmucMonAn : System.Web.UI.Page
{
    QLQuanNuocGiaiKhatDataContext qlqn;
    private static bool mode;    
    public void display()
    {
        qlqn = new QLQuanNuocGiaiKhatDataContext();
        var qlb = from item in qlqn.FoodCategories
                  select item;
        gvChuyenMuc.DataSource = qlb;
        gvChuyenMuc.DataBind();
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        display();
    }
    protected void btnNew_Click(object sender, EventArgs e)
    {
        mode = true;
        txtMaChuyenMuc.Enabled = true;
        txtTenChuyenMuc.Enabled = true;
        txtMaChuyenMuc.Text = "";
        txtTenChuyenMuc.Text = "";        
    }
    protected void btnSaveChanges_Click(object sender, EventArgs e)
    {
        if (txtTenChuyenMuc.Text.Trim() == "") return;
        qlqn = new QLQuanNuocGiaiKhatDataContext();
        if (mode==true)
        {
            FoodCategory fc = new FoodCategory();
            fc.idCategoryFood = Convert.ToInt32( txtMaChuyenMuc.Text);
            fc.name = txtTenChuyenMuc.Text;            
            qlqn.FoodCategories.InsertOnSubmit(fc);
            qlqn.SubmitChanges();
            lblError.Text = "Thêm thành công !";
            txtMaChuyenMuc.Enabled = false;
            txtTenChuyenMuc.Enabled = false;
            display();
        }
        else
        {
            var qlb = from item in qlqn.FoodCategories
                      where item.idCategoryFood == Convert.ToInt32(txtMaChuyenMuc.Text)
                      select item;
            FoodCategory fc = qlb.First();            
            fc.name = txtTenChuyenMuc.Text;            
            qlqn.SubmitChanges();
            lblError.Text = "Sửa thành công !";
            txtMaChuyenMuc.Enabled = false;
            txtTenChuyenMuc.Enabled = false;
            display();
        }   
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("QLDanhmucMonAn.aspx");
    }
    protected void gvChuyenMuc_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int row = Convert.ToInt32(e.CommandArgument);
        if (e.CommandName == "btnSua")
        {
            txtMaChuyenMuc.Enabled = false;
            txtTenChuyenMuc.Enabled = true;
            txtMaChuyenMuc.Text = gvChuyenMuc.Rows[row].Cells[0].Text;
            txtTenChuyenMuc.Text = gvChuyenMuc.Rows[row].Cells[1].Text;            
        }
        else if (e.CommandName == "btnXoa")
        {
            string s = gvChuyenMuc.Rows[row].Cells[0].Text;
            qlqn = new QLQuanNuocGiaiKhatDataContext();
            var qlb = from item in qlqn.FoodCategories
                      where item.idCategoryFood == Convert.ToInt32(s)
                      select item;
            FoodCategory fc = qlb.First();
            if (qlb != null)
            {
                qlqn.FoodCategories.DeleteOnSubmit(fc);
                qlqn.SubmitChanges();
                lblError.Text = "Xóa thành công !";
                display();
            }
        }
    }
}