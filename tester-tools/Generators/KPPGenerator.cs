namespace tester_tools.Generators
{
    internal class KPPGenerator
    {
        private static readonly Random random = new();

        public static string Generate()
        {
            var region = random.Next(1, 93).ToString().PadLeft(2, '0');
            var inspection = random.Next(1, 100).ToString().PadLeft(2, '0');

            var reason = random.Next(1, 5) switch
            {
                1 => "01",
                2 => "43",
                3 => "44",
                4 => "45",
                _ => "01"
            };

            var number = random.Next(1, 1000).ToString().PadLeft(3, '0');

            return region + inspection + reason + number;
        }
    }
}
