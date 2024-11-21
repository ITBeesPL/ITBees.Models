using System.ComponentModel.DataAnnotations;

namespace ITBees.Models.Hardware;

public class DeviceType
{
    [Key]
    public int Id { get; set; }
    public string TypeName { get; set; }
    public string Description { get; set; }
    public bool IsAvailable { get; set; }
}