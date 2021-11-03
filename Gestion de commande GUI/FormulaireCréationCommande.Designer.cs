
namespace Gestion_de_commande_GUI
{
    partial class FormulaireCréationCommande
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.inputNoCommande = new System.Windows.Forms.TextBox();
            this.inputCodeClient = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.statueCommande = new System.Windows.Forms.CheckBox();
            this.listContenu = new System.Windows.Forms.ListView();
            this.Valider = new System.Windows.Forms.Button();
            this.supprimerContenu = new System.Windows.Forms.Button();
            this.ajouterContenu = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "N° Commande";
            // 
            // inputNoCommande
            // 
            this.inputNoCommande.Location = new System.Drawing.Point(103, 21);
            this.inputNoCommande.Name = "inputNoCommande";
            this.inputNoCommande.Size = new System.Drawing.Size(100, 20);
            this.inputNoCommande.TabIndex = 1;
            // 
            // inputCodeClient
            // 
            this.inputCodeClient.Location = new System.Drawing.Point(103, 61);
            this.inputCodeClient.Name = "inputCodeClient";
            this.inputCodeClient.Size = new System.Drawing.Size(100, 20);
            this.inputCodeClient.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Code Client";
            // 
            // statueCommande
            // 
            this.statueCommande.AutoSize = true;
            this.statueCommande.Location = new System.Drawing.Point(15, 97);
            this.statueCommande.Name = "statueCommande";
            this.statueCommande.Size = new System.Drawing.Size(57, 17);
            this.statueCommande.TabIndex = 4;
            this.statueCommande.Text = "Statue";
            this.statueCommande.UseVisualStyleBackColor = true;
            // 
            // listContenu
            // 
            this.listContenu.ContextMenuStrip = this.contextMenuStrip1;
            this.listContenu.HideSelection = false;
            this.listContenu.Location = new System.Drawing.Point(220, 21);
            this.listContenu.Name = "listContenu";
            this.listContenu.Size = new System.Drawing.Size(233, 93);
            this.listContenu.TabIndex = 5;
            this.listContenu.UseCompatibleStateImageBehavior = false;
            // 
            // Valider
            // 
            this.Valider.Location = new System.Drawing.Point(220, 140);
            this.Valider.Name = "Valider";
            this.Valider.Size = new System.Drawing.Size(75, 23);
            this.Valider.TabIndex = 6;
            this.Valider.Text = "Valider";
            this.Valider.UseVisualStyleBackColor = true;
            this.Valider.Click += new System.EventHandler(this.Valider_Click);
            // 
            // supprimerContenu
            // 
            this.supprimerContenu.BackgroundImage = global::Gestion_de_commande_GUI.Properties.Resources.croix;
            this.supprimerContenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.supprimerContenu.Location = new System.Drawing.Point(469, 75);
            this.supprimerContenu.Name = "supprimerContenu";
            this.supprimerContenu.Size = new System.Drawing.Size(40, 39);
            this.supprimerContenu.TabIndex = 8;
            this.supprimerContenu.UseVisualStyleBackColor = true;
            this.supprimerContenu.Click += new System.EventHandler(this.supprimerList_Click);
            // 
            // ajouterContenu
            // 
            this.ajouterContenu.BackgroundImage = global::Gestion_de_commande_GUI.Properties.Resources.plus;
            this.ajouterContenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ajouterContenu.Location = new System.Drawing.Point(469, 21);
            this.ajouterContenu.Name = "ajouterContenu";
            this.ajouterContenu.Size = new System.Drawing.Size(40, 39);
            this.ajouterContenu.TabIndex = 7;
            this.ajouterContenu.UseVisualStyleBackColor = true;
            this.ajouterContenu.Click += new System.EventHandler(this.ajouterContenu_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supprimerToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(130, 26);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click_1);
            // 
            // FormulaireCréationCommande
            // 
            this.AcceptButton = this.Valider;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 188);
            this.Controls.Add(this.supprimerContenu);
            this.Controls.Add(this.ajouterContenu);
            this.Controls.Add(this.Valider);
            this.Controls.Add(this.listContenu);
            this.Controls.Add(this.statueCommande);
            this.Controls.Add(this.inputCodeClient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputNoCommande);
            this.Controls.Add(this.label1);
            this.Name = "FormulaireCréationCommande";
            this.Text = "FormulaireCréationCommande";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputNoCommande;
        private System.Windows.Forms.TextBox inputCodeClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox statueCommande;
        private System.Windows.Forms.ListView listContenu;
        private System.Windows.Forms.Button Valider;
        private System.Windows.Forms.Button ajouterContenu;
        private System.Windows.Forms.Button supprimerContenu;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
    }
}