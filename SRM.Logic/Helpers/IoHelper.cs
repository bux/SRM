using System.IO;

namespace SRM.Logic.Helpers
{
    public static class IoHelper
    {
        public static string SanitizeFolderName(string name)
        {
            foreach (var invalidchar in Path.GetInvalidFileNameChars())
            {
                name = name.Replace(invalidchar, '_');
            }

            return name;
        }
    }
}
