# caliburn-micro-template
A basic Caliburn Micro template for WPF.

This template should be used as an example of how to setup a basic WPF app using Calibrun Micro and dependency injection.

Project contains:

- Required NuGet packages added
- App bootstrapper 
- App.xaml configuration
- Shell view & model
- Simple Injector IOC container integration with bootstrapper
  - AppContainer defines bindings and AppBootstrapper consumes them
  - Default minimal binding for Caliburn Micro added
