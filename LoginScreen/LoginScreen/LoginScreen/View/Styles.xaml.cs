using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace LoginScreen.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [Preserve(AllMembers = true)]
    public partial class Styles : ResourceDictionary
    {
        public Styles()
        {
            InitializeComponent();
        }
    }
}