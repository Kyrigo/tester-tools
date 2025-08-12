using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tester_tools.Generators
{
    internal class PhoneGenerator
    {
        private static readonly Random random = new();

        public static string Generate()
        {
            var prefix = "+7";
            var code = random.Next(100, 999);
            var number = random.Next(1000000, 9999999);

            return prefix + code + number;
        }
    }
}
