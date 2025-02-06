﻿namespace ITBees.Models.Payments;

public class PlatformFeature
{
    public int Id { get; set; }
    public string FeatureName { get; set; }
    public string? FeatureDescription { get; set; }
    public bool IsVisible { get; set; }
    public string? GroupName { get; set; }
    public string? FeatureValueDescription { get; set; }
}