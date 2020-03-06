using System;
using System.IO;

namespace RepositoryLib
{
    public class Downloader
    {
        static public bool Download(string rootPath, string uri)
        {
            Log.Trace("Downloader.Download called, rootpath, {0} uri {1}", rootPath, uri);

            // check root path
            if (!checkDirectory(rootPath))
            {
                Log.Error("Downloader.Download, fail checkDirectory, rootpath {0}, uri {1}", rootPath, uri);
                return false;
            }

            // check uri
            if (!checkURI(uri))
            {
                Log.Error("Downloader.Download, fail checkURI, rootpath {0}, uri {1}", rootPath, uri);
                return false;
            }

            // download
            string repositoryLocalPath = getRepositoryURITOLocalPath(uri);
            try
            {
                File.Copy(repositoryLocalPath, rootPath + uri);
            }
            catch (Exception e)
            {
                Log.Exception(e);
                return false;
            }

            Log.Debug("Downloader.Download, success, rootpath {0}, uri {1}", rootPath, uri);
            return true;
        }

        static private bool checkDirectory(string path)
        {
            if (!Directory.Exists(path))
                return false;
            return true;
        }

        static private bool checkURI(string uri)
        {
            string path = getRepositoryURITOLocalPath(uri);
            if (!File.Exists(path))
                return false;
            return true;
        }

        static private string getRepositoryURITOLocalPath(string uri)
        {
            return Config.RootPath + uri;
        }
    }
}
