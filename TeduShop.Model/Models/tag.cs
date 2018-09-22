﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TeduShop.Model.Models
{
    [Table("Tags")]
    public class Tag
    {
        [Key]
        [MaxLength(50)]
        public int ID { set; get; }
        
        [Required]
        [MaxLength(50)]
        public string Name { set; get;}

        [Required]
        [MaxLength(50)]
        public string Type { set; get; }
    }
}
