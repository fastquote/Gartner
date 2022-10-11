using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SassImportProject.Contracts
{
    public interface IReadCsvFile
    {
        Task<bool> readCSVFiles(string filename);
    }
}
