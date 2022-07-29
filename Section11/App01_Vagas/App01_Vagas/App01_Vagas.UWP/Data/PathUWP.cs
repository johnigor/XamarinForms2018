using System.IO;
using Xamarin.Forms;
using Windows.Storage;
using App01_Vagas.Data;
using App01_Vagas.UWP.Data;

[assembly:Dependency(typeof(PathUWP))]
namespace App01_Vagas.UWP.Data
{
    public class PathUWP : ICaminho
    {
        public string GetPath(string databaseName)
        {
            string folderPath = ApplicationData.Current.LocalFolder.Path;
            string dataPath = Path.Combine(folderPath, databaseName);
            return dataPath;
        }
    }
}
