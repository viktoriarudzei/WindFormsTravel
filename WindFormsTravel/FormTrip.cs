using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace WindFormsTravel
{
    public partial class FormTrip : Form
    {
        private ClassLibrary.DBTripToMyDreamEntities ctx;
        public FormTrip()
        {
            InitializeComponent();
       
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ctx = new ClassLibrary.DBTripToMyDreamEntities();
            ctx.OWNERS.Load();
            this.oWNERBindingSource.DataSource = ctx.OWNERS.Local.ToBindingList();
            ctx.COMPANies.Load();
            this.cOMPANYBindingSource.DataSource = ctx.COMPANies.Local.ToBindingList();
            ctx.FILIALs.Load();
            this.fILIALBindingSource.DataSource = ctx.FILIALs.Local.ToBindingList();
            ctx.MANAGERS.Load();
            this.mANAGERBindingSource.DataSource = ctx.MANAGERS.Local.ToBindingList();
            ctx.ORDERS.Load();
            this.oRDERBindingSource.DataSource = ctx.ORDERS.Local.ToBindingList();
            ctx.CLIENTS.Load();
            this.cLIENTBindingSource.DataSource = ctx.CLIENTS.Local.ToBindingList();
            ctx.DESTINATIONs.Load();
            this.dESTINATIONBindingSource.DataSource = ctx.DESTINATIONs.Local.ToBindingList();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            ctx.Dispose();
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonOwnersSave_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }

        private void buttonOwnersDelete_Click(object sender, EventArgs e)
        {
            
            try
            {
                ClassLibrary.OWNER owner = (ClassLibrary.OWNER)dataGridViewOWNER.CurrentRow.DataBoundItem;
                var v = (from c in ctx.COMPANies where c.Company_OWNERS == owner.Owner_ID select c).Any();
                if (v)
                {
                    MessageBox.Show("You can't delete that!");
                }
                else
                {
                    oWNERBindingSource.RemoveCurrent();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Error!");
                throw;
            }
        }

        private void buttonCompanySave_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }

        private void buttonCompanyDelete_Click(object sender, EventArgs e)
        {

            try
            {
                ClassLibrary.COMPANY company = (ClassLibrary.COMPANY)dataGridViewCOMPANY.CurrentRow.DataBoundItem;
                var v = (from c in ctx.FILIALs where c.Filial_COMPANY == company.Company_ID select c).Any();
                if (v)
                {
                    MessageBox.Show("You can't delete that!");
                }
                else
                {
                    cOMPANYBindingSource.RemoveCurrent();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error!");
                throw;
            }
        }

        private void buttonFilialSave_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }

        private void fILIALBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void buttonFilialDelete_Click(object sender, EventArgs e)
        {
            try
                {
                    ClassLibrary.FILIAL filial = (ClassLibrary.FILIAL)dataGridViewFILIAL.CurrentRow.DataBoundItem;
                    var v = (from c in ctx.MANAGERS where c.Manager_FILIAL == filial.Filial_ID select c).Any();
                    if (v)
                    {
                        MessageBox.Show("You can't delete that!");
                    }
                    else
                    {
                        fILIALBindingSource.RemoveCurrent();
                    }
                }
            catch (Exception)
            {
                MessageBox.Show("Error!");
                throw;
            }
        }

        private void buttonManagersSave_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }

        private void buttonManagersDelete_Click(object sender, EventArgs e)
        {
            try
            {
                ClassLibrary.MANAGER manager = (ClassLibrary.MANAGER)dataGridViewMANAGERS.CurrentRow.DataBoundItem;
                var v = (from c in ctx.ORDERS where c.Order_MANAGER == manager.Manager_ID select c).Any();
                if (v)
                {
                    MessageBox.Show("You can't delete that!");
                }
                else
                {
                    mANAGERBindingSource.RemoveCurrent();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error!");
                throw;
            }
        }

        private void buttonClientsSave_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }

        private void buttonClientsDelete_Click(object sender, EventArgs e)
        {
            try
            {
                ClassLibrary.CLIENT client = (ClassLibrary.CLIENT)dataGridViewCLIENTS.CurrentRow.DataBoundItem;
                var v = (from c in ctx.ORDERS where c.Order_CLIENT == client.Client_ID select c).Any();
                if (v)
                {
                    MessageBox.Show("You can't delete that!");
                }
                else
                {
                    cLIENTBindingSource.RemoveCurrent();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error!");
                throw;
            }

        }

        private void buttonOrdersSave_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }

        private void buttonOrdersDelete_Click(object sender, EventArgs e)
        {
            oRDERBindingSource.RemoveCurrent();
        }

        private void buttonDestinatioSave_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }

        private void buttonDestinationDelete_Click(object sender, EventArgs e)
        {
            try
            {
                ClassLibrary.DESTINATION destination = (ClassLibrary.DESTINATION)dataGridViewDESTINATION.CurrentRow.DataBoundItem;
                var v = (from c in ctx.ORDERS where c.Order_DESTINATION == destination.Destination_ID select c).Any();
                if (v)
                {
                    MessageBox.Show("You can't delete that!");
                }
                else
                {
                    dESTINATIONBindingSource.RemoveCurrent();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error!");
                throw;
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
