namespace Images
{
    partial class Images
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
            this.components = new System.ComponentModel.Container();
            this.valeur = new System.Windows.Forms.NumericUpDown();
            this.afficher = new System.Windows.Forms.Button();
            this.ajouter = new System.Windows.Forms.Button();
            this.image = new System.Windows.Forms.PictureBox();
            this.Liste = new System.Windows.Forms.ImageList(this.components);
            this.Ouverture = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.valeur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // valeur
            // 
            this.valeur.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valeur.Location = new System.Drawing.Point(385, 161);
            this.valeur.Name = "valeur";
            this.valeur.Size = new System.Drawing.Size(68, 29);
            this.valeur.TabIndex = 1;
            this.valeur.ValueChanged += new System.EventHandler(this.valeur_ValueChanged);
            // 
            // afficher
            // 
            this.afficher.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.afficher.Location = new System.Drawing.Point(51, 347);
            this.afficher.Name = "afficher";
            this.afficher.Size = new System.Drawing.Size(198, 38);
            this.afficher.TabIndex = 2;
            this.afficher.Text = "Afficher Image";
            this.afficher.UseVisualStyleBackColor = true;
            this.afficher.Click += new System.EventHandler(this.afficher_Click);
            // 
            // ajouter
            // 
            this.ajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajouter.Location = new System.Drawing.Point(255, 347);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(198, 38);
            this.ajouter.TabIndex = 3;
            this.ajouter.Text = "Ajouter Image";
            this.ajouter.UseVisualStyleBackColor = true;
            this.ajouter.Click += new System.EventHandler(this.ajouter_Click);
            // 
            // image
            // 
            this.image.Location = new System.Drawing.Point(51, 25);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(300, 300);
            this.image.TabIndex = 4;
            this.image.TabStop = false;
            // 
            // Liste
            // 
            this.Liste.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.Liste.ImageSize = new System.Drawing.Size(250, 250);
            this.Liste.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Ouverture
            // 
            this.Ouverture.DefaultExt = "jpg";
            this.Ouverture.Filter = "Images (* .BMP; *. JPG; * .GIF, * .PNG, * .TIFF) | * .BMP; * .JPG; * .GIF; * .PNG" +
    "; * .TIFF";
            this.Ouverture.FilterIndex = 2;
            this.Ouverture.InitialDirectory = "G:\\IMAGES\\";
            this.Ouverture.RestoreDirectory = true;
            this.Ouverture.Title = "Sélectionner une image";
            // 
            // Images
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 400);
            this.Controls.Add(this.image);
            this.Controls.Add(this.ajouter);
            this.Controls.Add(this.afficher);
            this.Controls.Add(this.valeur);
            this.Name = "Images";
            this.Text = "Images";
            ((System.ComponentModel.ISupportInitialize)(this.valeur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown valeur;
        private System.Windows.Forms.Button afficher;
        private System.Windows.Forms.Button ajouter;
        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.ImageList Liste;
        private System.Windows.Forms.OpenFileDialog Ouverture;
    }
}

