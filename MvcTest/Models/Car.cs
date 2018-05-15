﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcTest.Models
{
    public class Car
    {
        [Key]
        public int CarId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}