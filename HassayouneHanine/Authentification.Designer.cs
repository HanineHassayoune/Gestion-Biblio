namespace HassayouneHanine
{
    partial class Authentification
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
            this.Quitter = new System.Windows.Forms.Button();
            this.Connexion = new System.Windows.Forms.Button();
            this.text_Password = new System.Windows.Forms.TextBox();
            this.text_Login = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Quitter
            // 
            this.Quitter.BackColor = System.Drawing.Color.Gold;
            this.Quitter.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quitter.Location = new System.Drawing.Point(466, 313);
            this.Quitter.Name = "Quitter";
            this.Quitter.Size = new System.Drawing.Size(145, 45);
            this.Quitter.TabIndex = 5;
            this.Quitter.Text = "Quitter";
            this.Quitter.UseVisualStyleBackColor = false;
            this.Quitter.Click += new System.EventHandler(this.Quitter_Click);
            // 
            // Connexion
            // 
            this.Connexion.BackColor = System.Drawing.Color.Gold;
            this.Connexion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Connexion.Location = new System.Drawing.Point(294, 313);
            this.Connexion.Name = "Connexion";
            this.Connexion.Size = new System.Drawing.Size(145, 45);
            this.Connexion.TabIndex = 4;
            this.Connexion.Text = "Connexion";
            this.Connexion.UseVisualStyleBackColor = false;
            this.Connexion.Click += new System.EventHandler(this.Connexion_Click);
            // 
            // text_Password
            // 
            this.text_Password.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Password.Location = new System.Drawing.Point(359, 199);
            this.text_Password.Name = "text_Password";
            this.text_Password.Size = new System.Drawing.Size(269, 22);
            this.text_Password.TabIndex = 3;
            this.text_Password.Text = "admin";
            this.text_Password.UseSystemPasswordChar = true;
            // 
            // text_Login
            // 
            this.text_Login.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Login.Location = new System.Drawing.Point(359, 110);
            this.text_Login.Name = "text_Login";
            this.text_Login.Size = new System.Drawing.Size(269, 22);
            this.text_Login.TabIndex = 2;
            this.text_Login.Text = "admin";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Password.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Password.Location = new System.Drawing.Point(234, 199);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(109, 24);
            this.Password.TabIndex = 1;
            this.Password.Text = "Password";
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Login.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Login.Location = new System.Drawing.Point(233, 110);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(61, 25);
            this.Login.TabIndex = 0;
            this.Login.Text = "Login";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Gold;
            this.pictureBox3.Image = global::HassayouneHanine.Properties.Resources.login;
            this.pictureBox3.Location = new System.Drawing.Point(408, 326);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(19, 19);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Gold;
            this.pictureBox2.Image = global::HassayouneHanine.Properties.Resources.exit;
            this.pictureBox2.Location = new System.Drawing.Point(581, 327);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(19, 19);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HassayouneHanine.Properties.Resources.ee;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(640, 376);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Authentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 370);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.text_Password);
            this.Controls.Add(this.Quitter);
            this.Controls.Add(this.Connexion);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.text_Login);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Authentification";
            this.Text = "Authentification";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.TextBox text_Password;
        private System.Windows.Forms.TextBox text_Login;
        private System.Windows.Forms.Button Quitter;
        private System.Windows.Forms.Button Connexion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}