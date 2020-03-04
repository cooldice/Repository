using System;
using System.IO;

namespace RepositoryLib
{
    public class Downloader
    {
        static public bool Download(string rootPath, string uri)
        {
            // check root path
            if (!checkDirectory(rootPath))
            {
                return false;
            }

            // check uri
            if (!checkURI(uri))
            {
                return false;
            }

            // download
            string uriPath = Config.RootPath + uri;
            try
            {
                File.Copy(uriPath, rootPath + @"\" + uri);
            }
            catch (Exception e)
            {
                Log.Exception(e);
                return false;
            }
            return true;
        }

        static private bool checkDirectory(string path)
        {
            // todo impl
            return true;
        }

        static private bool checkURI(string uri)
        {
            // todo impl
            return true;
        }
    }
}
