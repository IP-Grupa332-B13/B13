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
    
    public partial class absence
    {
        public int Id_absence { get; set; }
        public Nullable<int> id_emp { get; set; }
        public Nullable<System.DateTime> date { get; set; }
    
        public virtual employee employee { get; set; }
    }
}