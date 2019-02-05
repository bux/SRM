using System.IO;
using SRM.Logic.Helpers;

namespace SRM.Logic.Managers
{
    public class JunctionManager
    {
        private void CreateModJunction(DirectoryInfo sourceDir, DirectoryInfo targetDir)
        {
            JunctionPoint.Create(sourceDir.FullName, Path.Combine(targetDir.FullName, sourceDir.Name), true);
        }
    }
}
