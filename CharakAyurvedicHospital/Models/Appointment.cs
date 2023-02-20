using Microsoft.Build.Framework;

namespace CharakAyurvedicHospital.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        
        [Required]
        public String? PatientName { get; set; }
        public String? PatienteMail { get; set; }
        public String? PatientPhone { get; set; }
        public String? Gender { get; set; }
       
        public String? AreYouNewPatient { get; set; }
    }
}
