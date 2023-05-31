using proiectPAW.Entities;
using proiectPAW.Forms.GeneralView;
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
    public partial class GeneralView : Form
    {
        private Guid _id;
        public GeneralView(Guid Id)
        {
            InitializeComponent();
            FakeDatabase.obiective = Deserializare.DeserializareObiective();
            _id = Id;
            locatiiDatagrid.AutoGenerateColumns = false;
            locatiiDatagrid
                .AddColumn(0, "Locatie", "Locatie")
                .AddColumn(1, "Pret", "Pret")
                .AddColumn(2, "Review", "Review")
                .AddButtonColumn("AddReviewColumn", "Adauga Review");
            locatiiDatagrid.DataSource = FakeDatabase.obiective;
        }

        private void locatiiDatagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == locatiiDatagrid.Columns["AddReviewColumn"].Index)
            {
                var obiectiv = (Obiectiv)locatiiDatagrid.CurrentRow.DataBoundItem;

                //add review cu id
                //AICI AM RAMAS
                var generalReview = new AdaugaReview(obiectiv.Locatie, _id);
                generalReview.ShowDialog();
                
                locatiiDatagrid.DataSource = null;
                locatiiDatagrid.DataSource = FakeDatabase.obiective;
                Serializare.SerializareObiective(FakeDatabase.obiective);
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
