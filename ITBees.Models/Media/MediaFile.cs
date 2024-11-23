using ITBees.Models.Companies;
using ITBees.Models.Users;
using System;
using System.ComponentModel.DataAnnotations;

namespace ITBees.Models.Media;

public class MediaFile
{
    [Key]
    public Guid Guid { get; set; }
    public string Type { get; set; }
    public string FileName { get; set; }
    public string OriginalFileName { get; set; }
    public string FileExtension { get; set; }
    public string FilePath { get; set; }
    public Company Company { get; set; }
    public Guid? CompanyGuid { get; set; }
    public UserAccount CreatedBy { get; set; }
    public Guid CreatedByGuid { get; set; }
    public DateTime Created { get; set; }
    public bool IsActive { get; set; }
    public long FileSize { get; set; }
    public bool PublicVisible { get; set; }
}