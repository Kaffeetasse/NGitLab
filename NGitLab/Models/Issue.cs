using System;
using System.Text.Json.Serialization;

namespace NGitLab.Models;

public class Issue : IssueBase
{
    [JsonPropertyName("labels")]
    public string[] Labels { get; set; }
}
