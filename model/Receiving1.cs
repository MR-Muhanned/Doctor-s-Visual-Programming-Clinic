using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DR.model
{
    public class Receiving1
    {
        [Key]
        public int Id { get; set; }
        public string? NameSick { get; set; }
        public int? Age { get; set; }
        public string? WhereToLive { get; set; }
        public string? Gender { get; set; }
        public DateTime? DateSession { get; set; }
        public string? TypeOfInspection { get; set; }
        public int? Price { get; set; }
        public string? ChronicDiseases { get; set; }
    }
}
