//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IsNew.Models
{
    using System;
    using System.Collections.Generic;
    using System.Web.Mvc;

    public partial class tbl_IsNew
    {
        public int Id { get; set; }
        public Nullable<bool> IsNew { get; set; }
        public Nullable<int> Kms { get; set; }
        [Remote("CheckName", "Home", ErrorMessage = "Employee name already exist")]
        public string Name { get; set; }
    }
}
