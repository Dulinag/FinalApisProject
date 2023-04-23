public class Doctor
{
    public int DoctorId { get; set; }
    public string? Name { get; set; }
    public string? Specialization { get; set; }

    // Navigation property
    public List<Appointment>? Appointments { get; set; }
}
