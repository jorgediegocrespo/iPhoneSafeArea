namespace iPhoneSafeArea
{
    using Xamarin.Forms;
    using Xamarin.Forms.PlatformConfiguration;
    using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            On<iOS>().SetUseSafeArea(true);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            //var safeInsets = On<iOS>().SafeAreaInsets();
            //safeInsets.Left = 80;
            //Padding = safeInsets;
        }
    }
}
