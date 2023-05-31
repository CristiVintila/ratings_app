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
    public partial class ReviewLocatii : Form
    {
        private Guid _id;
        private Obiectiv loc;
        public ReviewLocatii(Guid ID)
        {
            InitializeComponent();
            FakeDatabase.ratings = Deserializare.DeserializareRatings();
            _id = ID;
            loc = FakeDatabase.obiective.First(x => x.Id == _id);
            locatieTextbox.Text = loc.Locatie;
            reviewDatagrid.AutoGenerateColumns = false;
            reviewDatagrid.AddColumn(0, "Calator", "Utilizator")
                .AddColumn(1, "Nota", "Nota")
                .AddColumn(2, "Descriere", "Descriere")
                .AddButtonColumn("DeleteButton", "Delete");
            reviewDatagrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            reviewDatagrid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            reviewDatagrid.DataSource = FakeDatabase.ratings.Where(x => x.NumeLocatie == loc.Locatie).ToList();
        }

        private void reviewDatagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == reviewDatagrid.Columns["DeleteButton"].Index)
            {
                
                var curent = (Rating)reviewDatagrid.CurrentRow.DataBoundItem;
                var locatieCurenta = FakeDatabase.ratings.First(x => x.NumeLocatie == curent.NumeLocatie)
                    .NumeLocatie;
                var locatie = FakeDatabase.obiective.First(x => x.Locatie == locatieCurenta);
                
                FakeDatabase.ratings.Remove(curent);
                locatie.calcReview();
                Serializare.SerializareObiective(FakeDatabase.obiective);
                reviewDatagrid.DataSource = null;
                reviewDatagrid.DataSource = FakeDatabase.ratings.Where(x => x.NumeLocatie == loc.Locatie).ToList();
                Serializare.SerializareRatings(FakeDatabase.ratings);
            }
        }
    }
}
