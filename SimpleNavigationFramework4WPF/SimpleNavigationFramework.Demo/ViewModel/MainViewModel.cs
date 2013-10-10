using System;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace SimpleNavigationFramework.Demo.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        private NavigationMode _navigationMode = NavigationMode.New;
        private object _content;
        private NavigationService _navigationService;
        private Uri _source;

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            NavigatingCommand = new RelayCommand<NavigatingCancelEventArgs>(NavigatingHandler);
            NavigatedCommand = new RelayCommand<NavigationEventArgs>(NavigatedHandler);
        }

        public Uri Source
        {
            get { return _source; }
            set
            {
                _source = value;
                RaisePropertyChanged(() => Source);
            }
        }

        public object Content
        {
            get { return _content; }
            set
            {
                _content = value;
                RaisePropertyChanged(() => Content);
            }
        }

        public NavigationService NavigationService
        {
            get { return _navigationService; }
            set
            {
                _navigationService = value;
                RaisePropertyChanged(() => NavigationService);
            }
        }

        public ICommand NavigatingCommand { get; private set; }
        public ICommand NavigatedCommand { get; private set; }

        private void NavigatingHandler(NavigatingCancelEventArgs e)
        {
            // 记录离开当前页面的NavigationMode
            _navigationMode = e.NavigationMode;

            var page = Content as Page;
            if (page != null)
            {
                var viewModel = page.DataContext as NavigationViewModelBase;
                if (viewModel != null)
                {
                    viewModel.OnNavigatedFrom(e);
                }
            }
        }

        private void NavigatedHandler(NavigationEventArgs e)
        {
            var page = Content as Page;
            if (page != null)
            {
                var viewModel = page.DataContext as NavigationViewModelBase;
                if (viewModel != null)
                {
                    viewModel.NavigationService = NavigationService.GetNavigationService(page);
                    viewModel.OnNavigatedTo(e, _navigationMode);// 传递NavigationMode
                }
            }
        }
    }
}