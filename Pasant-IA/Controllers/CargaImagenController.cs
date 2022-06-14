using Microsoft.AspNetCore.Mvc;
using Pasant_IA.Helpers;

namespace Pasant_IA.Controllers
{
    public class CargaImagenController : Controller
    {

        private HelperUploadFiles helperUpload;

        public CargaImagenController(HelperUploadFiles helperUpload)
        {
            this.helperUpload = helperUpload;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(IFormFile imagen, int ubicacion)
        {
            string nombreImagen = imagen.FileName;

            string path = await this.helperUpload.UploadFilesAsync(imagen, nombreImagen, Providers.Folders.Uploads);

            ViewBag.Mensaje = "Fichero " + nombreImagen + " subido a " + path;

            return View();
        
        }

    }
}
