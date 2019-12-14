using SRM.Logic.Classes;

namespace SRM.ViewModels
{
    public static class ServerInfoViewModelExtension
    {
        public static ServerInfoViewModel GetViewModelFromData(this ServerInfo serverInfo)
        {
            return new ServerInfoViewModel
            {
                Name = serverInfo.Name,
                Address = serverInfo.Address,
                Port = serverInfo.Port,
                Password = serverInfo.Password,
                BattleEye = serverInfo.BattleEye
            };
        }

        public static ServerInfo GetDataFromViewModel(this ServerInfoViewModel serverInfoViewModel)
        {
            return new ServerInfo
            {
                Name = serverInfoViewModel.Name,
                Address = serverInfoViewModel.Address,
                Port = serverInfoViewModel.Port,
                Password = serverInfoViewModel.Password,
                BattleEye = serverInfoViewModel.BattleEye
            };
        }
    }
}
