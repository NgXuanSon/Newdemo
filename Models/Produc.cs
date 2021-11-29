using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Netmo.Models{
    [Table("Producs")]
    public class Produc {
        [Key]
        public int ProducID {get; set;}
        public string ProducName {get; set;}
        public string CategoryID {get; set;}
        public Category Category {get; set;}
    }
}