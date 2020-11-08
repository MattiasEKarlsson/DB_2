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

        private void NavView_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                ContentFrame.Navigate(typeof(ActiveCaseView));
            }
            catch { }
        }

        private void NavView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            try
            {
                NavigationViewItem item = args.SelectedItem as NavigationViewItem;

                switch (item.Tag.ToString())
                {
                    case "AddCaseView":
                        ContentFrame.Navigate(typeof(AddCaseView));
                        break;

                    case "ActiveCaseView":
                        ContentFrame.Navigate(typeof(ActiveCaseView));
                        break;

                    case "CompletedCaseView":
                        ContentFrame.Navigate(typeof(CompletedCaseView));
                        break;

                }
            }
            catch { }
            
                
            
            
        }
    }
}
