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
    public partial class FormTrip : Form
    {
        public FormTrip()
        {
            InitializeComponent();
            ownersTableAdapter1.Fill(dsLibrary1.OWNERS);
            companyTableAdapter1.Fill(dsLibrary1.COMPANY);
            filialTableAdapter1.Fill(dsLibrary1.FILIAL);
            managersTableAdapter1.Fill(dsLibrary1.MANAGERS);
            clientsTableAdapter1.Fill(dsLibrary1.CLIENTS);
            ordersTableAdapter1.Fill(dsLibrary1.ORDERS);
            destinationTableAdapter1.Fill(dsLibrary1.DESTINATION);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonOwnersSave_Click(object sender, EventArgs e)
        {
            ownersTableAdapter1.Update(dsLibrary1.OWNERS);
        }

        private void buttonOwnersDelete_Click(object sender, EventArgs e)
        {
            
            try
            {
                int id = (int)dataGridViewOWNER.CurrentRow.Cells["ownerIDDataGridViewTextBoxColumn"].Value;
                global::System.Nullable<int> ow_count = queriesTableAdapter1.SQCountOwnerID_CompanyID(id);
                if (ow_count == 0)
                {
                    oWNERSBindingSource.RemoveCurrent();
                }
                else
                {
                    MessageBox.Show("You can't delete that!");
                }
            }
            catch
            {
                MessageBox.Show("Error!");
            }
        }

        private void buttonCompanySave_Click(object sender, EventArgs e)
        {
            companyTableAdapter1.Update(dsLibrary1.COMPANY);
        }

        private void buttonCompanyDelete_Click(object sender, EventArgs e)
        {

            try
            {
                int id = (int)dataGridViewCOMPANY.CurrentRow.Cells["companyIDDataGridViewTextBoxColumn"].Value;
                global::System.Nullable<int> comp_count = queriesTableAdapter1.SQCountCompany_IDFilial_ID(id);
                if (comp_count == 0)
                {
                    cOMPANYBindingSource.RemoveCurrent();
                }
                else
                {
                    MessageBox.Show("You can't delete that!");
                }
            }
            catch
            {
                MessageBox.Show("Error!");
            }
        }

        private void buttonFilialSave_Click(object sender, EventArgs e)
        {
            filialTableAdapter1.Update(dsLibrary1.FILIAL);
        }

        private void fILIALBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void buttonFilialDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dataGridViewFILIAL.CurrentRow.Cells["filialIDDataGridViewTextBoxColumn"].Value;
                global::System.Nullable<int> f_count = queriesTableAdapter1.SQCountFilial_IDManagers_ID(id);
                if (f_count == 0)
                {
                    fILIALBindingSource.RemoveCurrent();
                }
                else
                {
                    MessageBox.Show("You can't delete that!");
                }
            }
            catch
            {
                MessageBox.Show("Error!");
            }
        }

        private void buttonManagersSave_Click(object sender, EventArgs e)
        {
            managersTableAdapter1.Update(dsLibrary1.MANAGERS);
        }

        private void buttonManagersDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dataGridViewMANAGERS.CurrentRow.Cells["managerIDDataGridViewTextBoxColumn"].Value;
                global::System.Nullable<int> man_count = queriesTableAdapter1.SQCountManager_IDOrder_ID(id);
                if (man_count == 0)
                {
                    mANAGERSBindingSource.RemoveCurrent();
                }
                else
                {
                    MessageBox.Show("You can't delete that!");
                }
            }
            catch
            {
                MessageBox.Show("Error!");
            }
        }

        private void buttonClientsSave_Click(object sender, EventArgs e)
        {
            clientsTableAdapter1.Update(dsLibrary1.CLIENTS);
        }

        private void buttonClientsDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dataGridViewCLIENTS.CurrentRow.Cells["clientIDDataGridViewTextBoxColumn"].Value;
                global::System.Nullable<int> cl_count = queriesTableAdapter1.SQCountClientIDinOrders(id);
                if (cl_count == 0)
                {
                    cLIENTSBindingSource.RemoveCurrent();
                }
                else
                {
                    MessageBox.Show("You can't delete that!");
                }
            }
            catch
            {
                MessageBox.Show("Error!");
            }
            
        }

        private void buttonOrdersSave_Click(object sender, EventArgs e)
        {
            ordersTableAdapter1.Update(dsLibrary1.ORDERS);
        }

        private void buttonOrdersDelete_Click(object sender, EventArgs e)
        {
            oRDERSBindingSource.RemoveCurrent();
        }

        private void buttonDestinatioSave_Click(object sender, EventArgs e)
        {
            destinationTableAdapter1.Update(dsLibrary1.DESTINATION);
        }

        private void buttonDestinationDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dataGridViewDESTINATION.CurrentRow.Cells["destinationIDDataGridViewTextBoxColumn"].Value;
                global::System.Nullable<int> d_count = queriesTableAdapter1.SQDestination_IDOrders_ID(id);
                if (d_count == 0)
                {
                    dESTINATIONBindingSource.RemoveCurrent();
                }
                else
                {
                    MessageBox.Show("You can't delete that!");
                }
            }
            catch
            {
                MessageBox.Show("Error!");
            }
            
        }

        private void buttonOrderSearch_Click(object sender, EventArgs e)
        {
            Finder finder = new Finder();
            finder.ShowDialog();
            finder.Close();
        }

        private void buttonClientsSearch_Click(object sender, EventArgs e)
        {
            Finder2 finder = new Finder2();
            finder.ShowDialog();
            finder.Close();
        }

        private void buttonManagS_Click(object sender, EventArgs e)
        {
            Finder3 finder = new Finder3();
            finder.ShowDialog();
            finder.Close();
        }

              

        private void dataGridViewMANAGERS_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(dataGridViewMANAGERS_KeyPress);
            if (dataGridViewMANAGERS.CurrentCell.ColumnIndex == 3) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(dataGridViewMANAGERS_KeyPress);
                }
            }
        }

        private void dataGridViewMANAGERS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Incorrect value! \n Please enter the positive number");
            }
        }

        private void dataGridViewORDERS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Incorrect value! \n Please enter the positive number");
            }
        }

        private void dataGridViewORDERS_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(dataGridViewORDERS_KeyPress);
            if (dataGridViewORDERS.CurrentCell.ColumnIndex == 5 || dataGridViewORDERS.CurrentCell.ColumnIndex == 6) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(dataGridViewORDERS_KeyPress);
                }
            }
        }
    }
}
