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
            manageR_DTTableAdapter1.Fill(dsLibrary1.MANAGER_DT, 0, "", "", "");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string FilialN = textBoxFilialN.Text;
            string OrderN = textBoxOrderN.Text;
            string Surname = textBoxSurname.Text;
            int Rank;
            if (!Int32.TryParse(textBoxRank.Text, out Rank))
                Rank = 0;
            manageR_DTTableAdapter1.Fill(dsLibrary1.MANAGER_DT, Rank,Surname,FilialN,OrderN);
        }
    }
}
