using System;
using RepositoryLib;

namespace RepositoryClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Uploader.Upload(@"c:\temp\source\s.txt");
            Downloader.Download(@"c:\temp\download");
        }
    }
}
