using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvFeldolgozas.Data.Models;

namespace CsvFeldolgozas.Data
{
    public class Connector4Dtb
    {
        public static void ImportFromCsv(string filePath, string catchName)
        {
            using (var context = new Context())
            {
                using (var reader = new StreamReader(filePath))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        try
                        {
                            var csvData = new CsvData(line, catchName);
                            context.CsvData_stuff.Add(csvData);
                        }
                        catch(ArgumentException xx)
                        {
                            Console.WriteLine(xx.Message);
                        }
                    }
                    context.SaveChanges();
                }
            }
        }
    }
}
