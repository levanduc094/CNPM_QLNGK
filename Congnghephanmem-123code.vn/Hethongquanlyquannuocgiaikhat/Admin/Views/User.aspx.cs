using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Views_User : System.Web.UI.Page
{
    private void LoadChuyenMuc()
    {
        XuLyNguoiDung xl = new XuLyNguoiDung();
        gvChuyenMuc.DataSource = xl.ListNguoiDung();
        gvChuyenMuc.DataBind();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        lblError.Text = "";
        if (!IsPostBack)
        {
            LoadChuyenMuc();
            if (Request.QueryString["Action"] != null)
            {
                if (Request.QueryString["Action"] == "Add" || Request.QueryString["Action"] == "Edit")
                {
                    pnlThem.Visible = true;
                    txtMaChuyenMuc.Enabled = true;
                    btnThemChuyenMuc.Visible = false;
                    if (Request.QueryString["Action"] == "Edit")
                    {                        
                        btnSave.Visible = false;
                        string id = Request.QueryString["ID"];
                        XuLyNguoiDung xl = new XuLyNguoiDung();
                        DataTable dt = xl.GetNguoiDung(id);
                        txtMaChuyenMuc.Text = dt.Rows[0]["UserName"].ToString();
                        txtTenChuyenMuc.Text = dt.Rows[0]["PassWord"].ToString();
                        TxtDisplayName.Text = dt.Rows[0]["DisplayName"].ToString();
                        TxtType.Text = dt.Rows[0]["Type"].ToString();
                    }
                }
            }
            else
            {
                pnlThem.Visible = false;
                btnThemChuyenMuc.Visible = true;
            }
        }
    }
    private void EnableThem()
    {
        txtMaChuyenMuc.Text = "";
        txtTenChuyenMuc.Text = "";
        TxtDisplayName.Text = "";
        TxtType.Text = "";
        txtMaChuyenMuc.Focus();
    }
    protected void btnThemChuyenMuc_Click(object sender, EventArgs e)
    {
        Response.Redirect("User.aspx?Action=Add");
        EnableThem();
    }
    protected void btnXoa_Click(object sender, EventArgs e)
    {
        LinkButton b = (LinkButton)sender;
        if (b.CommandName == "Delete")
        {
            XuLyNguoiDung xl = new XuLyNguoiDung();
            string id = b.CommandArgument;
            xl.XoaNguoiDung(id);
            LoadChuyenMuc();
        }
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        int type = Convert.ToInt32(TxtType.Text);
        NguoiDung obj = new NguoiDung(txtMaChuyenMuc.Text, txtTenChuyenMuc.Text,TxtDisplayName.Text,type);
        XuLyNguoiDung xl = new XuLyNguoiDung();
        int result = xl.ThemNguoiDung(obj);
        if (result <= 0)
        {
            lblError.ForeColor = Color.Red;
            lblError.Text = "Thêm người dùng không thành công. Vui lòng kiểm tra lại dữ liệu";
        }
        else
        {
            lblError.ForeColor = Color.Blue;
            lblError.Text = "Thêm dữ liệu thành công";
            LoadChuyenMuc();
        }
    }
    protected void btnSaveChanges_Click(object sender, EventArgs e)
    {
        if (Request.QueryString["Action"] == "Edit")
        {
            int type = Convert.ToInt32(TxtType.Text);
            NguoiDung obj = new NguoiDung(txtMaChuyenMuc.Text, txtTenChuyenMuc.Text,TxtDisplayName.Text,type);
            XuLyNguoiDung xl = new XuLyNguoiDung();
            int result = xl.SuaNguoiDung(obj);
            if (result <= 0)
            {
                lblError.ForeColor = Color.Red;
                lblError.Text = "Sửa dữ liệu không thành công. Vui lòng kiểm tra lại dữ liệu";
            }
            else
            {
                lblError.ForeColor = Color.Blue;
                lblError.Text = "Sửa dữ liệu thành công";
            }

            LoadChuyenMuc();
        }
        else
        {
            btnSave_Click(sender, e);
        }
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("User.aspx");
    }
}