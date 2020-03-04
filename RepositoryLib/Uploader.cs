using System;
using System.IO;

namespace RepositoryLib
{
    public class Uploader
    {
        /// <summary>
        /// repository server에 upload
        /// </summary>
        /// <param name="path">file</param>
        /// <returns></returns>
        static public bool Upload(string path)
        {
            if (!File.Exists(path))
            {
                Log.Error("Uploader.Upload, cannot find file, path {0}", path);
                return false;
            }

            // path에서 file name만 분리한다.
            string fname = Path.GetFileName(path);
            string uploadPath = Config.RootPath + fname;

            Log.Trace("Uploader.Upload, uploadpath {0}", uploadPath);

            if (File.Exists(uploadPath))
            { 
                Log.Error("Uploader.Upload, already exist in server, path {0}", path);
                return false;
            }

            try
            {
                File.Copy(path, uploadPath);
            }
            catch (Exception e)
            {
                Log.Exception(e);
                return false;
            }

            Log.Trace("Uploader.Upload, success, path {0}, uploadPath {1}", path, uploadPath);
            return true;
        }
    }
}
