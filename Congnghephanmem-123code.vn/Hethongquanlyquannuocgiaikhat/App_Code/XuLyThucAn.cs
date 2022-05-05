using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

public class XuLyChuyenMuc
{
    DuLieu dl = new DuLieu();
    public DataTable ListChuyenMuc()
    {
        SqlParameter[] sqlParams = { };
        return dl.Select("SELECT * FROM FoodCategory", sqlParams);
    }
    public DataTable ListChuyenMucActive()
    {
        SqlParameter[] sqlParams = { };
        return dl.Select("SELECT * FROM FoodCategory WHERE idCategoryFood", sqlParams);
    }
    public DataTable GetChuyenMuc(int maChuyenMuc)
    {
        SqlParameter mcm = new SqlParameter("@idCategoryFood", maChuyenMuc);
        SqlParameter[] sqlParams = { mcm };
        return dl.Select("SELECT * FROM FoodCategory WHERE idCategoryFood = @idCategoryFood", sqlParams);
    }
    public int ThemChuyenMuc(ChuyenMuc obj)
    {
        SqlParameter mcm = new SqlParameter("@idCategoryFood", obj.MaChuyenMuc);
        SqlParameter tcm = new SqlParameter("@Name", obj.TenChuyenMuc);        
        SqlParameter[] sqlParams = { mcm,tcm };
        return dl.SaveChanges("INSERT INTO [dbo].[FoodCategory]([idCategoryFood],[Name]) VALUES(@idCategoryFood,@Name)", sqlParams);
    }
    public int SuaChuyenMuc(ChuyenMuc obj)
    {
        SqlParameter mcm = new SqlParameter("@idCategoryFood", obj.MaChuyenMuc);
        SqlParameter tcm = new SqlParameter("@Name", obj.TenChuyenMuc);                
        SqlParameter[] sqlParams = { mcm, tcm};
        return dl.SaveChanges("UPDATE FoodCategory SET Name = @Name WHERE idCategoryFood = @idCategoryFood", sqlParams);
    }
    public int XoaChuyenMuc(int maChuyenMuc)
    {
        SqlParameter mcm = new SqlParameter("@idCategoryFood", maChuyenMuc);
        SqlParameter[] sqlParams = { mcm };
        return dl.SaveChanges("DELETE FROM FoodCategory WHERE idCategoryFood = @idCategoryFood", sqlParams);
    }
}
