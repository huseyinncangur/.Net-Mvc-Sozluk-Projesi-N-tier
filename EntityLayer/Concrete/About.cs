﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class About
    {
        [Key]
        public int AboutId { get; set; }
        [StringLength(1000)]
        public string Details { get; set; }
        [StringLength(1000)]
        public string Details2 { get; set; }
        [StringLength(100)]
        public string Image { get; set; }
        [StringLength(100)]
        public string Image2 { get; set; }
        public bool Status { get; set; }

    }
}
