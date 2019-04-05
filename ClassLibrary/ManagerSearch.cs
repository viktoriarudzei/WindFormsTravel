using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ManagerSearch
    {

        public string FilialName { get; set; }
        public string ManagerSurname { get; set; }
        public string OrderName { get; set; }
        public int ManagerRank { get; set; }

        public ManagerSearch(string FilialN, string Surname, string OrderN, int Rank)
        {
            FilialName = FilialN;
            ManagerSurname = Surname;
            OrderName = OrderN;
            ManagerRank = Rank;
        }
        
    }
}
