using System;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using SRM.Logic.Classes;
using SRM.Logic.Helpers;

namespace SRM.Logic.Managers
{
    public class RepoManager
    {
        public void CreateRepository(RepoProfile repoProfile, string modFolderPath, string swiftyCliPath, string repoSourceFolderPath)
        {
            // create repo source folder
            var diSourceFolder = new DirectoryInfo(Path.Combine(repoSourceFolderPath, IoHelper.SanitizeFolderName(repoProfile.Name)));
            if (!diSourceFolder.Exists)
            {
                diSourceFolder.Create();
            }

            // clean source directory from files and folders
            foreach (var file in diSourceFolder.EnumerateFiles())
            {
                file.Delete();
            }

            foreach (var dir in diSourceFolder.EnumerateDirectories())
            {
                dir.Delete(true);
            }

            // set the source folder
            repoProfile.Repository.BasePath = diSourceFolder.FullName;

            // clean target directory from files and folders
            var diTargetFolder = new DirectoryInfo(repoProfile.Repository.TargetPath);
            if (!diTargetFolder.Exists)
            {
                diTargetFolder.Create();
            }

            foreach (var file in diTargetFolder.EnumerateFiles())
            {
                file.Delete();
            }

            foreach (var dir in diTargetFolder.EnumerateDirectories())
            {
                dir.Delete(true);
            }


            // copy repo.png
            var fiRepoImage = new FileInfo(repoProfile.Repository.ImagePath);
            if (!fiRepoImage.Exists)
            {
                throw new InvalidOperationException($"repo.png at '{repoProfile.Repository.ImagePath}' does not exist.");
            }

            fiRepoImage.CopyTo(Path.Combine(diSourceFolder.FullName, Constants.RepoImageFileName), true);


            // copy icon.png
            var fiRepoIcon = new FileInfo(repoProfile.Repository.IconPath);
            if (!fiRepoIcon.Exists)
            {
                throw new InvalidOperationException($"icon.png at '{repoProfile.Repository.IconPath}' does not exist.");
            }

            fiRepoImage.CopyTo(Path.Combine(diSourceFolder.FullName, Constants.RepoIconFileName), true);


            // create repo.json
            var swiftyRepo = SwiftyJsonHelper.MapToSwifty(repoProfile);
            var fiRepoJson = new FileInfo(Path.Combine(diSourceFolder.FullName, Constants.RepoConfigFileName));

            var serializer = new JsonSerializer
            {
                Formatting = Formatting.Indented,
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };

            using (var sr = fiRepoJson.CreateText())
            {
                serializer.Serialize(sr, swiftyRepo);
            }


            // create Junctions in source folder
            foreach (var mod in repoProfile.Repository.Mods)
            {
                JunctionPoint.Create(Path.Combine(modFolderPath, mod), Path.Combine(diSourceFolder.FullName, mod), true);
            }

            // delete old mod.srf files
            foreach (var dir in diSourceFolder.EnumerateDirectories())
            {
                var fiModSrf = new FileInfo(Path.Combine(dir.FullName, Constants.ModDescriptionFileName));
                if (fiModSrf.Exists)
                {
                    fiModSrf.Delete();
                }
            }


            // execute swifty-cli
            ProcessHelper.ExecuteProcess($"\"{swiftyCliPath}\" create \"{fiRepoJson.FullName}\" \"{repoProfile.Repository.TargetPath}\" --nocopy");


            foreach (var dir in diTargetFolder.EnumerateDirectories())
            {
                var modName = repoProfile.Repository.Mods.Single(m => m.Equals(dir.Name, StringComparison.OrdinalIgnoreCase));

                // in the target folder rename created mod folders to temp
                dir.MoveTo($"{dir.FullName}_temp");


                // create mod junction
                var newModJunctionPath = Path.Combine(diTargetFolder.FullName, modName);
                JunctionPoint.Create(Path.Combine(modFolderPath, modName), newModJunctionPath, true);

                // move srf file to junction folder
                var fiModSrf = new FileInfo(Path.Combine(dir.FullName, Constants.ModDescriptionFileName));
                var newModSrfPath = Path.Combine(newModJunctionPath, Constants.ModDescriptionFileName);
                if (File.Exists(newModSrfPath))
                {
                    File.Delete(newModSrfPath);
                }
                fiModSrf.MoveTo(newModSrfPath);

                // delete temp folder
                dir.Delete(true);
            }

        }
    }
}
