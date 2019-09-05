using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IoTMarket.Models
{
    public class SubCategory
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Nombre de subcategoria")]
        [Required]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Categoria")]
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }

    }
}
