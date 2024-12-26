using System;
using System.Text.Json.Serialization;

namespace NGitLab.Models;

public class Issue
{
    [JsonPropertyName("labels")]
    public string[] Labels { get; set; }
}
