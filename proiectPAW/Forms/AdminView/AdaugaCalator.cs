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
    public partial class AdaugaCalator : Form
    {
        public AdaugaCalator()
        {
            InitializeComponent();
        }

        private void addAccountButton_Click(object sender, EventArgs e)
        {
            if (parolaTextbox.Text == confirmaTextbox.Text)
            {
                int nr = 0;
                //adauga in lista
                Calator calator = new Calator();
                calator.Id = Guid.NewGuid();
                calator.Nume = utilizatorTextbox.Text;
                calator.Parola = parolaTextbox.Text;
                foreach(var c in FakeDatabase.calatori)
                {
                    if (c.Nume==calator.Nume)
                    {
                        nr++;
                    }
                }
                if (nr>0)
                {
                    MessageBox.Show("Utilizatorul exista deja!");
                }
                else
                {
                    FakeDatabase.calatori.Add(calator);
                    Serializare.SerializareCalatori(FakeDatabase.calatori);
                    Hide();
                }
            }
            else
            {
                MessageBox.Show("Parolele nu coincid");
            }
        }
    }
}
