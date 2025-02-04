using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyber_Tarot
{
    public class TarotCard
    {
        public int Key { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string ArcanaType { get; set; }
        public int Upright { get; set; }

        public TarotCard() { }
    }
}
