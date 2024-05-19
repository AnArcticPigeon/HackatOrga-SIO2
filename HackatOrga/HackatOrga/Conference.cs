using HackatOrga.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace HackatOrga
{
    public partial class Conference : Form
    {
        HackatonContext cnx = new HackatonContext();
        public Conference()
        {
            InitializeComponent();
        }

        private void Conference_Load(object sender, EventArgs e)
        {
            var conferences = cnx.Evenements
                .Where(a => a.Type == "theme")
                .Select(a => new
                {
                    Hackathon_Nom = cnx.Hackatons.FirstOrDefault(p => p.Id == a.IdHackaton).Nom,
                    a.DateDeb,
                    a.DateFin,
                    Intervenant_Nom = cnx.Intervenants.FirstOrDefault(q => q.Id == a.IdIntervenant).Nom,
                    Intervenant_Prenom = cnx.Intervenants.FirstOrDefault(q => q.Id == a.IdIntervenant).Prenom,
                    Intervenant_Email = cnx.Intervenants.FirstOrDefault(q => q.Id == a.IdIntervenant).Email
                })
                .OrderBy(a => a.DateDeb) // Order by starting date
                .ToList();

            dgvConference.DataSource = conferences;

            foreach (DataGridViewRow row in dgvConference.Rows)
            {
                var dateDeb = (DateOnly)row.Cells[1].Value;
                var dateFin = (DateOnly)row.Cells[2].Value;
                var dateTimeNow = DateOnly.FromDateTime(DateTime.Now);
                var dateNextWeek = dateTimeNow.AddDays(7);

                if (dateTimeNow >= dateDeb && dateTimeNow <= dateFin)
                {
                    // Event is currently ongoing
                    row.DefaultCellStyle.BackColor = Color.Green;
                }
                else if (dateTimeNow > dateFin)
                {
                    // Event is already finished
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
                else if (dateTimeNow < dateDeb && dateDeb <= dateNextWeek)
                {
                    // Event is scheduled to start in less than a week
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                }
            }
        }


        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            new Menu().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvConference.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvConference.SelectedRows)
                {

                    string hackathonNom = row.Cells["Hackathon_Nom"].Value.ToString();
                    string confDateDeb = row.Cells["DateDeb"].Value.ToString();
                    string intervenantNom = row.Cells["Intervenant_Nom"].Value.ToString();
                    string intervenantPrenom = row.Cells["Intervenant_Prenom"].Value.ToString();
                    string emailAddress = row.Cells["Intervenant_Email"].Value.ToString();

                    // Create and configure the email message
                    MailMessage mail = new MailMessage();
                    mail.From = new MailAddress("kewis45105@neixos.com");
                    mail.To.Add(emailAddress);
                    mail.Subject = "Rapel Conference";
                    mail.Body = $"Monsieur, Madame {intervenantPrenom} {intervenantNom},\n\nNous vous rappelons que vous etes presentateur de la conference pour le Hackathon '{hackathonNom}' qui aura lieu le '{confDateDeb}'.\n\nCordialement,\n";

                    // Configure SMTP client
                    SmtpClient smtpClient = new SmtpClient("smtp.example.com");
                    smtpClient.Port = 587;
                    smtpClient.Credentials = new System.Net.NetworkCredential("kewis45105@neixos.com", "your_password");
                    smtpClient.EnableSsl = true;

                    // Send email
                    smtpClient.Send(mail);
                }

                MessageBox.Show("Emails envoyer!");
            }
            else
            {
                // No Intervenant selected
                MessageBox.Show("Veuillez selectioner une Conference.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
