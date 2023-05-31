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

namespace proiectPAW.Forms.GeneralView
{
    public partial class AdaugaReview : Form
    {
        private string _locatie;
        private Guid _id;
        public AdaugaReview(string nume, Guid Id)
        {
            InitializeComponent();
            FakeDatabase.ratings = Deserializare.DeserializareRatings();
            _id = Id;
            _locatie = nume;
            ratingLabel.Text = avgRating().ToString();
            locatieTextbox.Text = nume;
            reviewDatagrid.AutoGenerateColumns = false;
            reviewDatagrid.AddColumn(0, "Calator", "Utilizator")
                .AddColumn(1, "Nota", "Nota")
                .AddColumn(2, "Descriere", "Review")
                .AddButtonColumn("DeleteColumn", "Delete")
                .AddButtonColumn("EditColumn", "Edit");
            reviewDatagrid.DataSource = FakeDatabase.ratings.Where(x=>x.NumeLocatie==_locatie).ToList();
            reviewDatagrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            reviewDatagrid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private double avgRating()
        {
            double rating = 0;
            double nr = 0;
            if (FakeDatabase.ratings.Where(x => x.NumeLocatie == _locatie).Count() != 0)
            {
                nr = FakeDatabase.ratings.Where(x => x.NumeLocatie == _locatie).Count();
                foreach (var rev in FakeDatabase.ratings.Where(x => x.NumeLocatie == _locatie))
                {
                    rating += rev.Nota;
                }
                rating = rating / nr;
                return rating;
            }
            else
            {
                return 1; 
            }
        }

        private void addReviewButton_Click(object sender, EventArgs e)
        {
            Rating r = new Rating();
            r.IdUtilizator = _id;
            r.NumeLocatie = _locatie;
            r.Nota = notaTrackBar.Value;
            r.Descriere = reviewTextbox.Text;
            r.Calator = FakeDatabase.calatori.First(x => x.Id == _id).Nume;
            FakeDatabase.ratings.Add(r);

            notaTrackBar.Value = 1;
            reviewTextbox.Text = "";
            ratingLabel.Text = avgRating().ToString();

            reviewDatagrid.DataSource = null;
            reviewDatagrid.DataSource = FakeDatabase.ratings.Where(x => x.NumeLocatie == _locatie).ToList();
            Serializare.SerializareRatings(FakeDatabase.ratings);
            FakeDatabase.obiective.First(x => x.Locatie == _locatie).calcReview();
            Serializare.SerializareObiective(FakeDatabase.obiective);
        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            FakeDatabase.obiective.First(x => x.Locatie == _locatie).Review = avgRating();
            Serializare.SerializareObiective(FakeDatabase.obiective);
            Hide();
        }

        private void reviewDatagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == reviewDatagrid.Columns["DeleteColumn"].Index)
            {
                var curent = (Rating)reviewDatagrid.CurrentRow.DataBoundItem;
                if (curent.IdUtilizator == _id)
                {
                    var locatie = FakeDatabase.obiective.First(x => x.Locatie == _locatie);
                    FakeDatabase.ratings.Remove(curent);
                    locatie.calcReview();

                    reviewDatagrid.DataSource = null;
                    reviewDatagrid.DataSource = FakeDatabase.ratings.Where(x => x.NumeLocatie == _locatie).ToList();

                    Serializare.SerializareRatings(FakeDatabase.ratings);
                    Serializare.SerializareObiective(FakeDatabase.obiective);
                }
                else
                {
                    MessageBox.Show("Nu puteti sterge comentariile altor utilizatori!");
                }
            }
            if (e.ColumnIndex == reviewDatagrid.Columns["EditColumn"].Index)
            {
                var curent = (Rating)reviewDatagrid.CurrentRow.DataBoundItem;
                if (curent.IdUtilizator == _id)
                {
                    reviewTextbox.Text = curent.Descriere;
                    notaTrackBar.Value = (int)curent.Nota;
                    modificaButton.Visible = true;
                    modificaButton.Enabled = true;
                    addReviewButton.Enabled = false;
                    addReviewButton.Visible = false;
                }
                else
                {
                    MessageBox.Show("Nu puteti edita comentariul altui utilizator!");
                }
            }
        }

        private void modificaButton_Click(object sender, EventArgs e)
        {
            Rating rating = FakeDatabase.ratings.FirstOrDefault(x => x.IdUtilizator == _id && x.NumeLocatie == _locatie);
            Obiectiv locatie = FakeDatabase.obiective.FirstOrDefault(x => x.Locatie == _locatie);
            rating.IdUtilizator = _id;
            rating.NumeLocatie = _locatie;
            rating.Nota = notaTrackBar.Value;
            rating.Descriere = reviewTextbox.Text;
            locatie.calcReview();
            ratingLabel.Text = locatie.Review.ToString();

            reviewDatagrid.DataSource = null;
            reviewDatagrid.DataSource = FakeDatabase.ratings.Where(x => x.NumeLocatie == _locatie).ToList();

            Serializare.SerializareRatings(FakeDatabase.ratings);
            Serializare.SerializareObiective(FakeDatabase.obiective);

            reviewTextbox.Text = "";
            notaTrackBar.Value = 1;

            modificaButton.Visible = false;
            modificaButton.Enabled = false;
            addReviewButton.Enabled = true;
            addReviewButton.Visible = true;
            
        }
    }
}
