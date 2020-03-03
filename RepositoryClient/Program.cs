using System;
using RepositoryLib;

namespace RepositoryClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(Downloader.TEST);

            RepositoryLib.Uploader.Upload(@"c:\temp\source\s.txt");
        }
    }
}
