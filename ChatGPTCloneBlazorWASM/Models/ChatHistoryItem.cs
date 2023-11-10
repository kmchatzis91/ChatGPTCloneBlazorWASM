using System.Diagnostics.CodeAnalysis;

namespace ChatGPTCloneBlazorWASM.Models
{
    public class ChatHistoryItem
    {
        public string? User { get; set; }
        public string? Message { get; set; }
        public string? UserImagePath { get; set; }
        public bool IsMessageMarkdown { get; set; }

        public ChatHistoryItem() { }

        public ChatHistoryItem(string? user, string? message, string? userImagePath, bool isMessageMarkdown)
        {
            User = user;
            Message = message;
            UserImagePath = userImagePath;
            IsMessageMarkdown = isMessageMarkdown;
        }
    }
}
