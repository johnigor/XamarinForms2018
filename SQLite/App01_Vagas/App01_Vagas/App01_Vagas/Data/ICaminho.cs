using System;
using System.Collections.Generic;
using System.Text;

namespace App01_Vagas.Data
{
    public interface ICaminho
    {
        string GetPath(string databaseName);
    }
}
