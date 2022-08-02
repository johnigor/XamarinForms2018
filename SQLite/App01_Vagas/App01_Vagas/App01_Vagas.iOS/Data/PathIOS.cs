using System.IO;
using Xamarin.Forms;
using App01_Vagas.Data;
using App01_Vagas.iOS.Data;

[assembly:Dependency(typeof(PathIOS))]
namespace App01_Vagas.iOS.Data
{    
    public class PathIOS : ICaminho
    {
        public string GetPath(string databaseName)
        {
            string folderPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string libraryPath = Path.Combine(folderPath, "..", "Library");
            string dataPath = Path.Combine(libraryPath, databaseName);

            return dataPath;
        }
    }
}