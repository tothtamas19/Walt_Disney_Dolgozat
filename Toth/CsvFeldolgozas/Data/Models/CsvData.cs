using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvFeldolgozas.Data.Models
{
    public class CsvData
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public CsvData()
        {

        }

        public CsvData(string ReadScvLines, string catchName)
        {
            string[] lines = ReadScvLines.Split(' ');

            if (lines.Length == 2 && lines[0]==catchName)
            {
                Name = lines[0];
                if (!int.TryParse(lines[1], out int id))
                {
                    throw new ArgumentException("Error");
                }
            }
        }

        public override string ToString()
        {
            return $"{Name}";
        }



    }

}
