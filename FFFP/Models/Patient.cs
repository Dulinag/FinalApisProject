using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

public class Patients
{
    [Key]
    public int PatientId { get; set; }
    public string? Name { get; set; }
    public int Age { get; set; }
    public string? Gender { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
}
