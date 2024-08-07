using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using RandomUserAPIService.Models;
using RandomUserAPIService.Services;

namespace RandomUserAPIService.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        private readonly IUserService _userService;
        private User _user;

        public MainPageViewModel(IUserService userService)
        {
            _userService = userService;
            LoadRandomUserAsync();
        }

        public User User
        {
            get => _user;
            set
            {
                _user = value;
                OnPropertyChanged();
            }
        }

        private async Task LoadRandomUserAsync()
        {
            User = await _userService.GetRandomUserAsync();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
