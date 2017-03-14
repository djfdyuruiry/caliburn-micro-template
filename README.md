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

Platform & Library Versions:

- .NET 4.5.2 
- C# 6 (Visual Studio 2015)
- Caliburn.Micro 3.0.3
- SimpleInjector 3.3.2
