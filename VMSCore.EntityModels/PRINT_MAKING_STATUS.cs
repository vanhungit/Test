//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VMSCore.EntityModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class PRINT_MAKING_STATUS
    {
        public System.Guid Id { get; set; }
        public string Code { get; set; }
        public Nullable<System.Guid> TypeDevice { get; set; }
        public Nullable<System.Guid> GroupDevice { get; set; }
        public Nullable<System.Guid> KeyCompany { get; set; }
        public string IDName { get; set; }
        public string ProductOrder { get; set; }
        public string ProductID { get; set; }
        public string LineProcess { get; set; }
        public string Data { get; set; }
        public Nullable<decimal> Quantity { get; set; }
        public string QuantityHex { get; set; }
        public string BinaryHex { get; set; }
        public Nullable<int> Sorted { get; set; }
        public string Description { get; set; }
        public string CreateBy { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string ModifyBy { get; set; }
        public Nullable<System.DateTime> ModifyDate { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<System.DateTime> LogDate { get; set; }
    }
}
