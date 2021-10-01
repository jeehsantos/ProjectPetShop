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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            PanelCenter.Controls.Clear();

            PanelSelect.Top = btnHome.Top;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            fmRegBreeds breed = new fmRegBreeds();
            breed.TopLevel = false;
            breed.Dock = DockStyle.Fill;
            PanelCenter.Controls.Clear();
            PanelCenter.Controls.Add(breed);
            breed.Show();

            //Move selected panel
            PanelSelect.Top = btnBreed.Top;

        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit ?", "PetShop", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click_4(object sender, EventArgs e)
        {
            //Minimize
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            fmRegBook book = new fmRegBook();
            book.TopLevel = false;
            book.Dock = DockStyle.Fill;
            PanelCenter.Controls.Clear();
            PanelCenter.Controls.Add(book);
            book.Show();

            //Move selector position
            PanelSelect.Top = btnBooking.Top;
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            fmRegClient client = new fmRegClient();
            client.TopLevel = false;
            client.Dock = DockStyle.Fill;
            PanelCenter.Controls.Clear();
            PanelCenter.Controls.Add(client);
            client.Show();

            //Move selector position
            PanelSelect.Top = btnClient.Top;
        }

        private void btnAnimal_Click(object sender, EventArgs e)
        {
            fmRegAnimal animal = new fmRegAnimal();
            animal.TopLevel = false;
            animal.Dock = DockStyle.Fill;
            PanelCenter.Controls.Clear();
            PanelCenter.Controls.Add(animal);
            animal.Show();

            //Move selector position
            PanelSelect.Top = btnAnimal.Top;
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            fmRegService service = new fmRegService();
            service.TopLevel = false;
            service.Dock = DockStyle.Fill;
            PanelCenter.Controls.Clear();
            PanelCenter.Controls.Add(service);
            service.Show();

            //Move selected position
            PanelSelect.Top = btnService.Top;
        }
    }
}
