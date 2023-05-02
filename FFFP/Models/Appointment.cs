
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;


public class Appointments
{
    [Key]
    public int AppointmentId { get; set; }
    public DateTime Date { get; set; }
    public TimeSpan StartTime { get; set; }
    public TimeSpan EndTime { get; set; }

    [ForeignKey("Doctor")]
    public int DoctorId { get; set; }

    [ForeignKey("Patient")]
    public int PatientId { get; set; }

    public virtual Doctors? Doctor { get; set; }
    public virtual Patients? Patient { get; set; }
}