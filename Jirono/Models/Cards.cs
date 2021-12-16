using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jirono.Models
{
    public class Cards
    {
        public int Id { get; set; }
        public string CardIconId { get; set; }
        public Icons Icon { get; set; }
        public string CardHeadTextId { get; set; }
        public CardHead CardHeadText { get; set; }
        public string CardContentId { get; set; }
        public CardContent CardContentText { get; set; }
    }
}
