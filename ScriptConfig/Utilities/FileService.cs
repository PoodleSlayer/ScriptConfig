using Newtonsoft.Json;
using ScriptConfig.IoC;
using ScriptConfig.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptConfig.Utilities
{
	public class FileService : IFileService
	{
		public void SaveSettings(SettingsModel settings)
		{
			string filePath = GetAppSettingsFolder();
			string settingsFile = filePath + @"settings.json";
			string jsonText = JsonConvert.SerializeObject(settings, Formatting.Indented);
		}

		public SettingsModel LoadSettings()
		{
			string filePath = GetAppSettingsFolder();
			string settingsFile = filePath + @"settings.json";
			if (!File.Exists(settingsFile))
			{
				return new SettingsModel();
			}

			string jsonText = File.ReadAllText(settingsFile);
			if (String.IsNullOrEmpty(jsonText))
			{
				return new SettingsModel();
			}

			SettingsModel settings = JsonConvert.DeserializeObject<SettingsModel>(jsonText);
			App.Settings = settings;
			return settings;
		}

		private string GetAppSettingsFolder()
		{
			string appFolder = AppDomain.CurrentDomain.BaseDirectory;
			string settingsFolder = appFolder + @"settings\";
			if (!Directory.Exists(settingsFolder))
			{
				DirectoryInfo dirInfo = Directory.CreateDirectory(settingsFolder);
			}
			return settingsFolder;
		}
	}
}
