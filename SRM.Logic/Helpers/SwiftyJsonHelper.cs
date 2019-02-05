using System.Collections.Generic;
using System.Linq;
using SRM.Logic.Classes;
using SRM.Logic.Classes.Swifty;

namespace SRM.Logic.Helpers
{
    public static class SwiftyJsonHelper
    {
        public static SwiftyRepo MapToSwifty(RepoProfile profile)
        {
            var swiftyRepo = new SwiftyRepo
            {
                RepoName = profile.Repository.Name,
                BasePath = profile.Repository.BasePath,
                ClientParameters = profile.Repository.ClientParams,
                Servers = new List<SwiftyServer>
                {
                    new SwiftyServer
                    {
                        Name = profile.Repository.ServerInfo.Name,
                        Address = profile.Repository.ServerInfo.Address,
                        Port = profile.Repository.ServerInfo.Port,
                        Password = profile.Repository.ServerInfo.Password,
                        BattleEye = profile.Repository.ServerInfo.BattleEye
                    }
                },
                RequiredMods = profile.Repository.Mods.Select(m => new SwiftyMod {ModName = m, Enabled = true}).ToList()
            };

            return swiftyRepo;
        }
    }
}
