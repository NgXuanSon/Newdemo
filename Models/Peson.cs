using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Netmo.Models{
    [Table("People")]
    public class Peson {
        [Key]
        public int PesonID {get; set;}
        public string FullName {get; set;}
    }
}