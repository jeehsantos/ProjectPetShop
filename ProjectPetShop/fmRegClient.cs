using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPetShop
{
    public partial class fmRegClient : Form
    {
        public fmRegClient()
        {
            InitializeComponent();
        }

        private void fmRegClient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'petshopDataSet.cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.petshopDataSet.cliente);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try { 
            this.Validate();
            this.clienteBindingSource.EndEdit();
                clienteTableAdapter.Update(petshopDataSet.cliente);
                MessageBox.Show("Register updated !");
                groupBox1.Enabled = false;
            }catch(Exception)
            {
                MessageBox.Show("An error ocurred, please review the form");
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            clienteBindingSource.AddNew();
            groupBox1.Enabled = true;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Delete register", "PetShop", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    clienteBindingSource.RemoveCurrent();
                    clienteTableAdapter.Update(petshopDataSet.cliente);
                }
            }
            catch (Exception)
            {
                clienteTableAdapter.Fill(petshopDataSet.cliente);
                MessageBox.Show("Register cannot be deleted");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clienteBindingSource.CancelEdit();
            groupBox1.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;

        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            try { 
            openFileDialog1.Filter = "Pictures (*.jpg; *.png;) | *.jpg; *.png; ";
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                cli_fotoPictureBox.Image = new Bitmap(openFileDialog1.FileName);
            }
            }
            catch (Exception)
            {
                MessageBox.Show("Error loading image", "PetShop", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
