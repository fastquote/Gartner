using Microsoft.Extensions.DependencyInjection;
using SassImportProject.BusinessLayer;
using SassImportProject;
using SassImportProject.Contracts;

namespace SassProductImport
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter path of your file");
            string filePath = Console.ReadLine();
            DependencyManager.SetupDependenies();
            var objCsv = DependencyManager._serviceProvider.GetService<IReadCsvFile>();
            var objJson = DependencyManager._serviceProvider.GetService<IReadJsonFile>();
            var objText = DependencyManager._serviceProvider.GetService<IReadTextFile>();
            var objYaml = DependencyManager._serviceProvider.GetService<IReadYamlFile>();

            var fileReader = new FileReader(objCsv, objJson, objText, objYaml);
            try
            {
                fileReader.readFiles(filePath);
                Console.ReadLine();

            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                Console.WriteLine("Thank you for using SassProductImport Application");
                Console.ReadLine();
            }

        }






    }
}
