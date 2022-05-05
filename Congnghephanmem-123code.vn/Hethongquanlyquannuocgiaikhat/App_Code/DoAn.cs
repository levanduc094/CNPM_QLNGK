using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class ChuyenMuc
{
    public int MaChuyenMuc { get; set; }
    public string TenChuyenMuc { get; set; }    
    public ChuyenMuc()
    {

    }    
    public ChuyenMuc(int maChuyenMuc, string tenChuyenMuc)
    {
        MaChuyenMuc = maChuyenMuc;
        TenChuyenMuc = tenChuyenMuc;
       
    }
}
