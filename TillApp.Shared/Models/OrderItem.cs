﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using EF Core template.
// Code is generated on: 1/20/2024 11:38:04 AM
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

#nullable enable annotations
#nullable disable warnings

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Linq.Expressions;
using Newtonsoft.Json;

namespace TillApp.Shared.Models
{
    public partial class OrderItem
    {
        public int OrderItemID { get; set; }

        public string ItemName { get; set; }

        public decimal Price { get; set; }
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual Order? Order { get; set; }

    }

}
