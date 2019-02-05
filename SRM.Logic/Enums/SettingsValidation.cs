using System;

namespace SRM.Logic.Enums
{
    [Flags]
    public enum SettingsValidation
    {
        Valid = 1,
        SwiftyCliPathMissing = 2,
        ModsFolderPathMissing = 4,
        RepoSourceFolderPathMissing = 8
    }
}
