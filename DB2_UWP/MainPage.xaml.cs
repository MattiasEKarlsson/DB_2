using DB2_UWP.Views;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace DB2_UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void ActiveCases_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(ActiveCaseView));
        }

        private void btnCompCases_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(CompletedCaseView));
        }

        private void btnAddCase_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(AddCaseView));
        }

  
    }
}
