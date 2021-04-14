using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
    public class page : IEntity
    {
        [Key]
        public int pageId { get; set; }
        public string img { get; set; }
        public int modulId { get; set; }
        public int typeId { get; set; }
        public int row { get; set; }
        public string target { get; set; }
        public bool status { get; set; }
        public string urlsite { get; set; }
    }
}
