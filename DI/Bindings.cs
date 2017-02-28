using Ninject.Modules;

namespace ConsoleApplication
{
    public class Bindings : NinjectModule
    {
        public override void Load()
        {
            // configure IMailSender and ILogging to resolve to their specified concrete implementations
            Bind<IMailSender>().To<MockMailSender>();
            Bind<ILogging>().To<MockLogging>();
            Bind<IFormHandler>().To<FormHandler>();
        }
    }
}