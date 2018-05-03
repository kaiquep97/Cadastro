using System;
using System.Collections.Generic;
using System.Text;

namespace Cadastro.Interfaces
{
    public interface IFile
    {
        bool SaveFile(string content, string nameFile = "relatorio.csv");
    }
}
