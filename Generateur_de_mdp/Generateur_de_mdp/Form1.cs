using System.DirectoryServices;

namespace Generateur_de_mdp
{
    public partial class Form1 : Form
    {


        private static string AlphaMin = "abcdefghijklmnopqrstuvwxyz";
        private static string AlphaMaj = AlphaMin.ToUpper();
        private static string AlphaChiffres = "0123456789";
        private static string AlphaSpec = "#_@-*$";
        private string Alphabet = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        public bool CheckLenghtPasswd(out int PasswdLen)
        {
            // Convertir PasswdLen

            if (!int.TryParse(LenPswd.Text, out PasswdLen))
            {
                MessageBox.Show("La longueure doit être un nombre", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (PasswdLen <= 0)
            {
                MessageBox.Show("Votre nombre doit être supérieur à 1", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;

        }


        private bool ConstruireAlphabet()
        {
            Alphabet = string.Empty;
            if (ckMinus.Checked)
            {
                Alphabet += AlphaMin;
            }
            if (ckMaj.Checked)
            {
                Alphabet += AlphaMaj;
            }
            if (ckChiffres.Checked)
            {
                Alphabet += AlphaChiffres;
            }
            if (ckSpec.Checked)
            {
                Alphabet += AlphaSpec;
            }

            if (Alphabet.Length == 0)
            {
                MessageBox.Show("Il faut cocher au moins une case", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }


        public string GeneratorPasswd(int passwdlength)
        {
            string password = string.Empty;
            Random random = new Random();


            for (int i = 0; i < passwdlength; i++)
            {
                int index = random.Next(Alphabet.Length);
                password += Alphabet[index];
            }

            return password;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int LenPasswd = 0;

            if (!CheckLenghtPasswd(out LenPasswd))
            {
                //MessageBox.Show("Vous avez rentrer un nombre faux ! (Il doit être supérieur à 1)", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ConstruireAlphabet() == false)
            {
                return;

            }
            listMdp.Items.Add(GeneratorPasswd(LenPasswd));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listMdp.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            int LenPasswd = 0;
            int numpswd = 0;

            if (!CheckLenghtPasswd(out LenPasswd))
            {
                //MessageBox.Show("Vous avez rentrer un nombre faux ! (Il doit être supérieur à 1)", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ConstruireAlphabet() == false)
            {
                return;

            }

            // Créer une nouvelle instance de Form2
            Form2 form2 = new Form2();

            // Afficher Form2
            form2.ShowDialog();
            

            
            Console.WriteLine($"Entrez le nombre de mots de passe à générer :{numpswd} ");
            numpswd = Convert.ToInt32(Console.ReadLine());
            


            if (!CheckLenghtPasswd(out LenPasswd))
            {
                //MessageBox.Show("Vous avez rentrer un nombre faux ! (Il doit être supérieur à 1)", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for (int i = 0; i < 5 ; i++)
            {
                listMdp.Items.Add(GeneratorPasswd(LenPasswd));
            }

        }

        private void listMdp_SelectedIndexChanged(object sender, EventArgs e)
        { 
            if(listMdp.SelectedItems.ToString().Length > 1)
            {
                Clipboard.SetText(listMdp.SelectedItem.ToString());
            }
        }
    }
}


