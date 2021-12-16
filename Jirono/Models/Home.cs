using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jirono.Models
{
    
    public class Home
    {
        public int Id { get; set; }
        public string Header { get; set; }
        public string Content { get; set; }
        public int ImgId { get; set; }
        public Images Image { get; set; }

    }
}
