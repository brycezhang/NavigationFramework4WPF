using System.Windows.Input;
using GalaSoft.MvvmLight.Command;

namespace SimpleNavigationFramework.Demo.ViewModel
{
    public class Page2ViewModel : NavigationViewModelBase
    {
        public Page2ViewModel()
        {
            GoBackCommand = new RelayCommand(() =>
                {
                    if (NavigationService.CanGoBack)
                        NavigationService.GoBack();
                });
        }

        public ICommand GoBackCommand { get; private set; }

        public override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e, System.Windows.Navigation.NavigationMode mode)
        {
            System.Diagnostics.Debug.WriteLine("Navigated To Page 2, NavigationMode is " + mode);
        }

        public override void OnNavigatedFrom(System.Windows.Navigation.NavigatingCancelEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Navigated From Page 2, NavigationMode is " + e.NavigationMode);
        }
    }
}
