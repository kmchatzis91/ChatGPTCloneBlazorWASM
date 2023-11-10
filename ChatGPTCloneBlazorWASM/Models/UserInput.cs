using System.Diagnostics.CodeAnalysis;

namespace ChatGPTCloneBlazorWASM.Models
{
    public class UserInput
    {
        public string? Text { get; set; }

        public UserInput() { }

        public UserInput(string text)
        {
            Text = text;
        }
    }
}
