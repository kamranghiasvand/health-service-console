using health_service_console.Models;
using health_service_console.Service;
using Nancy.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace health_service_console.Controller
{
    public class HealthController : Nancy.NancyModule
    {
        private IHealthService healthService;
        public HealthController(IHealthService healthService) : base("health")
        {
            this.healthService = healthService;

            Post("/add-provider-scheduling", _ =>
            {
                var entity = this.Bind<AddProviderSchedulingEntity>();
                return this.healthService.AddProviderScheduling(entity);
            });
        }
    }
}
