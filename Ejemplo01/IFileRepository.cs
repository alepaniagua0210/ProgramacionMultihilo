using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo01
{
    public interface IFileRepository
    {
        void SaveFile(FileData fileData);
        FileData ReadFile(string fileName);
    }
}
