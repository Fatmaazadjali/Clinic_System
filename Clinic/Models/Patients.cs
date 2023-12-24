using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinic.DbContext;

namespace Clinic.Models
{
    internal class Patients 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PatientId { get; set; }
        public string PatientName {  get; set; }
        public int PhoneNumber { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        public string Gender { get; set; }

         public List<Patients> patients { get; set; }
       

    }
}
