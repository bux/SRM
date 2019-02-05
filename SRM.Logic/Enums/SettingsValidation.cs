using System;

namespace SRM.Logic.Enums
{
    [Flags]
    public enum SettingsValidation
    {
        Valid = 1 << 0,
        SwiftyCliPathMissing = 1 << 1,
        ModsFolderPathMissing = 1 << 2,
        RepoSourceFolderPathMissing = 1 << 3
    }
}
