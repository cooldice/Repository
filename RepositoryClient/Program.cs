using System;
using RepositoryLib;

namespace RepositoryClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Repository Client");

            samplePath = @"..\..\..\..\sample\";
            sourceRootPath = samplePath + @"source\";
            repositoryRootPath = samplePath + @"repository\";
            downloadRootPath = samplePath + @"download\";

            // cleanup download path & repository path files
            {
                cleanup(downloadRootPath);
                cleanup(repositoryRootPath);
            }

            if (!Uploader.Upload(sourceRootPath + @"s.txt"))
            {
                Console.WriteLine("[ERROR], Uploader.Upload fail");
                return;
            }
            Console.WriteLine("[DEBUG], Uploader.Upload success");

            if (!Downloader.Download(downloadRootPath, @"s.txt"))
            {
                Console.WriteLine("[ERROR], Downloader.Download fail");
                return;
            }
            Console.WriteLine("[DEBUG], Downloader.Download success");
        }

        static void cleanup(string path)
        {
            string[] flist = System.IO.Directory.GetFiles(path);
            foreach (string fname in flist)
            {
                System.IO.File.Delete(fname);
//                Console.WriteLine("[TRACE], cleanup, file {0}", fname);
            }
        }

        static private string samplePath = "";
        static private string downloadRootPath = "";
        static private string sourceRootPath = "";
        static private string repositoryRootPath = "";
    }
}
