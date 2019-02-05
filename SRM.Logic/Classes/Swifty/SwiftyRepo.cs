using System.Collections.Generic;

namespace SRM.Logic.Classes.Swifty
{
    public class SwiftyRepo
    {
        public string RepoName { get; set; }
        public string BasePath { get; set; }
        public string ClientParameters { get; set; }

        public List<SwiftyMod> RequiredMods { get; set; }
        public List<SwiftyMod> OptionalMods { get; set; }

        public List<SwiftyServer> Servers { get; set; }

        public SwiftyAuthentication RepoBasicAuthentication { get; set; }
    }
}
