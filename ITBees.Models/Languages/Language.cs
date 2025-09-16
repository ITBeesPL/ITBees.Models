using System.ComponentModel.DataAnnotations;

namespace ITBees.Models.Languages
{
    public class Language
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public bool IsSupported { get; set; }
    }
}