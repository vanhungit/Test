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
    
    public partial class StaffSkill
    {
        public string Id { get; set; }
        public string StaffId { get; set; }
        public string SkillId { get; set; }
        public string CreatorId { get; set; }
        public string LastModifierId { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<System.DateTime> LogDate { get; set; }
        public Nullable<System.DateTime> CreationTime { get; set; }
        public Nullable<System.DateTime> LastModificationTime { get; set; }
    }
}
