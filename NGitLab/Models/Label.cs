using System.Text.Json.Serialization;

namespace NGitLab.Models
{
    public class Label
    {
        [JsonPropertyName("id")]
        public int Id;

        [JsonPropertyName("name")]
        public string Name;

        [JsonPropertyName("color")]
        public string Color;

        [JsonPropertyName("text_color")]
        public string TextColor;

        [JsonPropertyName("description")]
        public string Description;
    }
}
