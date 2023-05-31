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
    public partial class AdminCalatori : Form
    {
        public AdminCalatori()
        {
            InitializeComponent();
            calatoriDatagrid.AutoGenerateColumns = false;
            calatoriDatagrid.AddColumn(0, "Id", "Id")
                .AddColumn(1, "Nume", "Nume")
                .AddColumn(2, "Parola", "Parola")
                .AddButtonColumn("DeleteColumn", "Delete")
                .AddButtonColumn("EditColumn", "Edit")
                .AddButtonColumn("ReviewsColumn", "Reviews");
            calatoriDatagrid.DataSource = FakeDatabase.calatori;
        }

        private void addCalatorButton_Click(object sender, EventArgs e)
        {
            var addCalator = new AdaugaCalator();
            addCalator.ShowDialog();

            calatoriDatagrid.DataSource = null;
            calatoriDatagrid.DataSource = FakeDatabase.calatori;
            Serializare.SerializareCalatori(FakeDatabase.calatori);
        }

        private void calatoriDatagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == calatoriDatagrid.Columns["DeleteColumn"].Index)
            {
                var calator = (Calator)calatoriDatagrid.CurrentRow.DataBoundItem;
                foreach(var rev in FakeDatabase.ratings.Where(x=>x.IdUtilizator==calator.Id))
                {
                    rev.IdUtilizator = Guid.Empty;
                    rev.Calator = "(cont sters)";
                }
                Serializare.SerializareRatings(FakeDatabase.ratings);
                FakeDatabase.calatori.Remove(calator);
                calatoriDatagrid.DataSource = null;
                calatoriDatagrid.DataSource = FakeDatabase.calatori;
                Serializare.SerializareCalatori(FakeDatabase.calatori);
            }
            if (e.ColumnIndex == calatoriDatagrid.Columns["EditColumn"].Index)
            {
                var calator = (Calator)calatoriDatagrid.CurrentRow.DataBoundItem;
                //deschid editCalator cu param id
                var editCalator = new EditCalator(calator.Id);
                editCalator.ShowDialog();

                calatoriDatagrid.DataSource = null;
                calatoriDatagrid.DataSource = FakeDatabase.calatori;
                Serializare.SerializareCalatori(FakeDatabase.calatori);
            }
            if (e.ColumnIndex == calatoriDatagrid.Columns["ReviewsColumn"].Index)
            {
                var calator = (Calator)calatoriDatagrid.CurrentRow.DataBoundItem;

                var reviewCalator = new ReviewCalatori(calator.Id);
                reviewCalator.ShowDialog();

                calatoriDatagrid.DataSource = null;
                calatoriDatagrid.DataSource = FakeDatabase.calatori;
            }
        }
    }
}
