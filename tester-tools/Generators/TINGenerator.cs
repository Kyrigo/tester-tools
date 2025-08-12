using System.Text.RegularExpressions;

namespace tester_tools.Generators
{
    internal partial class TINGenerator
    {
        private static readonly Random random = new();

        public static string GenerateTIN(string symbolsCount)
        {

            string tin = symbolsCount switch
            {
                "10" => GenerateULTIN(),
                "12" => GenerateFLTIN(),
                _ => throw new NotImplementedException("Получено некорректное количество символов"),
            };

            return tin;
        }

        public static bool CheckTIN(string inn)
        {
            if (Regex.IsMatch(inn, @"\D"))
                return false;

            if (inn.Length == 10)
            {
                int[] digits = inn.Select(c => c - '0').ToArray();
                int check = (2 * digits[0] + 4 * digits[1] + 10 * digits[2] +
                            3 * digits[3] + 5 * digits[4] + 9 * digits[5] +
                            4 * digits[6] + 6 * digits[7] + 8 * digits[8]) % 11 % 10;

                return digits[9] == check;
            }
            else if (inn.Length == 12)
            {
                int[] digits = inn.Select(c => c - '0').ToArray();

                int check1 = (7 * digits[0] + 2 * digits[1] + 4 * digits[2] +
                             10 * digits[3] + 3 * digits[4] + 5 * digits[5] +
                             9 * digits[6] + 4 * digits[7] + 6 * digits[8] +
                             8 * digits[9]) % 11 % 10;

                int check2 = (3 * digits[0] + 7 * digits[1] + 2 * digits[2] +
                             4 * digits[3] + 10 * digits[4] + 3 * digits[5] +
                             5 * digits[6] + 9 * digits[7] + 4 * digits[8] +
                             6 * digits[9] + 8 * digits[10]) % 11 % 10;

                return digits[10] == check1 && digits[11] == check2;
            }

            return false;
        }

        private static string GenerateFLTIN()
        {
            var region = Math.Floor(random.NextDouble() * 92 + 1).ToString().PadLeft(2, '0');
            var inspection = Math.Floor(random.NextDouble() * 99 + 1).ToString().PadLeft(2, '0');
            var number = Math.Floor(random.NextDouble() * 999999 + 1).ToString().PadLeft(6, '0');

            var result = region + inspection + number;

            int kontr = (
                7 * (result[0] - '0') + 2 * (result[1] - '0') + 4 * (result[2] - '0') +
                10 * (result[3] - '0') + 3 * (result[4] - '0') + 5 * (result[5] - '0') +
                9 * (result[6] - '0') + 4 * (result[7] - '0') + 6 * (result[8] - '0') +
                8 * (result[9] - '0')
            ) % 11 % 10;

            kontr = kontr == 10 ? 0 : kontr;
            result += kontr.ToString();

            kontr = (
                3 * (result[0] - '0') + 7 * (result[1] - '0') + 2 * (result[2] - '0') +
                4 * (result[3] - '0') + 10 * (result[4] - '0') + 3 * (result[5] - '0') +
                5 * (result[6] - '0') + 9 * (result[7] - '0') + 4 * (result[8] - '0') +
                6 * (result[9] - '0') + 8 * (result[10] - '0')
            ) % 11 % 10;

            kontr = kontr == 10 ? 0 : kontr;
            result += kontr.ToString();

            return result;
        }

        private static string GenerateULTIN()
        {
            var region = Math.Floor(random.NextDouble() * 92 + 1).ToString().PadLeft(2, '0');
            var inspection = Math.Floor(random.NextDouble() * 99 + 1).ToString().PadLeft(2, '0');
            var number = Math.Floor(random.NextDouble() * 99999 + 1).ToString().PadLeft(5, '0');

            string result = region + inspection + number;

            int kontr = (
                2 * (result[0] - '0') +
                4 * (result[1] - '0') +
                10 * (result[2] - '0') +
                3 * (result[3] - '0') +
                5 * (result[4] - '0') +
                9 * (result[5] - '0') +
                4 * (result[6] - '0') +
                6 * (result[7] - '0') +
                8 * (result[8] - '0')
            ) % 11 % 10;

            kontr = kontr == 10 ? 0 : kontr;

            return result + kontr.ToString();
        }
    }
}
