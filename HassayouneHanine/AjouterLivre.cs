using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HassayouneHanine
{
    public partial class AjouterLivre : Form
    {

        public string sconstr = @"provider=Microsoft.jet.oleDB.4.0;Data source = DatabaseLivres.mdb";
        public void lancerRequete(string requete)
        {
           
            OleDbConnection ocn = new OleDbConnection();
            OleDbCommand ocm = new OleDbCommand();
            ocn.ConnectionString = sconstr;
            try
            {
                ocn.Open();
                ocm.Connection = ocn;
                ocm.CommandText = requete;
                ocm.ExecuteNonQuery();
                ocn.Close();
                MessageBox.Show("***insertion terminer avec succée***");
                Hide();
                ListerLivres frm = new ListerLivres();
                frm.Show();
               

            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Générée:" + ex.Message);
            }
        }
        public AjouterLivre()
        {
            InitializeComponent();
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            string txtinsert;
            txtinsert = "INSERT INTO Livre (ISBN, TitreLivre, Auteur, AnneeSortie, TypeLivre, Editeur) VALUES (" +
               "'" + text_ISBN.Text + "', " +
               "'" + text_Titre_Livre.Text + "', " +
               "'" + text_Auteur.Text + "', " +
               "'" + text_Annee_Sortie.Text + "', " +
               "'" + comboBox_Type_Livre.Text + "', " +
               "'" + text_Editeur.Text + "')";
            lancerRequete(txtinsert);
        }

        private void Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AjouterLivre_Load(object sender, EventArgs e)
        {

        }

        private void TitreLivre_Click(object sender, EventArgs e)
        {

        }

        private void Auteur_Click(object sender, EventArgs e)
        {

        }

        private void ISBN_Click(object sender, EventArgs e)
        {

        }

        private void AnneeSortie_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
