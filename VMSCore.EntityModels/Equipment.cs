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
    
    public partial class Equipment
    {
        public string EquipmentId { get; set; }
        public string EquipmentName { get; set; }
        public string Description { get; set; }
        public string EquipmentGroupId { get; set; }
        public Nullable<int> Sorted { get; set; }
        public bool Active { get; set; }
        public string PlantId { get; set; }
    }
}
