using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jirono.Models
{
    public class CloudServices
    {
        public int Id { get; set; }
        public int CloudServicesHeadId { get; set; }
        public CloudServicesHead CloudServicesHead { get; set; }
        public int CloudServicesContentId { get; set; }
        public CloudServicesContent CloudServicesContent { get; set; }
        public int OptionId { get; set; }
        public Options Option { get; set; }
        public Images Image { get; set; }
    }
}
