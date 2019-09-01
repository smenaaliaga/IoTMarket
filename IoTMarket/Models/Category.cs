using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IoTMarket.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Display(Name="Nombre de categoria")]
        [Required]
        public string Name { get; set; }
    }
}
