using System.Diagnostics;

namespace ChatGPTCloneBlazorWASM.Models
{
    public static class Error
    {
        #region Methods
        public static void Display(string location, string message)
        {
            // Display in debugger
            Debug.WriteLine(" ");
            Debug.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
            Debug.WriteLine($" -> Error in: {location}");
            Debug.WriteLine($" -> Error message: {message}");
            Debug.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
            Debug.WriteLine(" ");

            // Display in console
            Console.WriteLine(" ");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine($" -> Error in: {location}");
            Console.WriteLine($" -> Error message: {message}");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine(" ");
        }
        #endregion
    }
}
