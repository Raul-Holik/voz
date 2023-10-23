using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.IsolatedStorage;
using System.Xml.Linq;


namespace KatVozila
{
    public partial class Form1 : Form
    {
        List<Vozila> VozilaList=new List<Vozila>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            Vozila vozilo = new Vozila(txtModel.Text,txtGod.Text,txtKotaci.Text);
            try
            {
                if (txtModel.Text == "" || txtGod.Text == "" || txtKotaci.Text == "")
                {
                    MessageBox.Show("Pogrešan unos", "Pokušajte ponovo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtModel.Clear();
                    txtKotaci.Clear();
                }

                else
                {
                    VozilaList.Add(vozilo);
                    txtModel.Clear();
                    txtGod.Clear();
                    txtKotaci.Clear();
                }
            }

            catch
            {
                txtGod.Clear();
                txtModel.Clear();
                txtKotaci.Clear();
            }
        }

        private void btnObrada_Click(object sender, EventArgs e)
        {
            foreach (Vozila v in VozilaList)
            {
                if (v.BrKotaca == "2")
                {
                    v.Kategorija = "Motor.";
                }

                else if (v.BrKotaca == "4")
                {
                    v.Kategorija = "Auto";
                }

                else if (v.BrKotaca == "6"|| v.BrKotaca=="9")
                {
                    v.Kategorija = "Kamion";
                }
            }
        }

        private void btnIspis_Click(object sender, EventArgs e)
        {
            foreach (Vozila v in VozilaList)
            {
                txtIspis.AppendText(v.ToString());
            }
        }
    }
}

