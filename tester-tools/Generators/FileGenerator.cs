using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tester_tools.Generators
{
    internal class FileGenerator
    {
        public static void Generate(string filePath, long size, string checkedOption)
        {
            long sizeInBytes = checkedOption switch
            {
                "Б" => throw new NotImplementedException("Как ты сюда попал? о_О"),
                "КБ" => size * 1024L,
                "МБ" => size * 1024L * 1024L,
                "ГБ" => size * 1024L * 1024L * 1024L,
                _ => throw new ArgumentException($"Неподдерживаемая единица измерения: {checkedOption}")
            };

            using FileStream fs = new(filePath, FileMode.Create);
            fs.SetLength(sizeInBytes);
        }
    }
}
