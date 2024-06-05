using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using CsvFeldolgozas.Data;
using Microsoft.EntityFrameworkCore;


namespace CsvFeldolgozas
{
    public class Program
    {
        static void Main(string[] args) {
            string path2File = "D://tt//asztali_alkalmazasok//Toth//CsvFeldolgozas//Data//CsvSource//Toth.csv";
            string catchName = "ID";
            Connector4Dtb.ImportFromCsv(path2File, catchName);
        }

    }
}
