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
    public partial class Finder : Form
    {
        public Finder()
        {
            InitializeComponent();
        }
        private void fillBindingSourse()
        {
            string ClientName = textBoxClientName.Text;
            string Destination = textBoxDestination.Text;
            int Duration;
            if (!Int32.TryParse(textBoxDuration.Text, out Duration))
                Duration = 0;
            string ManagerName = textBoxManagerName.Text;
            string OrderName = textBoxOrderName.Text;

            int Price;
            if (!Int32.TryParse(textBoxPrice.Text, out Price))
                Price = 0;


            var ctx = new ClassLibrary.DBTripToMyDreamEntities();
            var query = from orders in ctx.ORDERS
                        join managers in ctx.MANAGERS on orders.Order_MANAGER equals managers.Manager_ID
                        join clients in ctx.CLIENTS on orders.Order_CLIENT equals clients.Client_ID
                        join destination in ctx.DESTINATIONs on orders.Order_DESTINATION equals destination.Destination_ID

                        select new
                        {
                            ClName = clients.Client_NAME,
                            Dest = destination.Destination_NAME,
                            Dur = orders.Order_DURATION,
                            MaName = managers.Manager_NAME,
                            OrName = orders.Order_NAME,
                            Pr = orders.Order_PRICE
                        };


            query = query.Where(n => (n.ClName == ClientName || ClientName == "") && (n.Dest == Destination || Destination == "") && (n.Dur == Duration || Duration == 0) && (n.MaName == ManagerName || ManagerName == "") && (n.Pr == Price || Price == 0));

            orderSearchBindingSource.Clear();
            foreach (var item in query)
            {
                orderSearchBindingSource.Add(new ClassLibrary.OrderSearch(item.OrName,item.Pr, item.Dur,item.Dest,item.ClName,item.MaName));
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
