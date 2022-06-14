using Microsoft.AspNetCore.Hosting;
using System.IO;


namespace Pasant_IA.Providers
{
    public enum Folders
    {
        Uploads = 0, Images = 1, Documents = 2, Temp = 3
    }
    public class PathProvider
    {
        private IWebHostEnvironment hostEnvironment;

        public PathProvider(IWebHostEnvironment hostEnvironment)
        {
            this.hostEnvironment = hostEnvironment;
        }

        public string MapPath(string fileName, Folders folder)
        {
            string carpeta = "";

            if (folder == Folders.Uploads) 
            {
                carpeta = "Descargas";
            }

            string path = Path.Combine(this.hostEnvironment.WebRootPath, carpeta, fileName);

            return path;
        }

    }
}
