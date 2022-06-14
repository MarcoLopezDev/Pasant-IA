using Azure.Storage.Blobs;

namespace Pasant_IA
{
    public class UploadBlobWeb
    {
        static string connectionString = "DefaultEndpointsProtocol=https;AccountName=formanalyzerstorage;AccountKey=CluKUgu+1sYSV5zbIi13lTm8am7tjgHjK4hEkZFSaLTPJrdy5RQciu1hZij789AiZ4m0JKK/tzDf45QCxDIn5w==;EndpointSuffix=core.windows.net";
        static string containerName = "democontainer";

        public async void Main(IFormFile imagen)
        {
            BlobServiceClient blobServiceClient = new BlobServiceClient(connectionString);
            BlobContainerClient containerClient = blobServiceClient.CreateBlobContainer(containerName);

            /*var files = Directory.GetFiles(imagen);
            foreach (var file in files)
            {
                using (MemoryStream stream = new MemoryStream(File.ReadAllBytes(file)))
                {
                    containerClient.UploadBlob(Path.GetFileName(file), stream);
                }

            const BlobClient = containerClient.GetBlobClient(imagen);


                Console.WriteLine(file + "Uploaded!");
            }*/
            Console.Read();
        }


    }
}
