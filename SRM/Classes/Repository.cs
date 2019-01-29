using System.Collections.Generic;

namespace SRM.Classes
{
    public class Repository
    {
        public string Name { get; set; } = string.Empty;
        public string Path { get; set; } = string.Empty;
        public string ImagePath { get; set; } = string.Empty;
        public string ClientParams { get; set; } = "-noSplash  -skipIntro  -noPause";
        public ServerInfo ServerInfo { get; set; } = new ServerInfo();
        public List<string> Mods { get; set; } = new List<string>();
    }
}
