//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HMData
{
    using System;
    using System.Collections.Generic;
    
    public partial class Food
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public System.DateTime BuyDate { get; set; }
        public System.DateTime BestBeforeDate { get; set; }
        public int HomeId { get; set; }
        public Nullable<System.DateTime> ConsumedDate { get; set; }
    }
}
