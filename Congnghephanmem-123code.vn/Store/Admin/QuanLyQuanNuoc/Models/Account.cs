﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyQuanNuoc.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Account
    {
        public int id { get; set; }

        [Required(ErrorMessage ="Nhập Username")]
        public string Username { get; set; }
        public string DisplayName { get; set; }
        [Display(Name ="Password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Nhập Password")]
        public string Password { get; set; }
        public bool Type { get; set; }

        public string LoginError { get; set; }
    }
}