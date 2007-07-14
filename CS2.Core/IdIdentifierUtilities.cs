using System.IO;

namespace CS2.Core
{
    public static class IdIdentifierUtilities
    {
        public static string GetPathFromIdentifier(string identifier)
        {
            string url = identifier.Replace('\u0000', Path.DirectorySeparatorChar); // replace nulls with slashes
            return url.Substring(0, (url.LastIndexOf(Path.DirectorySeparatorChar)) - (0)); // remove date from end
        }

        public static string GetIdentifierFromFile(FileInfo file)
        {
            if(!file.Exists)
                throw new FileNotFoundException("File not found", file.FullName);

            return
                file.FullName.Replace(Path.DirectorySeparatorChar, '\u0000') + "\u0000" + file.LastWriteTime.Ticks;
        }
    }
}