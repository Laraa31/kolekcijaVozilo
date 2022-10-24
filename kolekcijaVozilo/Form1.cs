using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kolekcijaVozilo
{
    public partial class Form1 : Form
    {
        List<Vozilo> vozila=new List<Vozilo>(); 
        public Form1()
        {
            InitializeComponent();
        }

        private void btnObradi_Click(object sender, EventArgs e)
        {

            rtbIspis.Text = "Model" + "\tGodina Proizvodnje" + "\tBroj kotača" + "\tKategorija";

            string kategorija;

            foreach(Vozilo vozilo in vozila)
            {
                if (vozilo.BrKotaca == 2)
                {
                    kategorija = "Motocikl";
                    rtbIspis.AppendText(vozilo.ToString()+kategorija+"\n");
                }
                else if (vozilo.BrKotaca == 4)
                {
                    kategorija = "Automobil";
                    rtbIspis.AppendText(vozilo.ToString() + kategorija + "\n");
                }
                else if (vozilo.BrKotaca > 4)
                {
                    kategorija = "Kamion";
                    rtbIspis.AppendText(vozilo.ToString() + kategorija + "\n");
                }
                
            }
        }

        private void btnIspis_Click(object sender, EventArgs e)
        {
            rtbIspis.Text = "Model" + "\tGodina proizvodnje" + "\tBroj kotača" + "\tKategorija";

            foreach(Vozilo vozilo in vozila)
            {
                rtbIspis.AppendText(vozilo.ToString() + "\n");
            }
        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtbBrKotaca.Text) % 2== 0)
            {
                try
                {
                    Vozilo vozilo = new Vozilo(txtbModel.Text, Convert.ToInt32(txtbGodProizvod.Text), Convert.ToInt32(txtbBrKotaca.Text));

                    vozila.Add(vozilo);

                    txtbModel.Clear();
                    txtbGodProizvod.Clear();
                    txtbBrKotaca.Clear();
                    MessageBox.Show("Uspješan unos!", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception greska)
                {
                    MessageBox.Show("Pogrešan unos! " + greska.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                
                MessageBox.Show("Zabranjen je unos neparnog broja kotača! ", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}
