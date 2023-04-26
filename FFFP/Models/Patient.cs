using System.ComponentModel.DataAnnotations;

public class Patients
{
    [Key]
    public int PatientId { get; set; }
    public string? Name { get; set; }
    public int? Age { get; set; }
    public string? Gender { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
}