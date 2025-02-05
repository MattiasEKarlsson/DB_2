﻿using DataAccessLibrary.Models;
using DataAccessLibrary.Services;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace DB2_UWP.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AddCaseView : Page
    {
        public AddCaseView()
        {
            this.InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (tbxClientname.Text != string.Empty && tbxTitle.Text != string.Empty && tbxProblem.Text != string.Empty)
                {
                    Case cases = new Case(tbxClientname.Text, tbxTitle.Text, tbxProblem.Text, "New");
                    await DataAccess.AddAsync(cases);
                    lvOutput.ItemsSource = DataAccess.GetAllNew();

                    tbxClientname.Text = string.Empty;
                    tbxTitle.Text = string.Empty;
                    tbxProblem.Text = string.Empty;
                }
            }
            catch { }
        }
    }
}
