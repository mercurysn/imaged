using System;
using NUnit.Framework;

namespace ImageD.UnitTests
{
    [TestFixture]
    public class ImageDownloaderTests
    {
        [Test]
        public void TestConstructPath()
        {
            const string DOWNLOAD_PATH = @"C:\temp\";
            const string FILE_NAME = @"Test";
            const string URL = @"https://www.atlassian.com//wac/software/jira/tourBlocks/0/screenshotTourSection/0/imageBinary/jiraagile-02_whyja_1_flexibleplanning.png";

            ImageDownloader downloader = new ImageDownloader();

            var downloadLocation = downloader.ConstructDownloadFilePath(DOWNLOAD_PATH, FILE_NAME, URL);

            Assert.AreEqual(@"C:\temp\Test.png", downloadLocation);
        }

    }
}
