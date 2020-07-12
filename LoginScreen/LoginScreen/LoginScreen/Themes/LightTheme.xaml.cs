using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace LoginScreen.Themes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [Preserve(AllMembers = true)]
    public partial class LightTheme : ResourceDictionary
    {
        public LightTheme()
        {
            InitializeComponent();
        }
    }
}