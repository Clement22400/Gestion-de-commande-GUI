
namespace Gestion_de_commande_GUI
{
    partial class ModifierContenuCommande
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
            this.Valider = new System.Windows.Forms.Button();
            this.listContenu = new System.Windows.Forms.ListView();
            this.statueCommande = new System.Windows.Forms.CheckBox();
            this.inputCodeClient = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.supprimerContenu = new System.Windows.Forms.Button();
            this.ajouterContenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Valider
            // 
            this.Valider.Location = new System.Drawing.Point(223, 131);
            this.Valider.Name = "Valider";
            this.Valider.Size = new System.Drawing.Size(75, 23);
            this.Valider.TabIndex = 15;
            this.Valider.Text = "Valider";
            this.Valider.UseVisualStyleBackColor = true;
            this.Valider.Click += new System.EventHandler(this.Valider_Click);
            // 
            // listContenu
            // 
            this.listContenu.HideSelection = false;
            this.listContenu.Location = new System.Drawing.Point(223, 12);
            this.listContenu.Name = "listContenu";
            this.listContenu.Size = new System.Drawing.Size(233, 93);
            this.listContenu.TabIndex = 14;
            this.listContenu.UseCompatibleStateImageBehavior = false;
            // 
            // statueCommande
            // 
            this.statueCommande.AutoSize = true;
            this.statueCommande.Location = new System.Drawing.Point(72, 88);
            this.statueCommande.Name = "statueCommande";
            this.statueCommande.Size = new System.Drawing.Size(57, 17);
            this.statueCommande.TabIndex = 13;
            this.statueCommande.Text = "Statue";
            this.statueCommande.UseVisualStyleBackColor = true;
            // 
            // inputCodeClient
            // 
            this.inputCodeClient.Location = new System.Drawing.Point(85, 31);
            this.inputCodeClient.Name = "inputCodeClient";
            this.inputCodeClient.Size = new System.Drawing.Size(100, 20);
            this.inputCodeClient.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Code Client";
            // 
            // supprimerContenu
            // 
            this.supprimerContenu.BackgroundImage = global::Gestion_de_commande_GUI.Properties.Resources.croix;
            this.supprimerContenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.supprimerContenu.Location = new System.Drawing.Point(472, 66);
            this.supprimerContenu.Name = "supprimerContenu";
            this.supprimerContenu.Size = new System.Drawing.Size(40, 39);
            this.supprimerContenu.TabIndex = 17;
            this.supprimerContenu.UseVisualStyleBackColor = true;
            this.supprimerContenu.Click += new System.EventHandler(this.supprimerContenu_Click);
            // 
            // ajouterContenu
            // 
            this.ajouterContenu.BackgroundImage = global::Gestion_de_commande_GUI.Properties.Resources.plus;
            this.ajouterContenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ajouterContenu.Location = new System.Drawing.Point(472, 12);
            this.ajouterContenu.Name = "ajouterContenu";
            this.ajouterContenu.Size = new System.Drawing.Size(40, 39);
            this.ajouterContenu.TabIndex = 16;
            this.ajouterContenu.UseVisualStyleBackColor = true;
            this.ajouterContenu.Click += new System.EventHandler(this.ajouterContenu_Click);
            // 
            // ModifierContenuCommande
            // 
            this.AcceptButton = this.Valider;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 167);
            this.Controls.Add(this.supprimerContenu);
            this.Controls.Add(this.ajouterContenu);
            this.Controls.Add(this.Valider);
            this.Controls.Add(this.listContenu);
            this.Controls.Add(this.statueCommande);
            this.Controls.Add(this.inputCodeClient);
            this.Controls.Add(this.label2);
            this.Name = "ModifierContenuCommande";
            this.Text = "ModifierContenuCommande";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button supprimerContenu;
        private System.Windows.Forms.Button ajouterContenu;
        private System.Windows.Forms.Button Valider;
        private System.Windows.Forms.ListView listContenu;
        private System.Windows.Forms.CheckBox statueCommande;
        private System.Windows.Forms.TextBox inputCodeClient;
        private System.Windows.Forms.Label label2;
    }
}