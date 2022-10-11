using SassImportProject.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SassImportProject.BusinessLayer
{
    
        public sealed class FileReader
        {
            private readonly IReadCsvFile _readCSV;
            private readonly IReadJsonFile _readJson;
            private readonly IReadTextFile _readText;
            private readonly IReadYamlFile _readYaml;
            public FileReader(IReadCsvFile readCSV, IReadJsonFile readJson, IReadTextFile readText, IReadYamlFile readYaml)
            {

                _readCSV = readCSV ?? throw new ArgumentNullException(nameof(FileReader));
                _readJson = readJson ?? throw new ArgumentNullException(nameof(FileReader));
                _readText = readText ?? throw new ArgumentNullException(nameof(FileReader));
                _readYaml = readYaml ?? throw new ArgumentNullException(nameof(FileReader));
            }

            public bool readFiles(string filePath)
            {
                try
                {
                    //get the file name from file path
                    string fileName = Path.GetFileName(filePath);

                    /*check if filename is not null
                    */
                    if (!string.IsNullOrEmpty(fileName))
                    {
                        string extension = Path.GetExtension(filePath).ToLower();
                        readFilesByFormat(filePath, extension);
                    }
                    else
                    {
                        Console.WriteLine("this file doesnot exist..");

                    }
                    return true;


                }
                catch (Exception ex)
                {
                    Console.WriteLine("error reading file..");
                    return false;
                }
            }
            public void readFilesByFormat(string filePath, string extension)
            {
                switch (extension)
                {
                    case ".json":
                        _readJson.readJsonFile(filePath);
                        break;
                    case ".txt":
                        _readText.readTextFiles(filePath);
                        break;
                    case ".yaml":
                        _readYaml.readYamlFiles(filePath);
                        break;
                    case ".csv":
                        _readCSV.readCSVFiles(filePath);
                        break;

                }

            }
        }
    
}
