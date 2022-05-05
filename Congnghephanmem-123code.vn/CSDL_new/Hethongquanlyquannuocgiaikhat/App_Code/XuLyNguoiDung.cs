using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

public class XuLyNguoiDung
{
    DuLieu dl = new DuLieu();
    public NguoiDung dl1;
    QLQuanNuocGiaiKhatDataContext ql;
    public XuLyNguoiDung()
    {
        ql = new QLQuanNuocGiaiKhatDataContext();
    }
    //public DataTable ListNguoiDung()
    //{
    //    SqlParameter[] sqlParams = { };
    //    return dl.Select("SELECT * FROM Account", sqlParams);
    //}
    //public DataTable ListNguoiDungActive()
    //{
    //    SqlParameter[] sqlParams = { };
    //    return dl.Select("SELECT * FROM Account WHERE Type = 1", sqlParams);
    //}
    //public DataTable GetNguoiDung(string id)
    //{
    //    SqlParameter idnd = new SqlParameter("@UserName", id);
    //    SqlParameter[] sqlParams = { idnd };
    //    return dl.Select("SELECT * FROM Account WHERE UserName = @UserName", sqlParams);
    //}
    //public DataTable CheckDangNhap(NguoiDung obj)
    //{
    //    SqlParameter tdn = new SqlParameter("@UserName", obj.TenDangNhap);
    //    SqlParameter mk = new SqlParameter("@Password", obj.MatKhau);
    //    SqlParameter[] sqlParams = { tdn, mk };
    //    return dl.Select("SELECT * FROM Account WHERE UserName = @UserName AND Password =@Password AND Type=1", sqlParams);
    //}
    //public DataTable CheckDangNhapAdmin(NguoiDung obj)
    //{
    //    SqlParameter tdn = new SqlParameter("@UserName", obj.TenDangNhap);
    //    SqlParameter mk = new SqlParameter("@Password", obj.MatKhau);
    //    SqlParameter[] sqlParams = { tdn, mk };
    //    return dl.Select("SELECT * FROM Account WHERE UserName = @UserName AND Password =@Password AND Type=1 ", sqlParams);
    //}
    //public int ThemNguoiDung(NguoiDung obj)
    //{
    //    SqlParameter mcm = new SqlParameter("@UserName", obj.TenDangNhap);
    //    SqlParameter tcm = new SqlParameter("@PassWord", obj.MatKhau);
    //    SqlParameter tht = new SqlParameter("@DisplayName", obj.HoTen);
    //    SqlParameter type = new SqlParameter("@Type", obj.Type);
    //    SqlParameter[] sqlParams = { mcm, tcm,tht,type };
    //    return dl.SaveChanges("INSERT INTO [dbo].[Account]([UserName],[PassWord],[DisplayName],[Type]) VALUES(@UserName,@PassWord,@DisplayName,@Type)", sqlParams);
    //}
    //public int SuaNguoiDung(NguoiDung obj)
    //{
    //    SqlParameter mcm = new SqlParameter("@UserName", obj.TenDangNhap);
    //    SqlParameter tcm = new SqlParameter("@PassWord", obj.MatKhau);
    //    SqlParameter tht = new SqlParameter("@DisplayName", obj.HoTen);
    //    SqlParameter type = new SqlParameter("@Type", obj.Type);
    //    SqlParameter[] sqlParams = { mcm, tcm, tht, type };
    //    return dl.SaveChanges("UPDATE Account SET UserName = @UserName,PassWord = @PassWord, DisplayName = @DisplayName,Type = @Type WHERE UserName = @UserName", sqlParams);
    //}
    //public int XoaNguoiDung(string id)
    //{
    //    SqlParameter idnd = new SqlParameter("@UserName", id);
    //    SqlParameter[] sqlParams = { idnd };
    //    return dl.SaveChanges("DELETE FROM Account WHERE UserName = @UserName", sqlParams);
    //}
    public bool checkAccount(string user, string pass)
    {

        var sql = from item in ql.Accounts
                  where item.Username == user && item.Password == pass
                  select item;
        if (sql.Count()>0)
        {
            Account ac = sql.First();
            dl1 = new NguoiDung(ac.Username, ac.Password, ac.DisplayName, ac.Type);
            return true;
        }
        return false;
    }
}
