//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TeamProject_Soft
{
    using System;
    using System.Collections.Generic;
    
    public partial class report
    {
        public int Id_report { get; set; }
        public Nullable<int> id_emp { get; set; }
        public Nullable<int> id_schedule { get; set; }
        public string content { get; set; }
    
        public virtual employee employee { get; set; }
        public virtual schedule schedule { get; set; }
    }
}