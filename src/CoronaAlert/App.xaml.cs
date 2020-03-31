using CoronaAlert.Views;
using Prism.Ioc;
using Prism.Unity;

namespace CoronaAlert
{
    public partial class App : PrismApplication
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<MainPage>();
        }

        protected override void OnInitialized()
        {
            //throw new System.NotImplementedException();
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
