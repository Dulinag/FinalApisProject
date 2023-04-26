
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Appointments
{
    [Key]
    public int AppointmentId { get; set; }
    public DateTime Date { get; set; }
    public TimeSpan StartTime { get; set; }
    public TimeSpan EndTime { get; set; }
    public int DoctorId { get; set; }
    public int PatientId { get; set; }

    [ForeignKey("DoctorId")]
    public Doctor? Doctor { get; set; }

    [ForeignKey("PatientId")]
    public Patient? Patient { get; set; }
}