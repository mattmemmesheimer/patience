using System.Windows;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.PubSubEvents;
using Microsoft.Practices.Prism.UnityExtensions;
using Microsoft.Practices.Unity;
using Solitaire.CardStack;
using Solitaire.Common.Models;
using Solitaire.Foundations;
using Solitaire.Tableaus;

namespace Solitaire
{
    public class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<PrismAppShell>();
        }

        protected override void InitializeModules()
        {
            base.InitializeModules();
            Application.Current.MainWindow = (PrismAppShell)Shell;
            Application.Current.MainWindow.Show();
        }

        protected override void ConfigureModuleCatalog()
        {
            base.ConfigureModuleCatalog();
            var moduleCatalog = (ModuleCatalog)ModuleCatalog;
            moduleCatalog.AddModule(typeof(CardStackModule));
            moduleCatalog.AddModule(typeof(FoundationsModule));
            moduleCatalog.AddModule(typeof(TableausModule));
        }

        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();

            Container.RegisterType<IEventAggregator, EventAggregator>(new ContainerControlledLifetimeManager());
            Container.RegisterType<SolitaireGameInstance>(new ContainerControlledLifetimeManager());
        }
    }
}
