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
    public partial class Finder2 : Form
    {
        public Finder2()
        {
            InitializeComponent();
          
        }

        private void fillBindingSourse()
        {
            string Name = textBoxName.Text;
            string OrderName = textBoxOrderName.Text;
            string Surname = textBoxSurname.Text;
            string ManagerSurname = textBoxManagerSurname.Text;
            string Born="";
            if (checkBox1.Checked)
               Born = dateTimePickerClient.Value.ToString("yyyy-dd-MM");


            var ctx = new ClassLibrary.DBTripToMyDreamEntities();
            var query = from orders in ctx.ORDERS
                        join managers in ctx.MANAGERS on orders.Order_MANAGER equals managers.Manager_ID
                        join client in ctx.CLIENTS on orders.Order_CLIENT equals client.Client_ID
                        select new
                        {
                            ClientName=client.Client_NAME,
                            ClientSurname=client.Client_SURNAME,
                            OrderName = orders.Order_NAME,
                            ManagerSurname = managers.Manager_SURNAME,
                            ClientBorn=client.Client_BORN
                        };


            query = query.Where(n => (n.ClientName == Name || Name == "") && (n.OrderName == OrderName || OrderName == "") && (n.ClientSurname == Surname || Surname == "") && (n.ManagerSurname == ManagerSurname || ManagerSurname == "")&&(n.ClientBorn.ToString()==Born||Born==""));

            clientSearchBindingSource.Clear();
            foreach (var item in query)
            {
                clientSearchBindingSource.Add(new ClassLibrary.ClientSearch(item.ClientName,item.ClientSurname,item.ManagerSurname,item.OrderName,item.ClientBorn ));
            }
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            fillBindingSourse();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            fillBindingSourse();
        }

    }
}
