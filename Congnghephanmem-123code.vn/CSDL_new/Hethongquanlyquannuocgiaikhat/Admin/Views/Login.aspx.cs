using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Admin_Views_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserName"] != null)
        {
            Response.Redirect("Default.aspx");
        }
    }
    protected void btnDangNhap_Click(object sender, EventArgs e)
    {
        if (txtTenDangNhap.Text == "")
        {
            lblError.Text = "Tên đăng nhập không được để trống !";
            txtTenDangNhap.Focus();
        }
        else
        {
            if (txtMatKhau.Text == "")
            {
                lblError.Text = "Mật khẩu không được để trống !";
                txtMatKhau.Focus();
            }
            else
            {
                XuLyNguoiDung xl = new XuLyNguoiDung();
                //NguoiDung obj = new NguoiDung(txtTenDangNhap.Text, txtMatKhau.Text);
                //DataTable dt = new DataTable();
                //dt = xl.CheckDangNhapAdmin(obj);
                //if (dt.Rows.Count <= 0)
                //{
                //    lblError.Text = "Tên đăng nhập hoặc mật khẩu không đúng";
                //}
                //else
                //{
                //    Session["UserName"] = dt.Rows[0]["UserName"].ToString();
                //    Session["DisplayName"] = dt.Rows[0]["DisplayName"].ToString();
                //    Response.Redirect("Default.aspx");
                ////}
                if (xl.checkAccount(txtTenDangNhap.Text, txtMatKhau.Text) == false)
                {
                    lblError.Text = "Tên đăng nhập hoặc mật khẩu không đúng. Vui lòng đăng nhập lại!";
                }
                else
                {
                    NguoiDung nl = xl.dl1;
                    Session["UserName"] = txtTenDangNhap.Text;
                    Session["DisplayName"] = nl.HoTen;
                    Response.Redirect("Default.aspx");
                }
            }
        }

    }
}