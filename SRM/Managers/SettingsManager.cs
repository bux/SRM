using System;
using System.IO;
using Newtonsoft.Json;
using SRM.Classes;

namespace SRM.Managers
{
    public class SettingsManager
    {
        private readonly FileInfo _fiSettings = new FileInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, Constants.ConfigPath));

        public SettingsManager()
        {
            if (!_fiSettings.Exists)
            {
                SaveSettings(new Settings());
            }
        }

        public void SaveSettings(Settings settings)
        {
            using (var sr = _fiSettings.CreateText())
            {
                var serializer = new JsonSerializer
                {
                    Formatting = Formatting.Indented,
                    NullValueHandling = NullValueHandling.Ignore
                };
                serializer.Serialize(sr, settings);
            }
        }

        public Settings LoadSettings()
        {
            if (_fiSettings == null)
            {
                return new Settings();
            }

            using (var sr = _fiSettings.OpenText())
            {
                var serializer = new JsonSerializer();
                var settings = (Settings) serializer.Deserialize(sr, typeof(Settings));
                return settings;
            }
        }
    }
}
