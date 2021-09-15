using BindingCrashCourse.MVVM.ViewModels;
using System;
using System.Windows;

namespace BindingCrashCourse
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public BindingPlayGroundViewModel ViewModel 
        {
            get 
            {
                if (this.DataContext is BindingPlayGroundViewModel)
                {
                    return this.DataContext as BindingPlayGroundViewModel;
                }
                else
                {
                    return null;
                }
            }
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Click_GenerateRandomInts(object sender, RoutedEventArgs e)
        {
            ViewModel.RandomInts = UsefulFunctions.GenerateListOfRandomInts(1, 100);
        }

        private void Click_GenerateRandomInt(object sender, RoutedEventArgs e)
        {
            ViewModel.JustAString = new Random().Next().ToString();
        }

        private void Click_PrintJustAString(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(ViewModel.JustAString);
        }
    }
}
