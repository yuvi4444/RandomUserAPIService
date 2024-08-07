using Xamarin.Forms;
using Microsoft.Extensions.DependencyInjection;
using RandomUserAPIService.Services;
using Microsoft.Extensions.Http;


namespace RandomUserAPIService
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var services = new ServiceCollection();
            ConfigureServices(services);
            var serviceProvider = services.BuildServiceProvider();

            MainPage = new Views.MainPage(serviceProvider.GetRequiredService<ViewModels.MainPageViewModel>());
        }

        private void ConfigureServices(IServiceCollection services)
        {
            services.AddHttpClient<IUserService, UserService>();
            services.AddSingleton<ViewModels.MainPageViewModel>();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
