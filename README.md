# NavigationFramework4WPF
=======================

Simple Navigation Framework for WPF

这个项目是针对MVVM模式下，基于WPF Frame的简单页面导航框架。实现了在View Model（视图模型）中处理OnNavigatedTo（导航入）和OnNavigatedFrom（导航出）事件的功能。

# 原理

通过监听Frame的Navigating和Navigated事件，使ViewModel继承约束了OnNavigatedTo和OnNavigatedFrom虚方法的NavigationViewModelBase视图模型基类，实现在视图模型中处理"导航入"和“导航出”的事件逻辑。

![Navigation Lifetime](http://i.msdn.microsoft.com/dynimg/IC78024.png)

参考MSDN [Navigation Lifetime]: http://msdn.microsoft.com/en-us/library/ms750478.aspx#Navigation Lifetime


