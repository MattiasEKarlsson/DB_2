using DataAccessLibrary.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

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
            lvNewOutput.ItemsSource = DataAccess.GetAllNew();
            lvActiveOutput.ItemsSource = DataAccess.GetAllActive();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
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
                    lvNewOutput.ItemsSource = DataAccess.GetAllNew();
                    lvActiveOutput.ItemsSource = DataAccess.GetAllActive();
                    tbChooseCaseId.Text = string.Empty;
                    cbStatus.SelectedIndex = -1;
                }
            }
            catch { }
        }
    }
}
