using System;
using System.Collections.Generic;
using System.Linq;
using SRM.Logic.Classes;

namespace SRM.Helpers
{
    public static class ValidationHelper
    {
        public static bool IsProfileNameValid(IEnumerable<RepoProfile> allProfiles, string newProfileName)
        {
            return !string.IsNullOrEmpty(newProfileName) && !allProfiles.Any(p => p.Name.Equals(newProfileName, StringComparison.OrdinalIgnoreCase));
        }
    }
}
