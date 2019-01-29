using System.IO;
using SRM.Helpers;

namespace SRM.Managers
{
    public class JunctionManager
    {
        private void CreateModJunction(DirectoryInfo sourceDir, DirectoryInfo targetDir)
        {
            JunctionPoint.Create(sourceDir.FullName, Path.Combine(targetDir.FullName, sourceDir.Name), true);
        }
    }
}
