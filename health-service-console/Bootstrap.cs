using health_service_console.Service;
using Nancy;
using Nancy.TinyIoc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace health_service_console
{
    public class Bootstrap : DefaultNancyBootstrapper
    {
        protected override void ConfigureApplicationContainer(TinyIoCContainer container)
        {
            container.Register<IHealthService, HealthService>().AsSingleton();
            base.ConfigureApplicationContainer(container);

        }
    }
}
