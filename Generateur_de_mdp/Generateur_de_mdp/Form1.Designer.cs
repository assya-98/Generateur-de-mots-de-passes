namespace Generateur_de_mdp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ckMinus = new CheckBox();
            ckMaj = new CheckBox();
            ckChiffres = new CheckBox();
            ckSpec = new CheckBox();
            groupBox1 = new GroupBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label2 = new Label();
            listMdp = new ListBox();
            LenPswd = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // ckMinus
            // 
            ckMinus.AutoSize = true;
            ckMinus.Location = new Point(11, 40);
            ckMinus.Name = "ckMinus";
            ckMinus.Size = new Size(124, 19);
            ckMinus.TabIndex = 0;
            ckMinus.Text = "Lettres Minuscules";
            ckMinus.UseVisualStyleBackColor = true;
            // 
            // ckMaj
            // 
            ckMaj.AutoSize = true;
            ckMaj.Location = new Point(12, 65);
            ckMaj.Name = "ckMaj";
            ckMaj.Size = new Size(123, 19);
            ckMaj.TabIndex = 1;
            ckMaj.Text = "Lettres Majuscules";
            ckMaj.UseVisualStyleBackColor = true;
            // 
            // ckChiffres
            // 
            ckChiffres.AutoSize = true;
            ckChiffres.Location = new Point(12, 90);
            ckChiffres.Name = "ckChiffres";
            ckChiffres.Size = new Size(102, 19);
            ckChiffres.TabIndex = 2;
            ckChiffres.Text = "Chiffres (0 à 9)";
            ckChiffres.UseVisualStyleBackColor = true;
            // 
            // ckSpec
            // 
            ckSpec.AutoSize = true;
            ckSpec.Location = new Point(12, 115);
            ckSpec.Name = "ckSpec";
            ckSpec.Size = new Size(125, 19);
            ckSpec.TabIndex = 3;
            ckSpec.Text = "Caractère spéciaux";
            ckSpec.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ckMinus);
            groupBox1.Controls.Add(ckSpec);
            groupBox1.Controls.Add(ckMaj);
            groupBox1.Controls.Add(ckChiffres);
            groupBox1.Location = new Point(35, 109);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(156, 150);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Choix des caractères";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 23);
            label1.Name = "label1";
            label1.Size = new Size(112, 15);
            label1.TabIndex = 5;
            label1.Text = "Longueur souhaitée";
            // 
            // button1
            // 
            button1.Location = new Point(225, 106);
            button1.Name = "button1";
            button1.Size = new Size(171, 47);
            button1.TabIndex = 6;
            button1.Text = "Générer un mot de passe";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(225, 162);
            button2.Name = "button2";
            button2.Size = new Size(171, 56);
            button2.TabIndex = 7;
            button2.Text = "Générer une liste de mots de passe";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(225, 236);
            button3.Name = "button3";
            button3.Size = new Size(171, 23);
            button3.TabIndex = 8;
            button3.Text = "Vider la liste";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(437, 51);
            label2.Name = "label2";
            label2.Size = new Size(103, 15);
            label2.TabIndex = 9;
            label2.Text = "Vos Mots de passe";
            // 
            // listMdp
            // 
            listMdp.FormattingEnabled = true;
            listMdp.ItemHeight = 15;
            listMdp.Location = new Point(437, 80);
            listMdp.Name = "listMdp";
            listMdp.Size = new Size(193, 184);
            listMdp.TabIndex = 10;
            listMdp.SelectedIndexChanged += listMdp_SelectedIndexChanged;
            // 
            // LenPswd
            // 
            LenPswd.Location = new Point(35, 51);
            LenPswd.Name = "LenPswd";
            LenPswd.Size = new Size(197, 23);
            LenPswd.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(649, 278);
            Controls.Add(LenPswd);
            Controls.Add(listMdp);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox ckMinus;
        private CheckBox ckMaj;
        private CheckBox ckChiffres;
        private CheckBox ckSpec;
        private GroupBox groupBox1;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label2;
        private ListBox listMdp;
        private TextBox LenPswd;
    }
}
