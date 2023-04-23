public class Appointment
{
    public int? AppointmentId { get; set; }
    public DateTime? Date { get; set; }
    public int DoctorId { get; set; }
    public int? PatientId { get; set; }

    // Navigation properties
    public Doctor? Doctor { get; set; }
    public Patient? Patient { get; set; }
}
