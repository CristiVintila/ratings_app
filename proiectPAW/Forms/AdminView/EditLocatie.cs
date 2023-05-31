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
    public partial class EditLocatie : Form
    {
        private Guid ID;
        public EditLocatie(Guid id)
        {
            InitializeComponent();
            ID = id;
            locatieTextbox.Text = FakeDatabase.obiective.First(x => x.Id == id).Locatie;
            pretTextbox.Text = FakeDatabase.obiective.First(x => x.Id == id).Pret.ToString();
        }

        private void modificaLocatieButton_Click(object sender, EventArgs e)
        {
            Obiectiv obiectiv = FakeDatabase.obiective.First(x => x.Id == ID);
            obiectiv.Locatie = locatieTextbox.Text;
            obiectiv.Pret = Convert.ToDouble(pretTextbox.Text);

            Hide();
        }
    }
}
