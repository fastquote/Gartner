using SassImportProject.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SassImportProject.BusinessLayer
{
    public class ReadCsvFile:IReadCsvFile
    {
        public async Task<bool> readCSVFiles(string filename)
        {
            await Task.Run(() =>
            {
                try
                {
                    string[] Lines = System.IO.File.ReadAllLines(filename);
                    foreach (string line in Lines)
                    {
                        string[] columns = line.Split(' ');
                        foreach (string column in columns)
                        {
                            Console.WriteLine("importing.." + column);
                        }
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("error occured while reading ...");
                    return false;
                }
                return true;
            }).ConfigureAwait(true);
            return true;

        }
    }
}

