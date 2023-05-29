using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9_Agenda_Proiect
{
    public partial class Agenda : Form
    {
        DataTable agenda = new DataTable();
        bool edit = false;
        public Agenda()
        {
            InitializeComponent();
        }

        private void Agenda_Load(object sender, EventArgs e)
        {
            agenda.Columns.Add("Nume");
            agenda.Columns.Add("Descriere");

            activitatiVechi.DataSource = agenda;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                agenda.Rows[activitatiVechi.CurrentCell.RowIndex]["Nume"] = numeBox.Text;
                agenda.Rows[activitatiVechi.CurrentCell.RowIndex]["Descriere"] = descriereBox.Text;
            }
            else
            {
                agenda.Rows.Add(numeBox.Text, descriereBox.Text);
            }

            numeBox.Text = "";
            descriereBox.Text = "";
            edit = false;
        }

        private void nouButton_Click(object sender, EventArgs e)
        {
            numeBox.Text = "";
            descriereBox.Text = "";
        }

        private void afiseasaButton_Click(object sender, EventArgs e)
        {
            numeBox.Text = agenda.Rows[activitatiVechi.CurrentCell.RowIndex].ItemArray[0].ToString();
            descriereBox.Text = agenda.Rows[activitatiVechi.CurrentCell.RowIndex].ItemArray[1].ToString();
            edit = true;
        }

        private void stergeButton_Click(object sender, EventArgs e)
        {
            try
            {
                agenda.Rows[activitatiVechi.CurrentCell.RowIndex].Delete();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Informatiile nu sunt valide!");
            }
        }

        private void activitatiVechi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            numeBox.Text = agenda.Rows[activitatiVechi.CurrentCell.RowIndex].ItemArray[0].ToString();
            descriereBox.Text = agenda.Rows[activitatiVechi.CurrentCell.RowIndex].ItemArray[1].ToString();
            edit = true;
        }
    }
}
