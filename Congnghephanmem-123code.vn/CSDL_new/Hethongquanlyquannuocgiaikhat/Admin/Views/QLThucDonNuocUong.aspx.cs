using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Views_QLThucDonNuocUong : System.Web.UI.Page
{
    QLQuanNuocGiaiKhatDataContext qlqn;
    private static bool mode;

    public void display()
    {
        qlqn = new QLQuanNuocGiaiKhatDataContext();
        var qlb = from item in qlqn.Drinks
                  select item;
        gvChuyenMuc.DataSource = qlb;
        gvChuyenMuc.DataBind();
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        qlqn = new QLQuanNuocGiaiKhatDataContext();
        var ds = from item in qlqn.DrinkCategories
                 select item;
        DropListMaLoai.DataSource = ds;
        DropListMaLoai.DataValueField = "idCategoryDrink";
        DropListMaLoai.DataTextField = "name";
        DropListMaLoai.DataBind();
        display();
    }
    
    protected void btnNew_Click(object sender, EventArgs e)
    {
        mode = true;
        txtTenChuyenMuc.Enabled = true;
        DropListMaLoai.Enabled = true;
        TxtGia.Enabled = true;
        txtTenChuyenMuc.Text = "";
        TxtGia.Text = "";
    }
    protected void btnSaveChanges_Click(object sender, EventArgs e)
    {
        if (txtTenChuyenMuc.Text.Trim() == "") return;
        qlqn = new QLQuanNuocGiaiKhatDataContext();
        if (mode == true)
        {
            Drink fc = new Drink();
            fc.name = txtTenChuyenMuc.Text;
            fc.idCategoryDrink = Convert.ToInt32(DropListMaLoai.SelectedValue.ToString());
            fc.price = Convert.ToInt32(TxtGia.Text);
            qlqn.Drinks.InsertOnSubmit(fc);
            qlqn.SubmitChanges();
            lblError.Text = "Thêm thành công !";
            txtTenChuyenMuc.Enabled = false;
            DropListMaLoai.Enabled = false;
            TxtGia.Enabled = false;
            display();
        }
        else
        {
            var qlb = from item in qlqn.Drinks
                      where item.idDrink == Convert.ToInt32(txtMaChuyenMuc.Text)
                      select item;
            Drink fc = qlb.First();
            fc.name = txtTenChuyenMuc.Text;
            fc.idCategoryDrink = Convert.ToInt32(DropListMaLoai.SelectedValue.ToString());
            fc.price = Convert.ToInt32(TxtGia.Text);
            qlqn.SubmitChanges();
            lblError.Text = "Sửa thành công !";
            txtTenChuyenMuc.Enabled = false;
            DropListMaLoai.Enabled = false;
            TxtGia.Enabled = false;
            display();
        }   
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
          Response.Redirect("QLThucDonNuocUong.aspx");    
    }
    protected void gvChuyenMuc_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int row = Convert.ToInt32(e.CommandArgument);
        if (e.CommandName == "btnSua")
        {            
            txtTenChuyenMuc.Enabled = true;
            DropListMaLoai.Enabled = true;
            TxtGia.Enabled = true;
            txtMaChuyenMuc.Text = gvChuyenMuc.Rows[row].Cells[0].Text;
            txtTenChuyenMuc.Text = HttpUtility.HtmlDecode((string)gvChuyenMuc.Rows[row].Cells[1].Text);
            DropListMaLoai.SelectedValue = gvChuyenMuc.Rows[row].Cells[2].Text;
            TxtGia.Text = gvChuyenMuc.Rows[row].Cells[3].Text;
        }
        else if (e.CommandName == "btnXoa")
        {
            string s = gvChuyenMuc.Rows[row].Cells[0].Text;
            qlqn = new QLQuanNuocGiaiKhatDataContext();
            var qlb = from item in qlqn.Drinks
                      where item.idDrink == Convert.ToInt32(s)
                      select item;
            Drink fc = qlb.First();
            if (qlb != null)
            {
                qlqn.Drinks.DeleteOnSubmit(fc);
                qlqn.SubmitChanges();
                lblError.Text = "Xóa thành công !";
                display();
            }
        }
    }
}