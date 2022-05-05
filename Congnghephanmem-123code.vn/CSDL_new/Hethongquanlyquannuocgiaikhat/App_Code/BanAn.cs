using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class BanAn
{
    private int MaBan { get; set; }
    private string TenBan { get; set; }
    private string TrangThai { get; set; }
    public BanAn()
    {

    }
    public BanAn(string tenBan, string trangThai)
    {
        TenBan = tenBan;
        TrangThai = trangThai;
    }
    public BanAn(int maBan, string tenBan, string trangThai)
    {
        MaBan = maBan;
        TenBan = tenBan;
        TrangThai = trangThai;
    }

}