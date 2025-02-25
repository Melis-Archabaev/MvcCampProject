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
        public string AboutDetailsFirst { get; set; }
        [StringLength(1000)]
        public string AboutDetailsSecond { get; set; }
        [StringLength(100)]
        public string AboutImageFirst { get; set; }
        [StringLength(100)]
        public string AboutImageSecond { get; set; }


    }
}
