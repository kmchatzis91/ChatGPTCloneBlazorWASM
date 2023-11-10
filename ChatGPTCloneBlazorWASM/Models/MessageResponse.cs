using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace ChatGPTCloneBlazorWASM.Models
{
    public class MessageResponse
    {
        [JsonPropertyName("role")]
        public string? Role { get; set; }

        [JsonPropertyName("content")]
        public string? Content { get; set; }
    }
}
