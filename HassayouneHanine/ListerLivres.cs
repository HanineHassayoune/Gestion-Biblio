using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HassayouneHanine
{
    public partial class ListerLivres : Form
    {
        public string sconstr = @"provider=Microsoft.jet.oleDB.4.0;Data source = DatabaseLivres.mdb";
        public ListerLivres()
        {
            InitializeComponent();
        }
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
                MessageBox.Show("***Suppression  terminer avec succée***");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Générée:" + ex.Message);
            }
        }

        public void charger_liste_livre()
        {
            dataGridView1.Rows.Clear();
            string txtsql;
            txtsql = "select * from Livre";
            OleDbConnection ocn = new OleDbConnection(sconstr);
            OleDbCommand ocm = new OleDbCommand(txtsql, ocn);
            ocm.Connection.Open();
            OleDbDataReader reader = ocm.ExecuteReader(CommandBehavior.CloseConnection);
            while (reader.Read())
            {
                string[] row = new string[] { 
                    reader.GetValue(0).ToString() ,
                    reader.GetString(1), 
                    reader.GetString(2),
                    reader.GetValue(3).ToString(),
                    reader.GetString(4),
                    reader.GetString(5)};
                dataGridView1.Rows.Add(row);


            }
            reader.Close();
            ocn.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListerLivres_Load(object sender, EventArgs e)
        {
            charger_liste_livre();
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            Hide();
            AjouterLivre fm = new AjouterLivre();
            fm.ShowDialog();
        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            int lignecourrant;
            string ISBNLivre;
            string req_sup;
            if (dataGridView1.RowCount == 0)
                return;
            lignecourrant = dataGridView1.CurrentRow.Index;

            ISBNLivre = dataGridView1.Rows[lignecourrant].Cells[0].Value.ToString();
            DialogResult Supp_livre =
                (MessageBox.Show("voulez vous supprimer le livre '" +
                dataGridView1.Rows[lignecourrant].Cells[1].Value.ToString() +
                "'", "suppression  livre", MessageBoxButtons.YesNo));
            if (Supp_livre == DialogResult.Yes)
            {
                req_sup = "delete from Livre where ISBN=" + ISBNLivre + "";
                lancerRequete(req_sup);
                charger_liste_livre();
            }
            else
            {
                return;
            }

        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            Hide();
            ModifierLivre frm_modif = new ModifierLivre();
            int lignecourrant;
            string ISBN, TitreLivre, Auteur, AnneeSortie, TypeLivre, Editeur;

            if (dataGridView1.RowCount == 0)
                return;
            lignecourrant = dataGridView1.CurrentRow.Index;
            ISBN = dataGridView1.Rows[lignecourrant].Cells[0].Value.ToString();
            TitreLivre = dataGridView1.Rows[lignecourrant].Cells[1].Value.ToString();
            Auteur = dataGridView1.Rows[lignecourrant].Cells[2].Value.ToString();
            AnneeSortie = dataGridView1.Rows[lignecourrant].Cells[3].Value.ToString();
            TypeLivre = dataGridView1.Rows[lignecourrant].Cells[4].Value.ToString();
            Editeur = dataGridView1.Rows[lignecourrant].Cells[5].Value.ToString();

            frm_modif.text_ISBN.Text = ISBN;
            frm_modif.text_Titre_Livre.Text = TitreLivre;
            frm_modif.text_Auteur.Text = Auteur;
            frm_modif.text_Annee_Sortie.Text = AnneeSortie;
            frm_modif.comboBox_Type_Livre.Text = TypeLivre;
            frm_modif.text_Editeur.Text = Editeur;
            frm_modif.text_ISBN.Enabled = false;
            frm_modif.ShowDialog();
            charger_liste_livre();
        }

        private void text_Recherche_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string txtsql;
            txtsql = "select *  from Livre where  TitreLivre like '%" + text_Recherche.Text + "%' or TypeLivre like '%" + text_Recherche.Text + "%'";
            OleDbConnection ocn = new OleDbConnection(sconstr);
            OleDbCommand ocm = new OleDbCommand(txtsql, ocn);
            ocm.Connection.Open();
            OleDbDataReader reader = ocm.ExecuteReader(CommandBehavior.CloseConnection);
            while (reader.Read())
            {
                string[] row = new string[] {
                    reader.GetValue(0).ToString() ,
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetValue(3).ToString(),
                    reader.GetString(4),
                    reader.GetString(5)};
                dataGridView1.Rows.Add(row);

            }
            reader.Close();
            ocn.Close();
        }

        private void Quitter_Click(object sender, EventArgs e)
        {
            MessageBox.Show("voulez vous fermer l'application " +MessageBoxButtons.YesNo);
            Close();
        }
    }
}
