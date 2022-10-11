using SassImportProject.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SassImportProject.BusinessLayer
{
    public class ReadTextFile:IReadTextFile
    {
        public async Task<bool> readTextFiles(string fileName)
        {
            await Task.Run(() =>
            {
                try
                {
                    using (StreamReader sr = new StreamReader(fileName))
                    {

                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            Console.WriteLine(line);
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

