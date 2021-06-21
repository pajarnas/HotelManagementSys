using System.Collections.Generic;

namespace SysCore.Entities
{
    public class ServiceType
    {
        public int Id { get; set; }
        public string SDesc { get; set; }
        public decimal? Amount { get; set; }
        public ICollection<Service> Services { get; set; }
    }
}
 