using System.Collections.Generic;
using System.Windows;
using Caliburn.Micro;
using System;

namespace CaliburnMicroTemplate
{
    public class AppBootstrapper : BootstrapperBase
    {
        private readonly AppContainer _appContainer;

        public AppBootstrapper()
        {
            _appContainer = new AppContainer();

            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e) => DisplayRootViewFor<ShellViewModel>();

        protected override void Configure() => _appContainer.Configure();

        protected override IEnumerable<object> GetAllInstances(Type service) => _appContainer.GetAllInstances(service);

        protected override object GetInstance(System.Type service, string key) => _appContainer.GetInstance(service);
    }
}
