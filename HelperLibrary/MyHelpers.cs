namespace HelperLibrary
{
    public class MyHelpers
    {
        public static string GetWelcomeMessage(string platform = "Android")
        {
            return platform == "Android" ? "Hello World from Android" : $"Hello World from {platform}";
        }
    }
}
