using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SassImportProject.Contracts
{
    public interface IReadTextFile
    {
        Task<bool> readTextFiles(string filename);
    }
}
