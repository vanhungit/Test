﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace VMSCore.API.EntityModels.Models
{
    public partial class DataSetting
    {
        public string Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public long? DataValue { get; set; }
        public string Description { get; set; }
        public string GroupName { get; set; }
        public string LastModifierId { get; set; }
        public string CreatorId { get; set; }
        public DateTime? LogDate { get; set; }
        public DateTime? CreationTime { get; set; }
        public DateTime? LastModificationTime { get; set; }
    }
}