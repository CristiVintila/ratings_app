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
    public partial class ReviewCalatori : Form
    {
        private Guid _id;
        public ReviewCalatori(Guid ID)
        {
            InitializeComponent();
            FakeDatabase.ratings = Deserializare.DeserializareRatings();
            _id = ID;
            calatorTextbox.Text = FakeDatabase.calatori.First(x => x.Id == _id).Nume;
            reviewDatagrid.AutoGenerateColumns = false;

            reviewDatagrid.AddColumn(0, "NumeLocatie", "Locatie")
                .AddColumn(1, "Nota", "Nota")
                .AddColumn(2, "Descriere", "Descriere")
                .AddButtonColumn("DeleteButton", "Delete");
            reviewDatagrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            reviewDatagrid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            reviewDatagrid.DataSource = FakeDatabase.ratings.Where(x=>x.IdUtilizator == ID).ToList();
        }

        private void reviewDatagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == reviewDatagrid.Columns["DeleteButton"].Index)
            {
                var curent = (Rating)reviewDatagrid.CurrentRow.DataBoundItem;
                var locatieCurenta = FakeDatabase.ratings.First(x => x.IdUtilizator == curent.IdUtilizator)
                    .NumeLocatie;
                var locatie = FakeDatabase.obiective.First(x => x.Locatie == locatieCurenta);

                FakeDatabase.ratings.Remove(curent);
                locatie.calcReview();
                Serializare.SerializareObiective(FakeDatabase.obiective);
                reviewDatagrid.DataSource = null;
                reviewDatagrid.DataSource = FakeDatabase.ratings.Where(x => x.IdUtilizator == _id).ToList();
                Serializare.SerializareRatings(FakeDatabase.ratings);
            }
        }
    }
}
