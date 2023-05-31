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
    public partial class AdminLocatii : Form
    {
        public AdminLocatii()
        {
            InitializeComponent();
            FakeDatabase.obiective = Deserializare.DeserializareObiective();
            locatiiDatagrid.AutoGenerateColumns = false;
            locatiiDatagrid.AddColumn(0, "Id", "Id")
                .AddColumn(1, "Locatie", "Locatie")
                .AddColumn(2, "Pret", "Pret")
                .AddColumn(3, "Review", "Review")
                .AddButtonColumn("DeleteColumn", "Delete")
                .AddButtonColumn("EditColumn", "Edit")
                .AddButtonColumn("ReviewsColumn", "Reviews");
            locatiiDatagrid.DataSource = FakeDatabase.obiective;
        }

        private void addLocatieButton_Click(object sender, EventArgs e)
        {
            var addLocatie = new AdaugaLocatie();
            addLocatie.ShowDialog();

            locatiiDatagrid.DataSource = null;
            locatiiDatagrid.DataSource = FakeDatabase.obiective;
            Serializare.SerializareObiective(FakeDatabase.obiective);
        }

        private void locatiiDatagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == locatiiDatagrid.Columns["DeleteColumn"].Index)
            {
                var obiectiv = (Obiectiv)locatiiDatagrid.CurrentRow.DataBoundItem;
                FakeDatabase.ratings.RemoveAll(x => x.NumeLocatie == obiectiv.Locatie);
                Serializare.SerializareRatings(FakeDatabase.ratings);
                FakeDatabase.obiective.Remove(obiectiv);
                locatiiDatagrid.DataSource = null;
                locatiiDatagrid.DataSource = FakeDatabase.obiective;
                Serializare.SerializareObiective(FakeDatabase.obiective);
            }
            if (e.ColumnIndex == locatiiDatagrid.Columns["EditColumn"].Index)
            {
                var obiectiv = (Obiectiv)locatiiDatagrid.CurrentRow.DataBoundItem;
                //deschid editCalator cu param id
                var editLocatie = new EditLocatie(obiectiv.Id);
                editLocatie.ShowDialog();

                locatiiDatagrid.DataSource = null;
                locatiiDatagrid.DataSource = FakeDatabase.obiective;
                Serializare.SerializareObiective(FakeDatabase.obiective);
            }
            if (e.ColumnIndex == locatiiDatagrid.Columns["ReviewsColumn"].Index)
            {
                var obiectiv = (Obiectiv)locatiiDatagrid.CurrentRow.DataBoundItem;

                var reviewLocaite = new ReviewLocatii(obiectiv.Id);
                reviewLocaite.ShowDialog();

                locatiiDatagrid.DataSource = null;
                locatiiDatagrid.DataSource = FakeDatabase.obiective;
            }
        }
    }
}
