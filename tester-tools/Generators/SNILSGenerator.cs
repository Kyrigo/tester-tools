namespace tester_tools.Generators
{
    internal class SNILSGenerator
    {
        private static readonly Random random = new();

        public static string Generate()
        {
            var rand1 = random.Next(2, 999).ToString().PadLeft(3, '0');
            var rand2 = random.Next(1, 1000).ToString().PadLeft(3, '0');
            var rand3 = random.Next(1, 1000).ToString().PadLeft(3, '0');

            var result = rand1 + rand2 + rand3;
            var kontr = 9 * (result[0] - '0') + 8 * (result[1] - '0') + 7 * (result[2] - '0') +
                        6 * (result[3] - '0') + 5 * (result[4] - '0') + 4 * (result[5] - '0') +
                        3 * (result[6] - '0') + 2 * (result[7] - '0') + 1 * (result[8] - '0');

            if (kontr < 100)
            {
                // оставляем как есть
            }
            else if (kontr > 101)
            {
                kontr %= 101;
                if (kontr == 100)
                    kontr = 0;
            }
            else
            {
                kontr = 0;
            }

            return result + kontr.ToString().PadLeft(2, '0');
        }
    }
}
