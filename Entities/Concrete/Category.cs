
using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
    public class Category:IEntity
    {
        [Key]
        public int CategoryID { get; set; }
        [StringLength(15)]
        public string CategoryName { get; set; }
        public string Description { get; set; }

    }
}
