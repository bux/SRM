using SRM.Logic.Classes;

namespace SRM.ViewModels
{
    public static class RepoProfileViewModelExtension
    {
        public static RepoProfileViewModel GetViewModelFromData(this RepoProfile repoProfile)
        {
            return new RepoProfileViewModel
            {
                Name = repoProfile.Name,
                Repository = repoProfile.Repository.GetViewModelFromData()
            };
        }

        public static RepoProfile GetDataFromViewModel(this RepoProfileViewModel repoProfileViewModel)
        {
            return new RepoProfile
            {
                Name = repoProfileViewModel.Name,
                Repository = repoProfileViewModel.Repository.GetDataFromViewModel()
            };
        }
    }
}
