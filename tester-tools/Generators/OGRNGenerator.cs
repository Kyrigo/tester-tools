using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tester_tools.Generators
{
    internal class OGRNGenerator
    {
        private static readonly Random random = new();

        public static string Generate()
        {
            var attribute = random.Next(1, 10).ToString();
            var godreg = random.Next(1, 17).ToString().PadLeft(2, '0');
            var region = random.Next(1, 93).ToString().PadLeft(2, '0');
            var inspection = random.Next(1, 100).ToString().PadLeft(2, '0');
            var zapis = random.Next(1, 100000).ToString().PadLeft(5, '0');

            var result = attribute + godreg + region + inspection + zapis;
            var num = long.Parse(result);
            var kontr = (int)(num % 11 % 10);
            kontr = kontr == 10 ? 0 : kontr;

            return result + kontr.ToString();
        }
    }
}
