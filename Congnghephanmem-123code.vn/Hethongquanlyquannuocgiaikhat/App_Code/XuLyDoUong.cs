using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


public class XuLyDoUong
{
    DuLieu dl = new DuLieu();
    public DataTable ListChuyenMuc()
    {
        SqlParameter[] sqlParams = { };
        return dl.Select("SELECT * FROM DrinkCategory", sqlParams);
    }
    public DataTable ListChuyenMucActive()
    {
        SqlParameter[] sqlParams = { };
        return dl.Select("SELECT * FROM DrinkCategory WHERE idCategoryDrink", sqlParams);
    }
    public DataTable GetChuyenMuc(int maChuyenMuc)
    {
        SqlParameter mcm = new SqlParameter("@idCategoryDrink", maChuyenMuc);
        SqlParameter[] sqlParams = { mcm };
        return dl.Select("SELECT * FROM DrinkCategory WHERE idCategoryDrink = @idCategoryDrink", sqlParams);
    }
    public int ThemChuyenMuc(DoUong obj)
    {
        SqlParameter mcm = new SqlParameter("@idCategoryDrink", obj.MaChuyenMuc);
        SqlParameter tcm = new SqlParameter("@Name", obj.TenChuyenMuc);
        SqlParameter[] sqlParams = { mcm, tcm };
        return dl.SaveChanges("INSERT INTO [dbo].[DrinkCategory]([idCategoryDrink],[Name]) VALUES(@idCategoryDrink,@Name)", sqlParams);
    }
    public int SuaChuyenMuc(DoUong obj)
    {
        SqlParameter mcm = new SqlParameter("@idCategoryDrink", obj.MaChuyenMuc);
        SqlParameter tcm = new SqlParameter("@Name", obj.TenChuyenMuc);
        SqlParameter[] sqlParams = { mcm, tcm };
        return dl.SaveChanges("UPDATE DrinkCategory SET Name = @Name WHERE idCategoryDrink = @idCategoryDrink", sqlParams);
    }
    public int XoaChuyenMuc(int maChuyenMuc)
    {
        SqlParameter mcm = new SqlParameter("@idCategoryDrink", maChuyenMuc);
        SqlParameter[] sqlParams = { mcm };
        return dl.SaveChanges("DELETE FROM DrinkCategory WHERE idCategoryDrink = @idCategoryDrink", sqlParams);
    }

}