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
    
    public partial class WardModel
    {
        public System.Guid WardId { get; set; }
        public string WardCode { get; set; }
        public string Appellation { get; set; }
        public string WardName { get; set; }
        public Nullable<System.Guid> DistrictId { get; set; }
        public Nullable<int> OrderIndex { get; set; }
    
        public virtual DistrictModel DistrictModel { get; set; }
    }
}
