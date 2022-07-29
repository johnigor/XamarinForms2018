using System;
using System.Collections.Generic;
using System.Text;

namespace App01_Vagas.Data
{
    interface ICaminho
    {
        string GetPath(string DatabaseName);
    }
}
