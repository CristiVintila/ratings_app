using proiectPAW.Entities;
using proiectPAW.Forms.AdminView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//form de user+parola/cont nou
//if texbox.user=="admin" o sa am alt form clasic cu locatiile si id-ul + utilizatori si id-uri + datagrid cu review(legat de utilizator)
//si label+nume locatie 

namespace proiectPAW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FakeDatabase.calatori = Deserializare.DeserializareCalatori();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (FakeDatabase.calatori.FirstOrDefault(x=>x.Nume == utilizatorTextBox.Text)!=null)
            {
                if (utilizatorTextBox.Text == "admin" && parolaTextbox.Text == "admin")
                {
                    var adminForm = new AdminView();
                    adminForm.ShowDialog();
                    utilizatorTextBox.Text = "";
                    parolaTextbox.Text = "";
                } 
                else if(FakeDatabase.calatori.FirstOrDefault(x=>x.Nume == utilizatorTextBox.Text).Parola == parolaTextbox.Text)
                {
                    //deschidem pt general view
                    var generalForm = new GeneralView(FakeDatabase.calatori.FirstOrDefault(x => x.Nume == utilizatorTextBox.Text).Id);
                    generalForm.ShowDialog();
                    utilizatorTextBox.Text = "";
                    parolaTextbox.Text = "";
                }
                else
                {
                    MessageBox.Show("Utilizator sau parola gresite!");
                } 
            }
            else
            {
                MessageBox.Show("Contul nu exista!");
            }
        }

        private void newaccLabel_Click(object sender, EventArgs e)
        {
            var newAcc = new AdaugaCalator();
            newAcc.ShowDialog();
        }
    }
}
