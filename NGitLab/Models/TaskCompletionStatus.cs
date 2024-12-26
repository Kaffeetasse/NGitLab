using System.Text.Json.Serialization;

namespace NGitLab.Models;

public class TaskCompletionStatus
{
    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("completed_count")]
    public int CompletedCount { get; set; }
}
