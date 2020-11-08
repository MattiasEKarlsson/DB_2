using DataAccessLibrary.Services;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace DB2_UWP.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CompletedCaseView : Page
    {
        public CompletedCaseView()
        {
            this.InitializeComponent();
            try
            {
                lvOutput.ItemsSource = DataAccess.GetAllCompleted();
            }
            catch { }
        }
    }
}
