using System.Collections.Generic;

namespace SRM.Logic.Classes
{
    public class Settings
    {
        public string SwiftyCliPath { get; set; } = string.Empty;
        public string ModsFolderPath { get; set; } = string.Empty;
        public string RepoSourceFolderPath { get; set; } = string.Empty;

        public List<RepoProfile> RepoProfiles { get; set; } = new List<RepoProfile>();
    }
}
