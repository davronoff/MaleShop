﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaleShop.Domains
{
    public class Brand
    {
        [Required,Key]
        public Guid Id { get; set; }
        [Required]
        public string? Name { get; set; }
    }
}
