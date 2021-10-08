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
    public partial class fmRegBreeds : Form
    {
        public fmRegBreeds()
        {
            InitializeComponent();
        }

        private void racaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.racaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.petshopDataSet);

        }

        private void fmRegBreeds_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'petshopDataSet.raca' table. You can move, or remove it, as needed.
            this.racaTableAdapter.Fill(this.petshopDataSet.raca);

        }
    }
}
