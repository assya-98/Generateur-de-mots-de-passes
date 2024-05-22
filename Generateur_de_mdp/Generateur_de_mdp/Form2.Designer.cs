namespace Generateur_de_mdp
{
    partial class Form2
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
            label1 = new Label();
            edNbPassword = new TextBox();
            btnValid = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 31);
            label1.Name = "label1";
            label1.Size = new Size(230, 15);
            label1.TabIndex = 0;
            label1.Text = "Combien de mots de passes voulez-vous ?";
            label1.Click += label1_Click;
            // 
            // edNbPassword
            // 
            edNbPassword.Location = new Point(41, 66);
            edNbPassword.Name = "edNbPassword";
            edNbPassword.Size = new Size(230, 23);
            edNbPassword.TabIndex = 1;
            // 
            // btnValid
            // 
            btnValid.Location = new Point(41, 104);
            btnValid.Name = "btnValid";
            btnValid.Size = new Size(230, 26);
            btnValid.TabIndex = 2;
            btnValid.Text = "Valider";
            btnValid.UseVisualStyleBackColor = true;
            btnValid.Click += btnValid_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 173);
            Controls.Add(btnValid);
            Controls.Add(edNbPassword);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox edNbPassword;
        private Button btnValid;
    }
}