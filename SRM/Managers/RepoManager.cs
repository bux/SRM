using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using SRM.Classes;
using SRM.Helpers;

namespace SRM.Managers
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

            // empty target folder
            var diTargetFolder = new DirectoryInfo(repoProfile.Repository.TargetPath);
            if (!diTargetFolder.Exists)
            {
                throw new InvalidOperationException($"Target folder '{repoProfile.Repository.TargetPath}' does not exist.");
            }

            foreach (var file in diTargetFolder.EnumerateFiles())
            {
                file.Delete();
            }

            foreach (var dir in diTargetFolder.EnumerateDirectories())
            {
                dir.Delete(true);
            }


            // create repo.json
            var swiftyRepo = SwiftyJsonHelper.MapToSwifty(repoProfile);
            var fiRepoJson = new FileInfo(Path.Combine(diSourceFolder.FullName, "repo.json"));

            var serializer = new JsonSerializer
            {
                Formatting = Formatting.Indented,
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };

            using (var sr = fiRepoJson.CreateText())
            {
                serializer.Serialize(sr, swiftyRepo);
            }


            // copy repo.png
            var fiRepoImage = new FileInfo(repoProfile.Repository.ImagePath);
            if (!fiRepoImage.Exists)
            {
                throw new InvalidOperationException($"repo.png at '{repoProfile.Repository.ImagePath}' does not exist.");
            }

            fiRepoImage.CopyTo(Path.Combine(diSourceFolder.FullName, "repo.png"), true);


            // create Junctions in source folder
            foreach (var mod in repoProfile.Repository.Mods)
            {
                JunctionPoint.Create(Path.Combine(modFolderPath, mod), Path.Combine(diSourceFolder.FullName, mod), true);
            }

            // execute swifty-cli
            // create "D:\Swifty Repos\Infantry-Only\repo.json" "D:\Webserver\Repos\Infantry-Only"
            ProcessHelper.ExecuteProcess($"\"{swiftyCliPath}\" create \"{fiRepoJson.FullName}\" \"{repoProfile.Repository.TargetPath}\" --nocopy");

            // create Mod Junctions
        }
    }
}
