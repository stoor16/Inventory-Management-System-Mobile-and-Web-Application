﻿    using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InventoryManagement.Models
{
    public class Resource
    {
        [Key]
        public int ResourceId { get; set; }
        [Required]
        [Display(Name = "Resource Name")]
        public string ResourceName { get; set; }

        [RegularExpression("([1-9][0-9]*)", ErrorMessage = "Enter number greater than 0")]
        [Required]
        public string Quantity { get; set; }
        public string Description { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public bool IsActive { get; set; } = true;
        public bool Changed { get; set; }
        public string PreviousValue { get; set; }

        public int FacilityId { get; set; }
        public Facility Facility { get; set; }
    }
}