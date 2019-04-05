using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ClientSearch
    {
        public string ClientName { get; set; }
        public string ClientSurname { get; set; }
        public string ManagerSurname { get; set; }
        public string OrderName { get; set; }
        public DateTime DateOFBirth { get; set; }

        public ClientSearch(string ClN, string ClSurn, string MangS, string OrderN,DateTime birth)
        {
            ClientName = ClN;
            ClientSurname = ClSurn;
            ManagerSurname = MangS;
            OrderName = OrderN;
            DateOFBirth = birth.Date;
        }
    }
}
