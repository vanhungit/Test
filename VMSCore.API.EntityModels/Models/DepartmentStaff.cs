﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace VMSCore.API.EntityModels.Models
{
    public partial class DepartmentStaff
    {
        public string Id { get; set; }
        public string PositionId { get; set; }
        public string StaffId { get; set; }
        public bool? IsPrimary { get; set; }
        public string LastModifierId { get; set; }
        public string CreatorId { get; set; }
        public bool? Active { get; set; }
        public DateTime? LogDate { get; set; }
    }
}