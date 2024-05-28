namespace HassayouneHanine
{
    partial class AjouterLivre
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ISBN = new System.Windows.Forms.Label();
            this.TitreLivre = new System.Windows.Forms.Label();
            this.Auteur = new System.Windows.Forms.Label();
            this.AnneeSortie = new System.Windows.Forms.Label();
            this.TypeLivre = new System.Windows.Forms.Label();
            this.Editeur = new System.Windows.Forms.Label();
            this.text_ISBN = new System.Windows.Forms.TextBox();
            this.text_Titre_Livre = new System.Windows.Forms.TextBox();
            this.text_Auteur = new System.Windows.Forms.TextBox();
            this.text_Annee_Sortie = new System.Windows.Forms.TextBox();
            this.text_Editeur = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox_Type_Livre = new System.Windows.Forms.ComboBox();
            this.Annuler = new System.Windows.Forms.Button();
            this.Ajouter = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ISBN
            // 
            this.ISBN.AutoSize = true;
            this.ISBN.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ISBN.Location = new System.Drawing.Point(324, 25);
            this.ISBN.Name = "ISBN";
            this.ISBN.Size = new System.Drawing.Size(38, 16);
            this.ISBN.TabIndex = 0;
            this.ISBN.Text = "ISBN";
            this.ISBN.Click += new System.EventHandler(this.ISBN_Click);
            // 
            // TitreLivre
            // 
            this.TitreLivre.AutoSize = true;
            this.TitreLivre.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitreLivre.Location = new System.Drawing.Point(324, 70);
            this.TitreLivre.Name = "TitreLivre";
            this.TitreLivre.Size = new System.Drawing.Size(96, 16);
            this.TitreLivre.TabIndex = 1;
            this.TitreLivre.Text = "Titre de Livre ";
            this.TitreLivre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TitreLivre.Click += new System.EventHandler(this.TitreLivre_Click);
            // 
            // Auteur
            // 
            this.Auteur.AutoSize = true;
            this.Auteur.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Auteur.Location = new System.Drawing.Point(324, 126);
            this.Auteur.Name = "Auteur";
            this.Auteur.Size = new System.Drawing.Size(49, 16);
            this.Auteur.TabIndex = 2;
            this.Auteur.Text = "Auteur";
            this.Auteur.Click += new System.EventHandler(this.Auteur_Click);
            // 
            // AnneeSortie
            // 
            this.AnneeSortie.AutoSize = true;
            this.AnneeSortie.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnneeSortie.Location = new System.Drawing.Point(324, 184);
            this.AnneeSortie.Name = "AnneeSortie";
            this.AnneeSortie.Size = new System.Drawing.Size(90, 16);
            this.AnneeSortie.TabIndex = 3;
            this.AnneeSortie.Text = "Année Sortie";
            this.AnneeSortie.Click += new System.EventHandler(this.AnneeSortie_Click);
            // 
            // TypeLivre
            // 
            this.TypeLivre.AutoSize = true;
            this.TypeLivre.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeLivre.Location = new System.Drawing.Point(324, 239);
            this.TypeLivre.Name = "TypeLivre";
            this.TypeLivre.Size = new System.Drawing.Size(73, 16);
            this.TypeLivre.TabIndex = 4;
            this.TypeLivre.Text = "Type Livre";
            // 
            // Editeur
            // 
            this.Editeur.AutoSize = true;
            this.Editeur.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Editeur.Location = new System.Drawing.Point(324, 300);
            this.Editeur.Name = "Editeur";
            this.Editeur.Size = new System.Drawing.Size(52, 16);
            this.Editeur.TabIndex = 5;
            this.Editeur.Text = "Editeur";
            // 
            // text_ISBN
            // 
            this.text_ISBN.Location = new System.Drawing.Point(429, 22);
            this.text_ISBN.MaxLength = 13;
            this.text_ISBN.Name = "text_ISBN";
            this.text_ISBN.Size = new System.Drawing.Size(250, 20);
            this.text_ISBN.TabIndex = 6;
            // 
            // text_Titre_Livre
            // 
            this.text_Titre_Livre.Location = new System.Drawing.Point(429, 67);
            this.text_Titre_Livre.Name = "text_Titre_Livre";
            this.text_Titre_Livre.Size = new System.Drawing.Size(250, 20);
            this.text_Titre_Livre.TabIndex = 7;
            // 
            // text_Auteur
            // 
            this.text_Auteur.Location = new System.Drawing.Point(429, 123);
            this.text_Auteur.MaxLength = 15;
            this.text_Auteur.Name = "text_Auteur";
            this.text_Auteur.Size = new System.Drawing.Size(250, 20);
            this.text_Auteur.TabIndex = 8;
            // 
            // text_Annee_Sortie
            // 
            this.text_Annee_Sortie.Location = new System.Drawing.Point(429, 181);
            this.text_Annee_Sortie.MaxLength = 4;
            this.text_Annee_Sortie.Name = "text_Annee_Sortie";
            this.text_Annee_Sortie.Size = new System.Drawing.Size(250, 20);
            this.text_Annee_Sortie.TabIndex = 9;
            // 
            // text_Editeur
            // 
            this.text_Editeur.Location = new System.Drawing.Point(429, 297);
            this.text_Editeur.Name = "text_Editeur";
            this.text_Editeur.Size = new System.Drawing.Size(250, 20);
            this.text_Editeur.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.comboBox_Type_Livre);
            this.panel1.Controls.Add(this.Annuler);
            this.panel1.Controls.Add(this.Ajouter);
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(695, 391);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Gold;
            this.pictureBox2.Image = global::HassayouneHanine.Properties.Resources.add;
            this.pictureBox2.Location = new System.Drawing.Point(523, 346);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(19, 19);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Gold;
            this.pictureBox3.Image = global::HassayouneHanine.Properties.Resources.cancel__1_1;
            this.pictureBox3.Location = new System.Drawing.Point(657, 346);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(19, 19);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HassayouneHanine.Properties.Resources.iiiiiiiii;
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(313, 390);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox_Type_Livre
            // 
            this.comboBox_Type_Livre.FormattingEnabled = true;
            this.comboBox_Type_Livre.Items.AddRange(new object[] {
            "Roman",
            "Action",
            "Comédie",
            "Horreur"});
            this.comboBox_Type_Livre.Location = new System.Drawing.Point(433, 233);
            this.comboBox_Type_Livre.Name = "comboBox_Type_Livre";
            this.comboBox_Type_Livre.Size = new System.Drawing.Size(250, 21);
            this.comboBox_Type_Livre.TabIndex = 0;
            // 
            // Annuler
            // 
            this.Annuler.BackColor = System.Drawing.Color.Gold;
            this.Annuler.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Annuler.Location = new System.Drawing.Point(568, 335);
            this.Annuler.Name = "Annuler";
            this.Annuler.Size = new System.Drawing.Size(120, 40);
            this.Annuler.TabIndex = 1;
            this.Annuler.Text = "Annuler";
            this.Annuler.UseVisualStyleBackColor = false;
            this.Annuler.Click += new System.EventHandler(this.Annuler_Click);
            // 
            // Ajouter
            // 
            this.Ajouter.BackColor = System.Drawing.Color.Gold;
            this.Ajouter.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ajouter.Location = new System.Drawing.Point(433, 335);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(120, 40);
            this.Ajouter.TabIndex = 0;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = false;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // AjouterLivre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(690, 388);
            this.Controls.Add(this.text_Editeur);
            this.Controls.Add(this.text_Annee_Sortie);
            this.Controls.Add(this.text_Auteur);
            this.Controls.Add(this.text_Titre_Livre);
            this.Controls.Add(this.text_ISBN);
            this.Controls.Add(this.Editeur);
            this.Controls.Add(this.TypeLivre);
            this.Controls.Add(this.AnneeSortie);
            this.Controls.Add(this.Auteur);
            this.Controls.Add(this.TitreLivre);
            this.Controls.Add(this.ISBN);
            this.Controls.Add(this.panel1);
            this.Name = "AjouterLivre";
            this.Text = "AjouterLivre";
            this.Load += new System.EventHandler(this.AjouterLivre_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ISBN;
        private System.Windows.Forms.Label TitreLivre;
        private System.Windows.Forms.Label Auteur;
        private System.Windows.Forms.Label AnneeSortie;
        private System.Windows.Forms.Label TypeLivre;
        private System.Windows.Forms.Label Editeur;
        private System.Windows.Forms.TextBox text_ISBN;
        private System.Windows.Forms.TextBox text_Titre_Livre;
        private System.Windows.Forms.TextBox text_Auteur;
        private System.Windows.Forms.TextBox text_Annee_Sortie;
        private System.Windows.Forms.TextBox text_Editeur;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Annuler;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.ComboBox comboBox_Type_Livre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}