using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Entities
{
    public class DamageReports
    {
        public int Id { get; set; }
        public string ClientName { get; set; }
        public string Status { get; set; }
        public string OperatingSystem { get; set; }
        public string DeviceModel { get; set; }
        public string DamageSummary { get; set; }
        public string AdditionalInfo { get; set; }
        public DateTime DateReceived { get; set; }
    }
}
