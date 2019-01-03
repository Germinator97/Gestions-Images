using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Images
{
    public partial class Images : Form
    {
        int i = 0;

        public Images()
        {
            InitializeComponent();
        }

        private void afficher_Click(object sender, EventArgs e)
        {
            if (i < Liste.Images.Count)
            {
                image.Image = Liste.Images[i];
            }
            else
            {
                MessageBox.Show("Aucune image n'est enregitrée pour cette valeur. Veuillez en choisir une autre", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }

        private void ajouter_Click(object sender, EventArgs e)
        {
            if (Ouverture.ShowDialog() == DialogResult.OK)
            {
                Liste.Images.Add(Image.FromFile(Ouverture.FileName));
            }
        }

        private void valeur_ValueChanged(object sender, EventArgs e)
        {
            i = Convert.ToInt32(valeur.Value);
        }
    }
}
