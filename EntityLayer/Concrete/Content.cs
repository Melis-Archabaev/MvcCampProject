﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Content
    {
        [Key]
        public int ContentId { get; set; }
        [StringLength(3000)]
        public string ContentValue { get; set; }
        public DateTime ContentDate { get; set; }


        //Content связан с Heading(Content строны много)
        public int HeadingId { get; set; }
        public virtual Heading Heading { get; set; }


        //Content связан с Writer(Content строна много)
        public int? WriterId { get; set; }
        public virtual Writer Writer { get; set; }
    }
}
