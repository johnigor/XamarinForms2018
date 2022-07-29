﻿using System.IO;
using Xamarin.Forms;
using App01_Vagas.Data;
using App01_Vagas.Droid.Data;

[assembly:Dependency(typeof(Caminho))]
namespace App01_Vagas.Droid.Data
{
    public class Caminho : ICaminho
    {
        public string GetPath(string databaseName)
        {
            string folderPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string dataPath = Path.Combine(folderPath, databaseName);

            return dataPath;
        }
    }
}