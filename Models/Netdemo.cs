using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Netmo.Models{
    [Table("Netdemos")]
    public class Netdemo {
        [Key]
        public string NetdemoID {get; set;}
        public string NetdemoName {get; set;}
       

    }
}