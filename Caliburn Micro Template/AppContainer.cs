using Caliburn.Micro;
using SimpleInjector;

namespace CaliburnMicroTemplate
{
    public class AppContainer : Container
    {
        public void Configure()
        {
            Register<IWindowManager, WindowManager>();

            Verify();
        }
    }
}
