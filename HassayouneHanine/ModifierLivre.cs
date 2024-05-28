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
    public partial class ModifierLivre : Form
    {
        public ModifierLivre()
        {
            InitializeComponent();
        }
        public string sconstr = @"provider=Microsoft.jet.oleDB.4.0;Data source = DatabaseLivres.mdb";
        public void lancerRequete(string requete)
        {
            //pour connecter avec la base
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
                MessageBox.Show("***Modification terminer avec succée***");
                Hide();
                ListerLivres frm = new ListerLivres();
                frm.Show();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Générée:" + ex.Message);
            }
        }
        private void Modifier_Click(object sender, EventArgs e)
        {
            string txtsql = "update Livre set TitreLivre= '" + text_Titre_Livre.Text
               + "', Auteur='" + text_Auteur.Text
               + "', AnneeSortie='" + text_Annee_Sortie.Text
               + "', TypeLivre='" + comboBox_Type_Livre.Text
               + "', Editeur='" + text_Editeur.Text
               + "' where ISBN = " + text_ISBN.Text + "";
            lancerRequete(txtsql);

        }

        private void Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Auteur_Click(object sender, EventArgs e)
        {

        }

        private void text_Titre_Livre_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_Type_Livre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ModifierLivre_Load(object sender, EventArgs e)
        {

        }
    }
}
