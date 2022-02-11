using System;
using System.IO;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;
using System.Drawing;
using System.Text;

namespace GeforyAPI
{
    public class DownloadItem
    {
        public async Task DownloadFileasync(string directoryPath, Uri uri, string fileName="Random")
        {
            var httpClient = new HttpClient();

            // Get the file extension
            var uriWithoutQuery = uri.GetLeftPart(UriPartial.Path);
            var fileExtension = Path.GetExtension(uriWithoutQuery);

            // Create file path and ensure directory exists
            Random rnd = new Random();
            string Builder;
            if (fileName == "Random")
                Builder = "FILEX" + Convert.ToString(rnd.Next(5, 5500));
            else
                Builder = fileName;

            var path = Path.Combine(directoryPath, $"{Builder}{fileExtension}");
            Directory.CreateDirectory(directoryPath);

            // Download the image and write to the file
            var imageBytes = await httpClient.GetByteArrayAsync(uri);
            File.WriteAllBytes(path, imageBytes);
        }

        public void DownloadFile(string directoryPath, Uri uri, string fileName = "Random")
        {
            var uriWithoutQuery = uri.GetLeftPart(UriPartial.Path);
            var fileExtension = Path.GetExtension(uriWithoutQuery);

            Random rnd = new Random();
            string Builder;
            if (fileName == "Random")
                Builder = "FILEX" + Convert.ToString(rnd.Next(5, 5500));
            else
                Builder = fileName;

            var path = Path.Combine(directoryPath, $"{Builder}{fileExtension}");
            Directory.CreateDirectory(directoryPath);

            using (WebClient client = new WebClient())
            {
                client.DownloadFile(uri, path);
            }

        }

        
    }
}
