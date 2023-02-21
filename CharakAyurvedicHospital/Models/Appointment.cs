using Microsoft.Build.Framework;

namespace CharakAyurvedicHospital.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        
        [Required]
        public String? PatientName { get; set; }
        [Required]
        public String? PatienteMail { get; set; }
        [Required]
        public String? PatientPhone { get; set; }
        [Required]
        public String? Gender { get; set; }
        [Required]
       
        public String? AreYouNewPatient { get; set; }
    }
}
