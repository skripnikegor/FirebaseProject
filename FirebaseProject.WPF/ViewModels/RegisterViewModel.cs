using MVVMEssentials.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirebaseProject.WPF.ViewModels
{
    class RegisterViewModel : ViewModelBase
    {
		private string _email;

		public string Email
		{
			get
			{
                return _email;
            }
			set
			{
                _email = value;
				OnPropertyChanged(nameof(Email));
            }
		}

        private string _username;

        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
                OnPropertyChanged(nameof(Username));
            }
        }
    }
}
