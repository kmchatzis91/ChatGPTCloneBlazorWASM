using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace ChatGPTCloneBlazorWASM.Models
{
    public class ChatResponse
    {
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("object")]
        public string? Object { get; set; }

        [JsonPropertyName("created")]
        public int Created { get; set; }

        [JsonPropertyName("model")]
        public string? Model { get; set; }

        [JsonPropertyName("choices")]
        public List<ChoiceResponse>? Choices { get; set; }

        [JsonPropertyName("usage")]
        public UsageResponse? Usage { get; set; }
    }
}
