using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jirono.Models
{
    public class DesignDevelopment
    {
        public int Id { get; set; }
        public int DesignDevelopmentHeadId { get; set; }
        public CloudServicesHead DesignDevelopmentHead { get; set; }
        public int DesignDevelopmentContentId { get; set; }
        public CloudServicesContent DesignDevelopmentContent { get; set; }
        public int OptionId { get; set; }
        public Options Option { get; set; }
        public Images Image { get; set; }
    }
}
