using System;
using System.IO;
using System.Net;
using NUnit.Framework;

namespace ImageD.IntegrationTests
{
    [TestFixture]
    public class ImageDownloaderTests
    {
        [Test]
        public void Test()
        {
            const string DOWNLOAD_PATH = @"C:\temp\";
            string fileName = @"Test-" + Guid.NewGuid();
            const string URL = @"https://www.atlassian.com//wac/software/jira/tourBlocks/0/screenshotTourSection/0/imageBinary/jiraagile-02_whyja_1_flexibleplanning.png";

            WebProxy proxy = new WebProxy("aujcproxy", 80)
                             {
                                 Credentials = CredentialCache.DefaultCredentials
                             };

            WebClient webClient = new WebClient
                            {
                                Proxy = proxy
                            };


            ImageDownloader downloader = new ImageDownloader(webClient);

            string downloadLocationPath = downloader.DownloadImage(DOWNLOAD_PATH, fileName, URL);

            Assert.IsTrue(File.Exists(downloadLocationPath));
        }
    }
}
