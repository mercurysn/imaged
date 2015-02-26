using System.IO;
using System.Net;

namespace ImageD
{
    public class ImageDownloader
    {
        private WebClient _webClient = new WebClient();

        public ImageDownloader()
        {
            
        }

        public ImageDownloader(WebClient webClient)
        {
            _webClient = webClient;
        }


        public string DownloadImage(string downloadPath, string fileName, string url)
        {
            string downloadLocationPath = ConstructDownloadFilePath(downloadPath, fileName, url);
            using (WebClient client = _webClient)
            {
                client.DownloadFile(url, downloadLocationPath);
            }

            return downloadLocationPath;
        }

        public string ConstructDownloadFilePath(string downloadPath, string fileName, string url)
        {
            return string.Concat(downloadPath, fileName, Path.GetExtension(url));
        }
    }
}
