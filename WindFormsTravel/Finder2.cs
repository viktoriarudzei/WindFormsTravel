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
            clienT_DTTableAdapter1.Fill(dsLibrary1.CLIENT_DT, "", "", "", "","");
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string Name = textBoxName.Text;
            string OrderName = textBoxOrderName.Text;
            string Surname = textBoxSurname.Text;
            string ManagerSyrname = textBoxManagerSurname.Text;
            string Born = dateTimePickerClient.Value.ToString("yyyy-dd-MM");
            clienT_DTTableAdapter1.Fill(dsLibrary1.CLIENT_DT, Surname, Name, Born, ManagerSyrname, OrderName);
        }
    }
}
