namespace HassayouneHanine
{
    partial class ListerLivres
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TitreLivre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Auteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnneeSortie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeLivre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editeur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.Recherche = new System.Windows.Forms.Label();
            this.text_Recherche = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Quitter = new System.Windows.Forms.Button();
            this.Supprimer = new System.Windows.Forms.Button();
            this.Modifier = new System.Windows.Forms.Button();
            this.Ajouter = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(823, 405);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ISBN,
            this.TitreLivre,
            this.Auteur,
            this.AnneeSortie,
            this.TypeLivre,
            this.Editeur});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(12, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 251);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ISBN
            // 
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.Name = "ISBN";
            // 
            // TitreLivre
            // 
            this.TitreLivre.HeaderText = "TitreLivre";
            this.TitreLivre.Name = "TitreLivre";
            // 
            // Auteur
            // 
            this.Auteur.HeaderText = "Auteur";
            this.Auteur.Name = "Auteur";
            // 
            // AnneeSortie
            // 
            this.AnneeSortie.HeaderText = "AnneeSortie";
            this.AnneeSortie.Name = "AnneeSortie";
            // 
            // TypeLivre
            // 
            this.TypeLivre.HeaderText = "TypeLivre";
            this.TypeLivre.Name = "TypeLivre";
            // 
            // Editeur
            // 
            this.Editeur.HeaderText = "Editeur";
            this.Editeur.Name = "Editeur";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.Recherche);
            this.panel2.Controls.Add(this.text_Recherche);
            this.panel2.Location = new System.Drawing.Point(12, 293);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(528, 51);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox5.Image = global::HassayouneHanine.Properties.Resources.search1;
            this.pictureBox5.Location = new System.Drawing.Point(5, 5);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(40, 40);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            // 
            // Recherche
            // 
            this.Recherche.AutoSize = true;
            this.Recherche.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Recherche.Location = new System.Drawing.Point(46, 14);
            this.Recherche.Name = "Recherche";
            this.Recherche.Size = new System.Drawing.Size(110, 22);
            this.Recherche.TabIndex = 1;
            this.Recherche.Text = "Recherche";
            // 
            // text_Recherche
            // 
            this.text_Recherche.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Recherche.Location = new System.Drawing.Point(162, 14);
            this.text_Recherche.Name = "text_Recherche";
            this.text_Recherche.Size = new System.Drawing.Size(342, 22);
            this.text_Recherche.TabIndex = 0;
            this.text_Recherche.TextChanged += new System.EventHandler(this.text_Recherche_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.Quitter);
            this.panel3.Controls.Add(this.Supprimer);
            this.panel3.Controls.Add(this.Modifier);
            this.panel3.Controls.Add(this.Ajouter);
            this.panel3.Location = new System.Drawing.Point(678, 22);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(133, 264);
            this.panel3.TabIndex = 1;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Gold;
            this.pictureBox4.Image = global::HassayouneHanine.Properties.Resources.exit1;
            this.pictureBox4.Location = new System.Drawing.Point(104, 200);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(19, 19);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Gold;
            this.pictureBox3.Image = global::HassayouneHanine.Properties.Resources.delete;
            this.pictureBox3.Location = new System.Drawing.Point(104, 139);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(19, 19);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gold;
            this.pictureBox1.Image = global::HassayouneHanine.Properties.Resources.changes;
            this.pictureBox1.Location = new System.Drawing.Point(100, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(19, 19);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Gold;
            this.pictureBox2.Image = global::HassayouneHanine.Properties.Resources.add;
            this.pictureBox2.Location = new System.Drawing.Point(99, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(19, 19);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // Quitter
            // 
            this.Quitter.BackColor = System.Drawing.Color.Gold;
            this.Quitter.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quitter.Location = new System.Drawing.Point(10, 189);
            this.Quitter.Name = "Quitter";
            this.Quitter.Size = new System.Drawing.Size(120, 40);
            this.Quitter.TabIndex = 3;
            this.Quitter.Text = "Quitter";
            this.Quitter.UseVisualStyleBackColor = false;
            this.Quitter.Click += new System.EventHandler(this.Quitter_Click);
            // 
            // Supprimer
            // 
            this.Supprimer.BackColor = System.Drawing.Color.Gold;
            this.Supprimer.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Supprimer.Location = new System.Drawing.Point(9, 129);
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Size = new System.Drawing.Size(120, 40);
            this.Supprimer.TabIndex = 2;
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseVisualStyleBackColor = false;
            this.Supprimer.Click += new System.EventHandler(this.Supprimer_Click);
            // 
            // Modifier
            // 
            this.Modifier.BackColor = System.Drawing.Color.Gold;
            this.Modifier.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modifier.Location = new System.Drawing.Point(9, 70);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(120, 40);
            this.Modifier.TabIndex = 1;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = false;
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // Ajouter
            // 
            this.Ajouter.BackColor = System.Drawing.Color.Gold;
            this.Ajouter.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ajouter.Location = new System.Drawing.Point(8, 14);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(120, 40);
            this.Ajouter.TabIndex = 0;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = false;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // ListerLivres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 405);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "ListerLivres";
            this.Text = "ListerLivres";
            this.Load += new System.EventHandler(this.ListerLivres_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitreLivre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Auteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnneeSortie;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeLivre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Editeur;
        private System.Windows.Forms.Button Supprimer;
        private System.Windows.Forms.Button Modifier;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.Label Recherche;
        private System.Windows.Forms.TextBox text_Recherche;
        private System.Windows.Forms.Button Quitter;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}

