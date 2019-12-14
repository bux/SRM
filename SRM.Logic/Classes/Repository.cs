using System.Collections.Generic;
using Newtonsoft.Json;

namespace SRM.Logic.Classes
{
    public class Repository
    {
        public string Name { get; set; } = string.Empty;
        public string TargetPath { get; set; } = string.Empty;
        public string ImagePath { get; set; } = string.Empty;
        public string IconPath { get; set; } = string.Empty;
        public string ClientParams { get; set; } = "-noSplash -skipIntro -noPause";
        public ServerInfo ServerInfo { get; set; } = new ServerInfo();
        public List<string> Mods { get; set; } = new List<string>();
        public List<string> OptionalMods { get; set; } = new List<string>();

        [JsonIgnore]
        public string BasePath { get; set; } = string.Empty;

    }
}
