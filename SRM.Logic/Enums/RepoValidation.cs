using System;

namespace SRM.Logic.Enums
{
    [Flags]
    public enum RepoValidation
    {
        Valid = 1 << 0,
        ModsMissing = 1 << 1,
        RepoNameMissing = 1 << 2,
        TargetPathMissing = 1 << 3,
        ImagePathMissing = 1 << 4
    }
}
