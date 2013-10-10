using System.Windows.Navigation;
using System.Windows.Threading;
using GalaSoft.MvvmLight;

namespace SimpleNavigationFramework
{
    /// <summary>
    /// 导航视图模型抽象基类
    /// </summary>
    public abstract class NavigationViewModelBase : ViewModelBase
    {
        public Dispatcher Dispatcher { get; set; }

        public NavigationService NavigationService { get; set; }

        public virtual void OnNavigatedTo(NavigationEventArgs e, NavigationMode mode) { }

        public virtual void OnNavigatedFrom(NavigatingCancelEventArgs e) { }
    }
}
