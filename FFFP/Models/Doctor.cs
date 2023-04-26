using System.ComponentModel.DataAnnotations;

public class Doctors
{
    [Key]
    public int? DoctorId { get; set; }
    public string? Name { get; set; }
    public string? Specialization { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
}