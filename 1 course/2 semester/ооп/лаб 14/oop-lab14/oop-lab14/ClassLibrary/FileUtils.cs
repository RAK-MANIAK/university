using System;
using System.IO;

namespace ClassLibrary
{
    public class FileUtils
    {
        public static bool IsDirectory(string path)
        {
            return File.GetAttributes(path).HasFlag(FileAttributes.Directory);
        }

        public static string GetRelativePath(string fullPath, string Path)
        {
            if (Path.EndsWith("\\") == false)
            {
                Path += "\\";
            }

            var baseUri = new Uri(Path);
            var fullUri = new Uri(fullPath);

            return baseUri.MakeRelativeUri(fullUri).ToString().Replace("/", "\\");
        }
    }
}
