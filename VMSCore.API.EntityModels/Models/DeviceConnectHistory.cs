﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace VMSCore.API.EntityModels.Models
{
    public partial class DeviceConnectHistory
    {
        public string Id { get; set; }
        public string DeviceId { get; set; }
        public string DeviceType { get; set; }
        public string DeviceGroup { get; set; }
        public bool? Status { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public string KeyTime { get; set; }
        public string KeyDate { get; set; }
        public string CreatorId { get; set; }
        public string LastModifierId { get; set; }
        public bool? Active { get; set; }
        public DateTime? LogDate { get; set; }
        public DateTime? CreationTime { get; set; }
        public DateTime? LastModificationTime { get; set; }
    }
}