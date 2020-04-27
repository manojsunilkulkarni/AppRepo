using System.ComponentModel;

using Xamarin.Forms;

namespace HelloWorldApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            DisplayLabel.Text = HelperLibrary.MyHelpers.GetWelcomeMessage();
        }
    }
}
