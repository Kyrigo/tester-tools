namespace tester_tools.Generators
{
    internal class TextGenerator
    {
        private static readonly Random random = new();
        private const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

        public static string Generate(decimal length)
        {
            return new string([.. Enumerable.Repeat(chars, (int)length).Select(s => s[random.Next(s.Length)])]);
        }
    }
}
