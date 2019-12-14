using System.Collections.Generic;
using System.ComponentModel;
using SRM.Logic.Classes;

namespace SRM.ViewModels
{
    public static class RepositoryViewModelExtension
    {
        public static RepositoryViewModel GetViewModelFromData(this Repository repository)
        {
            return new RepositoryViewModel
            {
                Name = repository.Name,
                TargetPath = repository.TargetPath,
                ImagePath = repository.ImagePath,
                IconPath = repository.IconPath,
                ClientParams = repository.ClientParams,
                ServerInfo = repository.ServerInfo.GetViewModelFromData(),
                Mods = new BindingList<string>(repository.Mods),
                OptionalMods = new BindingList<string>(repository.OptionalMods),
                BasePath = repository.BasePath
            };
        }

        public static Repository GetDataFromViewModel(this RepositoryViewModel repositoryViewModel)
        {
            return new Repository
            {
                Name = repositoryViewModel.Name,
                TargetPath = repositoryViewModel.TargetPath,
                ImagePath = repositoryViewModel.ImagePath,
                IconPath = repositoryViewModel.IconPath,
                ClientParams = repositoryViewModel.ClientParams,
                ServerInfo = repositoryViewModel.ServerInfo.GetDataFromViewModel(),
                Mods = new List<string>(repositoryViewModel.Mods),
                OptionalMods = new List<string>(repositoryViewModel.OptionalMods),
                BasePath = repositoryViewModel.BasePath
            };
        }
    }
}
