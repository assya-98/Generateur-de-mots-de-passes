using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generateur_de_mdp
{
    public partial class Form2 : Form
    {
        public int NbPasswords { get; set; }
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnValid_Click(object sender, EventArgs e)
        {
            try
            {
                NbPasswords = int.Parse(edNbPassword.Text);
                if (NbPasswords == 0)
                {
                    MessageBox.Show("Veuillez saisir un nombre supérieurà 0", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                this.Close(); // on ferme la fenêtre
            }
            catch
            {
                MessageBox.Show("Veuillez saisir un nombre supérieur à 0", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            }
        }
 }

