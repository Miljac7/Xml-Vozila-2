using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Xml_vozila
{
    public partial class Form1 : Form
    {
        private List<Vozilo> vozila = new List<Vozilo>();
        public Form1()
        {
            InitializeComponent();
            InitializeComboBox();
        }

        private void InitializeComboBox()
        {
            ComboBox.Items.Add("Marka");
            ComboBox.Items.Add("Model");
            ComboBox.Items.Add("GodinaProizvodnje");
            ComboBox.Items.Add("Kilometraza");
            ComboBox.SelectedIndex = 0;


        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var vozilo = new Vozilo
            {
                Marka = textBoxMarka.Text,
                Model = textBoxModel.Text,
                GodinaProizvodnje = int.Parse(textBoxGodinaProizvodnje.Text),
                Kilometraza = int.Parse(textBoxKilometraza.Text)
            };
            vozila.Add(vozilo);
            listBox1.Items.Add(vozilo);


        }

        private void btnSortiraj_Click(object sender, EventArgs e)
        {
            IEnumerable<Vozilo> sortedVozila;

            switch (ComboBox.SelectedItem.ToString())
            {
                case "Marka":
                    sortedVozila = vozila.OrderBy(v => v.Marka);
                    break;
                case "Model":
                    sortedVozila = vozila.OrderBy(v => v.Model);
                    break;
                case "GodinaProizvodnje":
                    sortedVozila = vozila.OrderBy(v => v.GodinaProizvodnje);
                    break;
                case "Kilometraza":
                    sortedVozila = vozila.OrderBy(v => v.Kilometraza);
                    break;
                default:
                    sortedVozila = vozila;
                    break;
            }
            textBox5.Clear();
            foreach (var vozilo in sortedVozila)
            {
                textBox5.AppendText(vozilo.ToString() + Environment.NewLine);
            }




        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            textBoxMarka.Clear();
            textBoxModel.Clear();
            textBoxGodinaProizvodnje.Clear();
            textBoxKilometraza.Clear();
            textBox5.Clear();
        }


        private void DisplaySortedVehicles(IEnumerable<Vozilo> sortedVozila)
        {
            textBox5.Clear();
            foreach (var vozilo in sortedVozila)
            {
                textBox5.AppendText(vozilo.ToString() + Environment.NewLine);
            }


        }


        private void textBoxMarka_TextChanged(object sender, EventArgs e)
        {

        }

        private void SpremiUXml()
        {
            
            if (vozila.Count == 0)
            {
                MessageBox.Show("Nema vozila za spremanje!", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            var xmlDokument = new XDocument(
                new XElement("Vozila",
                    from vozilo in vozila
                    select new XElement("Vozilo",
                        new XElement("Marka", vozilo.Marka),
                        new XElement("Model", vozilo.Model),
                        new XElement("GodinaProizvodnje", vozilo.GodinaProizvodnje),
                        new XElement("Kilometraza", vozilo.Kilometraza)
                    )
                )
            );
            
            string putanja = "vozila.xml";
            try
            {
               
                xmlDokument.Save(putanja);
                MessageBox.Show($"Podaci su uspešno sačuvani u datoteku: {putanja}", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Došlo je do greške prilikom spremanja: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void BtnSpremiXml_Click(object sender, EventArgs e)
        {
            SpremiUXml();
        }

        private void BtnLoadXml_Click(object sender, EventArgs e)
        {
          
        }
    }
}



