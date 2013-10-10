using System;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;

namespace SimpleNavigationFramework.Demo.ViewModel
{
    public class Page1ViewModel : NavigationViewModelBase
    {
        public Page1ViewModel()
        {
            NavPage2Command = new RelayCommand(() => NavigationService.Navigate(new Uri("/Views/Page2.xaml", UriKind.Relative)));
        }

        public ICommand NavPage2Command { get; private set; }

        public override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e, System.Windows.Navigation.NavigationMode mode)
        {
            System.Diagnostics.Debug.WriteLine("Navigated To Page 1, NavigationMode is " + mode);
        }

        public override void OnNavigatedFrom(System.Windows.Navigation.NavigatingCancelEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Navigated From Page 1, NavigationMode is " + e.NavigationMode);
        }
    }
}
