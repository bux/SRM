using System;
using System.Collections.Generic;
using System.Linq;
using SRM.Logic.Classes;
using SRM.Logic.Enums;

namespace SRM.Logic.Helpers
{
    public static class ValidationHelper
    {
        public static bool IsProfileNameValid(IEnumerable<RepoProfile> allProfiles, string newProfileName)
        {
            return !string.IsNullOrEmpty(newProfileName) && !allProfiles.Any(p => p.Name.Equals(newProfileName, StringComparison.OrdinalIgnoreCase));
        }

        public static RepoValidation IsRepoValid(RepoProfile profile)
        {
            var result = RepoValidation.Valid;

            if (string.IsNullOrEmpty(profile.Repository.Name))
            {
                if (result.HasFlag(RepoValidation.Valid))
                {
                    result = RepoValidation.RepoNameMissing;
                }
                else
                {
                    result = result | RepoValidation.RepoNameMissing;
                }
            }

            if (string.IsNullOrEmpty(profile.Repository.TargetPath))
            {
                if (result.HasFlag(RepoValidation.Valid))
                {
                    result = RepoValidation.TargetPathMissing;
                }
                else
                {
                    result = result | RepoValidation.TargetPathMissing;
                }
            }

            if (string.IsNullOrEmpty(profile.Repository.ImagePath))
            {
                if (result.HasFlag(RepoValidation.Valid))
                {
                    result = RepoValidation.ImagePathMissing;
                }
                else
                {
                    result = result | RepoValidation.ImagePathMissing;
                }
            }

            if (string.IsNullOrEmpty(profile.Repository.IconPath))
            {
                if (result.HasFlag(RepoValidation.Valid))
                {
                    result = RepoValidation.IconPathMissing;
                }
                else
                {
                    result = result | RepoValidation.IconPathMissing;
                }
            }

            if (!profile.Repository.Mods.Any())
            {
                if (result.HasFlag(RepoValidation.Valid))
                {
                    result = RepoValidation.ModsMissing;
                }
                else
                {
                    result = result | RepoValidation.ModsMissing;
                }
            }

            return result;
        }

        public static SettingsValidation AreSettingsValid(Settings settings)
        {
            var result = SettingsValidation.Valid;

            if (string.IsNullOrEmpty(settings.SwiftyCliPath))
            {
                if (result.HasFlag(SettingsValidation.Valid))
                {
                    result = SettingsValidation.SwiftyCliPathMissing;
                }
                else
                {
                    result = result | SettingsValidation.SwiftyCliPathMissing;
                }
            }

            if (string.IsNullOrEmpty(settings.ModsFolderPath))
            {
                if (result.HasFlag(SettingsValidation.Valid))
                {
                    result = SettingsValidation.ModsFolderPathMissing;
                }
                else
                {
                    result = result | SettingsValidation.ModsFolderPathMissing;
                }
            }

            if (string.IsNullOrEmpty(settings.RepoSourceFolderPath))
            {
                if (result.HasFlag(SettingsValidation.Valid))
                {
                    result = SettingsValidation.RepoSourceFolderPathMissing;
                }
                else
                {
                    result = result | SettingsValidation.RepoSourceFolderPathMissing;
                }
            }

            return result;
        }
    }
}
