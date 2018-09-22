﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using TeduShop.Model.Abstract;
using System.ComponentModel.DataAnnotations;

namespace TeduShop.Model.Models
{
    [Table("ProductCategories")]
    public class ProductCategory:Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        [Required]
        [MaxLength(256)]
        public string Name { set; get; }
        [MaxLength(500)]
        public string Description { set; get; }
        [Required]
        [MaxLength(256)]
        public string Alias { set; get; }

        public int? ParentID { set; get; }
        public int? DisplayOrder { set; get; }

        [MaxLength(256)]
        public string Image { set; get; }

        public bool? HomeFlag { set; get; }
        //public int? HotFlag { set; get; }
        public virtual IEnumerable<Product> Products { set; get; }
    }
}