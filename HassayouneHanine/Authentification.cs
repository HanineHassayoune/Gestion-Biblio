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
    public partial class Authentification : Form
    {
        public string sconstr = @"provider=Microsoft.jet.oleDB.4.0;Data source = DatabaseLivres.mdb";
        public Authentification()
        {
            InitializeComponent();
        }

        private void Quitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Connexion_Click(object sender, EventArgs e)
        {
            string txtsql = "select count (login) from Connexion where login='" +
            text_Login.Text + "'and pwd='" + text_Password.Text + "'";
            OleDbConnection ocn = new OleDbConnection(sconstr);
            OleDbCommand ocm = new OleDbCommand(txtsql, ocn);
            Int32 ival;
            try
            {
                ocm.Connection.Open();
                //ExecuteScalar car on a un seule retour number ival
                ival = Convert.ToInt32(ocm.ExecuteScalar());
                if (ival == 0)
                {
                    System.Media.SystemSounds.Hand.Play();
                    MessageBox.Show("verifier l'identifient", "erreur login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    text_Login.Text = "";
                    text_Password.Text = "";
                    text_Login.Focus();
                    ocm.Connection.Close();
                }
                else
                {
                    ocm.Connection.Close();
                    ListerLivres frm = new ListerLivres();
                    frm.Show();
                    Hide();
                }


            }

            catch (Exception ex)
            {
                MessageBox.Show("exception Générée : " + ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
