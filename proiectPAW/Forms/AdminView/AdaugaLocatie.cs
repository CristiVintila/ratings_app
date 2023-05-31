using proiectPAW.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiectPAW.Forms.AdminView
{
    public partial class AdaugaLocatie : Form
    {
        public AdaugaLocatie()
        {
            InitializeComponent();
        }

        private bool compNoWhite(string s1, string s2)
        {
            string norm1 = s1.Replace(" ", "");
            string norm2 = s2.Replace(" ", "");
            return norm1.ToLower().Equals(norm2.ToLower());
        }

        private void adaugaLocatieButton_Click(object sender, EventArgs e)
        {
            int nr = 0;
            Obiectiv obiectiv = new Obiectiv();
            obiectiv.Id = Guid.NewGuid();
            obiectiv.Locatie = locatieTextbox.Text;
            obiectiv.Pret = Convert.ToDouble(pretTextbox.Text);
            obiectiv.Review = 1;
            foreach(var l in FakeDatabase.obiective)
            {
                if (compNoWhite(l.Locatie, obiectiv.Locatie)==true)
                {
                    nr++;
                }
            }
            if (nr>0)
            {
                MessageBox.Show("Locatia exista deja!");
            }
            else
            {
                FakeDatabase.obiective.Add(obiectiv);
                Hide();
            }
        }
    }
}
