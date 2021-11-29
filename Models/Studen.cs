using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Netmo.Models{
  
    public class Studen: Peson {
       
        public int StudenID  {get; set;}
        public string University {get; set;}
    }
}