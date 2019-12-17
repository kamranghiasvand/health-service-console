using health_service_console.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace health_service_console.Service
{
    public interface IHealthService
    {
        string AddProviderScheduling(AddProviderSchedulingEntity entity);
    }
    public class HealthService : IHealthService
    {
        SDK.Service service;
        public HealthService()
        {
            service = new SDK.Service();
        }
        public string AddProviderScheduling(AddProviderSchedulingEntity entity)
        {
            return service.AddProviderScheduling(entity.Provider, entity.HealthcareFacility, entity.StartDateTime, entity.DurationPerPatient
                , entity.QueueNumber, entity.Service, entity.Quota, entity.LocalID, entity.BookingStartDate, entity.BookingExpiryDate);
        }
    }
}
