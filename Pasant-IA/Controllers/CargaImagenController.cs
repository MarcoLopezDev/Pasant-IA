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

            var blob = new UploadBlobWeb();

            blob.Main(imagen);

            return View();
        
        }

    }
}
