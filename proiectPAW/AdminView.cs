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

namespace proiectPAW
{
    public partial class AdminView : Form
    {
        public AdminView()
        {
            InitializeComponent();
        }

        private void calatoriButton_Click(object sender, EventArgs e)
        {
            var adminCalatori = new AdminCalatori();
            adminCalatori.ShowDialog();
        }

        private void locatiiButton_Click(object sender, EventArgs e)
        {
            var adminLocatii = new AdminLocatii();
            adminLocatii.ShowDialog();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
