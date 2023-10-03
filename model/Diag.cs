using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DR.model
{
    public class Diag
    {

        [Key]
        public int Id { get; set; }
        public string? TheNameOfTheDisease  { get; set; }
        public string? Notes1 { get; set; }
        public string? Notes2 { get; set; }
        public string? Notes3 { get; set; }

        [ForeignKey(nameof(Receiving))]
        
        public int? Receiving { get; set; }


    }
}
