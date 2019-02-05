using System;

namespace SRM.Logic.Enums
{
    [Flags]
    public enum RepoValidation
    {
        Valid = 1,
        ModsMissing = 2,
        RepoNameMissing = 4,
        TargetPathMissing = 8,
        ImagePathMissing = 16
    }
}
