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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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
         
        }

        private void Finder_Load(object sender, EventArgs e)
        {

        }
    }
}
