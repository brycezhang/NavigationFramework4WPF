# Simple Navigation Framework for WPF

这个项目是针对`MVVM`模式下，基于`WPF Frame`的简单页面导航框架。实现了在View Model（视图模型）中处理`OnNavigatedTo`（导航入）和`OnNavigatedFrom`（导航出）事件的功能。

# 原理

通过监听Frame的Navigating和Navigated事件，使ViewModel继承约束了`OnNavigatedTo`和`OnNavigatedFrom`虚方法的`NavigationViewModelBase`视图模型基类，实现在视图模型中处理"导航入"和“导航出”的事件逻辑。

![Navigation Lifetime](http://i.msdn.microsoft.com/dynimg/IC78024.png)

参考MSDN [Navigation Lifetime](http://msdn.microsoft.com/en-us/library/ms750478.aspx#Navigation%20Lifetime)


