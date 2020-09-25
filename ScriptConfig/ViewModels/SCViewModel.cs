using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptConfig.ViewModels
{
	public abstract class SCViewModel : ViewModelBase
	{
		public SCViewModel()
		{
			SetupViewModel();
		}

		public abstract void SetupViewModel();
	}
}
