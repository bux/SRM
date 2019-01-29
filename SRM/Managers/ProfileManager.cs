using System.Linq;
using Newtonsoft.Json;
using SRM.Classes;

namespace SRM.Managers
{
    public class ProfileManager
    {
        public RepoProfile CreateProfile(string profileName)
        {
            return new RepoProfile
            {
                Name = profileName
            };
        }

        public void AddProfile(Settings settings, RepoProfile newProfile)
        {
            settings.RepoProfiles.Add(newProfile);
            settings.RepoProfiles = settings.RepoProfiles.OrderBy(p => p.Name).ToList();
        }

        public RepoProfile RenameProfile(RepoProfile profile, string newProfileName)
        {
            profile.Name = newProfileName;
            return profile;
        }

        public RepoProfile DuplicateProfile(RepoProfile profile)
        {
            // using JSON to deep copy the object
            var serialized = JsonConvert.SerializeObject(profile);
            var deserialized = JsonConvert.DeserializeObject<RepoProfile>(serialized);
            deserialized.Name = "Copy of " + deserialized.Name;

            return deserialized;
        }
    }
}
