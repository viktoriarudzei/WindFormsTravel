using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
   public class OrderSearch
    {
        public string OrderName { get; set; }
        public int OrderPrice { get; set; }
        public int OrderDuration { get; set; }
        public string OrderDestination { get; set; }
        public string ClientName { get; set; }
        public string ManagerName { get; set; }
        public OrderSearch(string OName, int OrPr, int OrDur, string OrDest, string ClN,string ManN)
        {
            OrderName = OName;
            OrderPrice = OrPr;
            OrderDuration = OrDur;
            OrderDestination = OrDest;
            ClientName = ClN;
            ManagerName = ManN;
        }
    }
}
