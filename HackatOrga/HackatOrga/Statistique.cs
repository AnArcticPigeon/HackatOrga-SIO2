using HackatOrga.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace HackatOrga
{
    public partial class Statistique : Form
    {
        HackatonContext cnx = new HackatonContext();

        public Statistique()
        {
            InitializeComponent();
        }

        private void Statistique_Load(object sender, EventArgs e)
        {
            //.Where(stats => stats.nbParticipant == 1)
            var list = cnx.Statistiques.ToList();
            dgvStats.DataSource = list;

            dgvStats.Columns[0].Visible = false;

            foreach (DataGridViewRow row in dgvStats.Rows)
            {
                var totalPlaces = Convert.ToInt32(row.Cells[3].Value);
                var registeredCount = Convert.ToInt32(row.Cells[2].Value);

                var halfThreshold = totalPlaces / 2;

                if (registeredCount == 0 || registeredCount < halfThreshold)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.Green;
                }
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            new Menu().Show();
        }

        private void btnAttelier_Click(object sender, EventArgs e)
        {
            if (dgvStats.SelectedRows.Count > 0)
            {
                var selectedHackathonId = Convert.ToInt32(dgvStats.SelectedRows[0].Cells["IdHackaton"].Value);

                // get les ateliers du Hackathon et le nombre de participants a chaque ateliers
                var ateliers = cnx.Evenements
                  .Where(a => a.IdHackaton == selectedHackathonId && a.Type == "place")
                  .Select(a => new
                  {
                      a.Theme,
                      a.Salle,
                      a.DateDeb,
                      a.DateFin,
                      NbParticipant = cnx.Participants.Count(p => p.IdAtelier == a.Id),
                      a.NbPlace
                  }).ToList();

                dgvAtelier.DataSource = ateliers;

                foreach (DataGridViewRow row in dgvAtelier.Rows)
                {
                    var totalPlaces = Convert.ToInt32(row.Cells[5].Value);
                    var registeredCount = Convert.ToInt32(row.Cells[4].Value);

                    var halfThreshold = totalPlaces / 2;

                    if (registeredCount == 0 || registeredCount < halfThreshold)
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = Color.Green;
                    }
                }

            }
            else
            {
                // No Hackathon selected
                MessageBox.Show("Veuillez selectioner un Hackathon.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
