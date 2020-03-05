using System;
using RepositoryLib;

namespace RepositoryClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Repository Client");

            // set path
            _samplePath = @"..\..\..\..\sample\";
            _sourceRootPath = _samplePath + @"source\";
            _repositoryRootPath = _samplePath + _repositoryRootFolder;
            _downloadRootPath = _samplePath + @"download\";

            // cleanup download path & repository path files
            {
                cleanup(_downloadRootPath);
                cleanup(_repositoryRootPath);
            }

            testSampleSingleFile();
        }

        static void testSampleSingleFile()
        {
            string fname = "s.txt";
            string ip = "127.0.0.1";

            RepositoryLib.Config.Initialize(ip, _repositoryRootFolder);

            if (!Uploader.Upload(_sourceRootPath + fname))
            {
                Console.WriteLine("[ERROR], Uploader.Upload fail");
                return;
            }
            Console.WriteLine("[DEBUG], Uploader.Upload success");

            if (!Downloader.Download(_downloadRootPath, fname))
            {
                Console.WriteLine("[ERROR], Downloader.Download fail");
                return;
            }
            Console.WriteLine("[DEBUG], Downloader.Download success");

        }

        static void cleanup(string path)
        {
            string[] flist = System.IO.Directory.GetFiles(path);
            foreach (string fpath in flist)
            {
                string fname = System.IO.Path.GetFileName(fpath);
                // .으로 시작하는 파일은 삭제하지 않는다.
                if (fname.StartsWith("."))
                    continue;
                System.IO.File.Delete(fpath);
//                Console.WriteLine("[TRACE], cleanup, file {0}", fname);
            }
        }

        static private string _samplePath = "";
        static private string _downloadRootPath = "";
        static private string _sourceRootPath = "";
        static private string _repositoryRootPath = "";
        static private string _repositoryRootFolder = @"repository\";
    }
}
