using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindFormsTravel
{
    public partial class Finder3 : Form
    {
        public Finder3()
        {
            InitializeComponent();
         
        }

         private void fillBindingSourse()
         {
                string FilialN = textBoxFilialN.Text;
                string OrderN = textBoxOrderN.Text;
                string Surname = textBoxSurname.Text;
                int Rank;
                if (!Int32.TryParse(textBoxRank.Text, out Rank))
                    Rank = 0;


                   var ctx = new ClassLibrary.DBTripToMyDreamEntities();
                   var query = from orders in ctx.ORDERS
                        join managers in ctx.MANAGERS on orders.Order_MANAGER equals managers.Manager_ID
                        join filal in ctx.FILIALs on managers.Manager_FILIAL equals filal.Filial_ID

                        select new
                        {
                            FilialName = filal.Filial_NAME,
                            OrderName = orders.Order_NAME,
                            ManagerSurname = managers.Manager_SURNAME,
                            ManagerRank = managers.Manager_RANK
                        };


            query = query.Where(n => (n.FilialName == FilialN || FilialN == "") && (n.ManagerRank == Rank || Rank == 0) && (n.ManagerSurname == Surname || Surname == "") && (n.OrderName == OrderN || OrderN == ""));

            managerSearchBindingSource.Clear();
            foreach (var item in query)
            {
                managerSearchBindingSource.Add(new ClassLibrary.ManagerSearch(item.FilialName,item.ManagerSurname, item.OrderName, item.ManagerRank));
            }
         }
         protected override void OnLoad(EventArgs e)
         {
            base.OnLoad(e);
            fillBindingSourse();
         }


        private void button1_Click(object sender, EventArgs e)
        {
            fillBindingSourse();
        }
    }
}
