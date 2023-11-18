using System.Text.Json.Serialization;

namespace NGitLab.Models
{
    public class IssueDetailed : IssueBase
    {
        [JsonPropertyName("labels")]
        public Label[] Labels;

        [JsonPropertyName("time_stats")]
        public TimeStats TimeStats { get; set; }

        [JsonPropertyName("task_completion_status")]
        public TaskCompletionStatus TaskCompletionStatus { get; set; }

        [JsonPropertyName("blocking_issues_count")]
        public int BlockingIssuesCount { get; set; }
    }
}
