using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DR.model
{
    public class PrescriptionDDD
    {
        [Key]
        public int Id { get; set; }


        [ForeignKey(nameof(IdPrescription))]
        public int? IdPrescription { get; set; }



        [ForeignKey(nameof(IdDiagnosis))]
        public int? IdDiagnosis { get; set; }

        public Prescription1 Prescription { get; set; }
        public Diag Diagnosis { get; set; }
    }
}
