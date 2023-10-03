using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DR.model
{
    public class Prescription1
    {
        [Key]
        public int Id { get; set; }
        public string? Drug1 { get; set; }
        public string? Drug2 { get; set; }
        public string? Drug3 { get; set; }
        public string? Drug4 { get; set; }
        public string? Drug5 { get; set; }
        public int? NumberOfDoses1 { get; set; }
        public int? NumberOfDoses2 { get; set; }
        public int? NumberOfDoses3 { get; set; }
        public int? NumberOfDoses4 { get; set; }
        public int? NumberOfDoses5 { get; set; }
        public string? Manufacturer1 { get; set; }
        public string? Manufacturer2 { get; set; }
        public string? Manufacturer3 { get; set; }
        public string? Manufacturer4 { get; set; }
        public string? Manufacturer5 { get; set; }
    }
}
