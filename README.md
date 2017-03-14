# caliburn-micro-template
A basic Caliburn Micro template for WPF with IOC container integration.

This template should be used as an example of how to setup a basic WPF app using Calibrun Micro and dependency injection.

Project contains:

- Required NuGet packages added
- App bootstrapper 
- App.xaml configuration
- Shell view & model
- Simple Injector IOC container integration with bootstrapper
  - AppContainer defines bindings and AppBootstrapper consumes them
  - Default minimal binding for Caliburn Micro added

*Project uses .NET 4.5.2 and C# 6; created using Visual Studio 2015*
