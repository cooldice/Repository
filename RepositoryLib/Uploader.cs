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

            Log.Trace("Uploader.Upload, success, path {0}", path);
            return true;
        }
    }
}
