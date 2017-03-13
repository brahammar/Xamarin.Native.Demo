#if __ANDROID__
using XamarinFormsDemo.Droid;
#elif __IOS__
using XamarinFormsDemo.iOS.Helpers;
#elif WINDOWS_UWP
using XamarinFormsDemo.UWP.Helpers;
#endif
using XamarinFormsDemo.Helpers;
using XamarinFormsDemo.Interfaces;
using XamarinFormsDemo.Services;
using XamarinFormsDemo.Model;

namespace XamarinFormsDemo
{
    public partial class App 
    {
        public App()
        {
        }

        public static void Initialize()
        {
            ServiceLocator.Instance.Register<IDataStore<Item>, MockDataStore>();
            ServiceLocator.Instance.Register<IMessageDialog, MessageDialog>();
            ServiceLocator.Instance.Register<IDataStore<Item>, MockDataStore>();
        }
    }
}