using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


public class XuLyBan
{
    //DuLieu dl = new DuLieu();
    //public DataTable ListChuyenMuc()
    //{
    //    SqlParameter[] sqlParams = { };
    //    return dl.Select("SELECT * FROM TableFood", sqlParams);
    //}
    //public DataTable ListChuyenMucActive()
    //{
    //    SqlParameter[] sqlParams = { };
    //    return dl.Select("SELECT * FROM TableFood WHERE idTable", sqlParams);
    //}
    //public DataTable GetChuyenMuc(int maChuyenMuc)
    //{
    //    SqlParameter mcm = new SqlParameter("@idTable", maChuyenMuc);
    //    SqlParameter[] sqlParams = { mcm };
    //    return dl.Select("SELECT * FROM TableFood WHERE idTable = @idTable", sqlParams);
    //}
    //public int ThemChuyenMuc(BanAn obj)
    //{        
    //    SqlParameter tcm = new SqlParameter("@Name", obj.TenBan);
    //    SqlParameter tt = new SqlParameter("@status", obj.TrangThai);
    //    SqlParameter[] sqlParams = { tcm, tt };
    //    return dl.SaveChanges("INSERT INTO [dbo].[TableFood]([Name],[status]) VALUES(@Name,@status)", sqlParams);
    //}
    //public int SuaChuyenMuc(BanAn obj)
    //{
    //    SqlParameter mcm = new SqlParameter("@idTable", obj.MaBan);
    //    SqlParameter tcm = new SqlParameter("@Name", obj.TenBan);
    //    SqlParameter tt = new SqlParameter("@status", obj.TrangThai);
    //    SqlParameter[] sqlParams = { mcm, tcm ,tt};
    //    return dl.SaveChanges("UPDATE TableFood SET name = @Name,status=@status WHERE idTable = @idTable", sqlParams);
    //}
    //public int XoaChuyenMuc(int maChuyenMuc)
    //{
    //    SqlParameter mcm = new SqlParameter("@idTable", maChuyenMuc);
    //    SqlParameter[] sqlParams = { mcm };
    //    return dl.SaveChanges("DELETE FROM TableFood WHERE idTable = @idTable", sqlParams);
    //}

}