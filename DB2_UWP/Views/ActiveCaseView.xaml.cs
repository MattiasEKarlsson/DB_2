using DataAccessLibrary.Services;
using System;
using System.Threading;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace DB2_UWP.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ActiveCaseView : Page
    {
        public ActiveCaseView()
        {
            this.InitializeComponent();

            lvNewOutput.ItemsSource = DataAccess.GetAllActive();
            
        }

        private async void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Object selectedIteam = cbStatus.SelectedItem;
                string status = Convert.ToString(selectedIteam);

                if (status != string.Empty && tbChooseCaseId.Text != string.Empty)
                {
                    await DataAccess.UpdateAsync(Convert.ToInt32(tbChooseCaseId.Text), status);
                    Thread.Sleep(50);
                    lvNewOutput.ItemsSource = DataAccess.GetAllActive();
                    cbStatus.SelectedIndex = -1;
                }
            }
            catch { }
        }
    }
}
