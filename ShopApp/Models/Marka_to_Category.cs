//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShopApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Marka_to_Category
    {
        public int Id { get; set; }
        public Nullable<int> MarkaId { get; set; }
        public Nullable<int> CategoryId { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual Marka Marka { get; set; }
    }
}
