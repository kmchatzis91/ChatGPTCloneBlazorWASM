using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace ChatGPTCloneBlazorWASM.Models
{
    public class ChoiceResponse
    {
        [JsonPropertyName("index")]
        public int Index { get; set; }

        [JsonPropertyName("message")]
        public MessageResponse? Message { get; set; }

        [JsonPropertyName("finish_reason")]
        public string? FinishReason { get; set; }
    }
}
