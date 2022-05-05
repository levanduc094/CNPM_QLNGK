using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class DoUong
{
    public int MaChuyenMuc { get; set; }
    public string TenChuyenMuc { get; set; }    
    public DoUong()
    {

    }
    public DoUong(int maChuyenMuc, string tenChuyenMuc)
    {
        MaChuyenMuc = maChuyenMuc;
        TenChuyenMuc = tenChuyenMuc;
       
    }
}