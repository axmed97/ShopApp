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
    
    public partial class Order
    {
        public int Id { get; set; }
        public int WorkerId { get; set; }
        public int ProductId { get; set; }
        public System.DateTime Purchase_Date { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual Worker Worker { get; set; }
    }
}