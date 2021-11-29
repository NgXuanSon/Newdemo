using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Netmo.Models{
    [Table("Category")]
    public class Category {
        [Key]
        public int CategoryID {get; set;}
        public string CategoryName {get; set;}
        public ICollection<Produc> Producs {get; set;}

    }
}