using ScriptConfig.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptConfig.IoC
{
	public interface IFileService
	{
		void SaveSettings(SettingsModel settings);
		SettingsModel LoadSettings();
	}
}
