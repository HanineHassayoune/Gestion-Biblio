namespace HassayouneHanine
{
    partial class ModifierLivre
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
            this.Modifier = new System.Windows.Forms.Button();
            this.Annuler = new System.Windows.Forms.Button();
            this.comboBox_Type_Livre = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.text_Editeur = new System.Windows.Forms.TextBox();
            this.text_Annee_Sortie = new System.Windows.Forms.TextBox();
            this.text_ISBN = new System.Windows.Forms.TextBox();
            this.text_Auteur = new System.Windows.Forms.TextBox();
            this.text_Titre_Livre = new System.Windows.Forms.TextBox();
            this.Editeur = new System.Windows.Forms.Label();
            this.TypeLivre = new System.Windows.Forms.Label();
            this.AnneeSortie = new System.Windows.Forms.Label();
            this.Auteur = new System.Windows.Forms.Label();
            this.TitreLivre = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ISBN
            // 
            this.ISBN.AutoSize = true;
            this.ISBN.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ISBN.Location = new System.Drawing.Point(325, 24);
            this.ISBN.Name = "ISBN";
            this.ISBN.Size = new System.Drawing.Size(38, 16);
            this.ISBN.TabIndex = 14;
            this.ISBN.Text = "ISBN";
            // 
            // Modifier
            // 
            this.Modifier.BackColor = System.Drawing.Color.Gold;
            this.Modifier.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modifier.Location = new System.Drawing.Point(429, 332);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(120, 40);
            this.Modifier.TabIndex = 0;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = false;
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // Annuler
            // 
            this.Annuler.BackColor = System.Drawing.Color.Gold;
            this.Annuler.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Annuler.Location = new System.Drawing.Point(559, 332);
            this.Annuler.Name = "Annuler";
            this.Annuler.Size = new System.Drawing.Size(120, 40);
            this.Annuler.TabIndex = 1;
            this.Annuler.Text = "Annuler";
            this.Annuler.UseVisualStyleBackColor = false;
            this.Annuler.Click += new System.EventHandler(this.Annuler_Click);
            // 
            // comboBox_Type_Livre
            // 
            this.comboBox_Type_Livre.FormattingEnabled = true;
            this.comboBox_Type_Livre.Items.AddRange(new object[] {
            "Roman",
            "Action",
            "Comédie",
            "Horreur"});
            this.comboBox_Type_Livre.Location = new System.Drawing.Point(429, 233);
            this.comboBox_Type_Livre.Name = "comboBox_Type_Livre";
            this.comboBox_Type_Livre.Size = new System.Drawing.Size(250, 21);
            this.comboBox_Type_Livre.TabIndex = 0;
            this.comboBox_Type_Livre.SelectedIndexChanged += new System.EventHandler(this.comboBox_Type_Livre_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.Annuler);
            this.panel1.Controls.Add(this.Modifier);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.text_Editeur);
            this.panel1.Controls.Add(this.comboBox_Type_Livre);
            this.panel1.Controls.Add(this.text_Annee_Sortie);
            this.panel1.Controls.Add(this.text_ISBN);
            this.panel1.Controls.Add(this.text_Auteur);
            this.panel1.Controls.Add(this.text_Titre_Livre);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(695, 391);
            this.panel1.TabIndex = 25;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HassayouneHanine.Properties.Resources.iiiiiiiii;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(313, 390);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // text_Editeur
            // 
            this.text_Editeur.Location = new System.Drawing.Point(429, 295);
            this.text_Editeur.Name = "text_Editeur";
            this.text_Editeur.Size = new System.Drawing.Size(250, 20);
            this.text_Editeur.TabIndex = 24;
            // 
            // text_Annee_Sortie
            // 
            this.text_Annee_Sortie.Location = new System.Drawing.Point(429, 179);
            this.text_Annee_Sortie.MaxLength = 4;
            this.text_Annee_Sortie.Name = "text_Annee_Sortie";
            this.text_Annee_Sortie.Size = new System.Drawing.Size(250, 20);
            this.text_Annee_Sortie.TabIndex = 23;
            // 
            // text_ISBN
            // 
            this.text_ISBN.Location = new System.Drawing.Point(429, 20);
            this.text_ISBN.MaxLength = 13;
            this.text_ISBN.Name = "text_ISBN";
            this.text_ISBN.Size = new System.Drawing.Size(250, 20);
            this.text_ISBN.TabIndex = 20;
            // 
            // text_Auteur
            // 
            this.text_Auteur.Location = new System.Drawing.Point(429, 121);
            this.text_Auteur.MaxLength = 15;
            this.text_Auteur.Name = "text_Auteur";
            this.text_Auteur.Size = new System.Drawing.Size(250, 20);
            this.text_Auteur.TabIndex = 22;
            // 
            // text_Titre_Livre
            // 
            this.text_Titre_Livre.Location = new System.Drawing.Point(429, 62);
            this.text_Titre_Livre.Name = "text_Titre_Livre";
            this.text_Titre_Livre.Size = new System.Drawing.Size(250, 20);
            this.text_Titre_Livre.TabIndex = 21;
            this.text_Titre_Livre.TextChanged += new System.EventHandler(this.text_Titre_Livre_TextChanged);
            // 
            // Editeur
            // 
            this.Editeur.AutoSize = true;
            this.Editeur.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Editeur.Location = new System.Drawing.Point(325, 299);
            this.Editeur.Name = "Editeur";
            this.Editeur.Size = new System.Drawing.Size(52, 16);
            this.Editeur.TabIndex = 19;
            this.Editeur.Text = "Editeur";
            // 
            // TypeLivre
            // 
            this.TypeLivre.AutoSize = true;
            this.TypeLivre.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeLivre.Location = new System.Drawing.Point(325, 238);
            this.TypeLivre.Name = "TypeLivre";
            this.TypeLivre.Size = new System.Drawing.Size(73, 16);
            this.TypeLivre.TabIndex = 18;
            this.TypeLivre.Text = "Type Livre";
            // 
            // AnneeSortie
            // 
            this.AnneeSortie.AutoSize = true;
            this.AnneeSortie.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnneeSortie.Location = new System.Drawing.Point(325, 183);
            this.AnneeSortie.Name = "AnneeSortie";
            this.AnneeSortie.Size = new System.Drawing.Size(90, 16);
            this.AnneeSortie.TabIndex = 17;
            this.AnneeSortie.Text = "Année Sortie";
            // 
            // Auteur
            // 
            this.Auteur.AutoSize = true;
            this.Auteur.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Auteur.Location = new System.Drawing.Point(325, 125);
            this.Auteur.Name = "Auteur";
            this.Auteur.Size = new System.Drawing.Size(49, 16);
            this.Auteur.TabIndex = 16;
            this.Auteur.Text = "Auteur";
            // 
            // TitreLivre
            // 
            this.TitreLivre.AutoSize = true;
            this.TitreLivre.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitreLivre.Location = new System.Drawing.Point(325, 69);
            this.TitreLivre.Name = "TitreLivre";
            this.TitreLivre.Size = new System.Drawing.Size(96, 16);
            this.TitreLivre.TabIndex = 15;
            this.TitreLivre.Text = "Titre de Livre ";
            this.TitreLivre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Gold;
            this.pictureBox3.Image = global::HassayouneHanine.Properties.Resources.cancel__1_1;
            this.pictureBox3.Location = new System.Drawing.Point(649, 343);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(19, 19);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Gold;
            this.pictureBox2.Image = global::HassayouneHanine.Properties.Resources.changes;
            this.pictureBox2.Location = new System.Drawing.Point(522, 343);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(19, 19);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // ModifierLivre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 384);
            this.Controls.Add(this.Editeur);
            this.Controls.Add(this.TypeLivre);
            this.Controls.Add(this.AnneeSortie);
            this.Controls.Add(this.Auteur);
            this.Controls.Add(this.TitreLivre);
            this.Controls.Add(this.ISBN);
            this.Controls.Add(this.panel1);
            this.Name = "ModifierLivre";
            this.Text = "ModifierLivre";
            this.Load += new System.EventHandler(this.ModifierLivre_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ISBN;
        private System.Windows.Forms.Button Modifier;
        private System.Windows.Forms.Button Annuler;
        public System.Windows.Forms.ComboBox comboBox_Type_Livre;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox text_ISBN;
        public System.Windows.Forms.TextBox text_Titre_Livre;
        public System.Windows.Forms.TextBox text_Auteur;
        public System.Windows.Forms.TextBox text_Annee_Sortie;
        public System.Windows.Forms.TextBox text_Editeur;
        private System.Windows.Forms.Label Editeur;
        private System.Windows.Forms.Label TypeLivre;
        private System.Windows.Forms.Label AnneeSortie;
        private System.Windows.Forms.Label Auteur;
        private System.Windows.Forms.Label TitreLivre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}