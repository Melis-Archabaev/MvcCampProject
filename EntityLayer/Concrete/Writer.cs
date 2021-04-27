using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Writer
    {
        [Key]
        public int WriterId { get; set; }
        [StringLength(50)]
        public string WriterName { get; set; }
        [StringLength(50)]
        public string WriterSurname { get; set; }
        [StringLength(100)]
        public string WriterImage { get; set; }
        [StringLength(30)]
        public string WriterMail { get; set; }
        [StringLength(30)]
        public string WriterPassword { get; set; }
        

        //Writer связан с Heading(Writer стороны один)
        public ICollection<Heading> Headings { get; set; }


        //Writer связан с Content(Writer стороны один)
        public ICollection<Content> Contents { get; set; }

    }
}
