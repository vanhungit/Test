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
    
    public partial class ProvinceModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProvinceModel()
        {
            this.DistrictModel = new HashSet<DistrictModel>();
        }
    
        public System.Guid ProvinceId { get; set; }
        public string ProvinceName { get; set; }
        public string ProvinceCode { get; set; }
        public Nullable<int> Area { get; set; }
        public Nullable<int> OrderIndex { get; set; }
        public bool Actived { get; set; }
        public string ConfigPriceCode { get; set; }
        public Nullable<bool> IsHasLicensePrice { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DistrictModel> DistrictModel { get; set; }
    }
}
