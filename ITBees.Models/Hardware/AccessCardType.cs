using System.ComponentModel.DataAnnotations;

namespace ITBees.Models.Hardware;

public class AccessCardType
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public bool IsActive { get; set; }
}