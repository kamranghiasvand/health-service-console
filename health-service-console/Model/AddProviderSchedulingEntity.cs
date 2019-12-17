using SDK.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace health_service_console.Models
{
    public class AddProviderSchedulingEntity
    {
        public HealthcareProviderVO Provider { get; set; }
        public HealthOrganizationUnitVO HealthcareFacility { get; set; }
        public DO_DATE_TIME StartDateTime { get; set; }
        public int DurationPerPatient { get; set; }
        public int QueueNumber { get; set; }
        public DO_CODED_TEXT Service { get; set; }
        public DO_CODED_TEXT Quota { get; set; }
        public string LocalID { get; set; }
        public DO_DATE_TIME BookingStartDate { get; set; }
        public DO_DATE_TIME BookingExpiryDate { get; set; }
    }
}