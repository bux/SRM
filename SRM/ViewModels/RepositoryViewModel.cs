using System.ComponentModel;

namespace SRM.ViewModels
{
    public class RepositoryViewModel
    {
        public string Name { get; set; }
        public string TargetPath { get; set; }
        public string ImagePath { get; set; }
        public string IconPath { get; set; }
        public string ClientParams { get; set; }
        public ServerInfoViewModel ServerInfo { get; set; }
        public BindingList<string> Mods { get; set; }
        public BindingList<string> OptionalMods { get; set; }

        public string BasePath { get; set; } = string.Empty;
    }
}
