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
    public partial class EditCalator : Form
    {
        private Guid ID;
        public EditCalator(Guid id)
        {
            InitializeComponent();
            ID = id;
            utilizatorTextbox.Text = FakeDatabase.calatori.First(x => x.Id == id).Nume;
            parolaTextbox.Text = FakeDatabase.calatori.First(x => x.Id == id).Parola;
        }

        private void editAccountButton_Click(object sender, EventArgs e)
        {
            var curent = FakeDatabase.calatori.First(x => x.Id == ID);
            curent.Nume = utilizatorTextbox.Text;
            curent.Parola = parolaTextbox.Text;

            Hide();
        }
    }
}
