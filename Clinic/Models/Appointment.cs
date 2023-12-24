using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Models
{
    internal class Appointment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AppointmentId {get; set;}
        public string Day { get; set;}
        public DateTime dateTime { get; set;}

        [ForeignKey(nameof(Patients))]
        public string PatientId { get; set; }

        [ForeignKey(nameof(Specialization))]
        public int SpeId { get; set; }

        public List<Specialization> Specializations { get; set;}
    }
}
