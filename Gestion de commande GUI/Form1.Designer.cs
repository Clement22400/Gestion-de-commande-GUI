
namespace Gestion_de_commande_GUI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gpGestionProduits = new System.Windows.Forms.GroupBox();
            this.listProduits = new System.Windows.Forms.ListView();
            this.contextMenuStripProduits = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.affichageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.affichageProduits = new System.Windows.Forms.ToolStripMenuItem();
            this.affichageClients = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.commandesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterCommandeToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.créerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gpCommandes = new System.Windows.Forms.GroupBox();
            this.listCommandes = new System.Windows.Forms.ListView();
            this.contextMenuStripCommandes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.supprimerContexteMenuStripCommandes = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierContexteMenuStripCommandes = new System.Windows.Forms.ToolStripMenuItem();
            this.listClients = new System.Windows.Forms.ListView();
            this.contexteMenuStripClient = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.supprimerContexteMenuStripClient = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierContexteMenuStripClient = new System.Windows.Forms.ToolStripMenuItem();
            this.gpClients = new System.Windows.Forms.GroupBox();
            this.supprimerList = new System.Windows.Forms.Button();
            this.ajouterList = new System.Windows.Forms.Button();
            this.refreshList = new System.Windows.Forms.Button();
            this.commandesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gpGestionProduits.SuspendLayout();
            this.contextMenuStripProduits.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.gpCommandes.SuspendLayout();
            this.contextMenuStripCommandes.SuspendLayout();
            this.contexteMenuStripClient.SuspendLayout();
            this.gpClients.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpGestionProduits
            // 
            this.gpGestionProduits.Controls.Add(this.supprimerList);
            this.gpGestionProduits.Controls.Add(this.ajouterList);
            this.gpGestionProduits.Controls.Add(this.listProduits);
            this.gpGestionProduits.Controls.Add(this.refreshList);
            this.gpGestionProduits.Location = new System.Drawing.Point(29, 47);
            this.gpGestionProduits.Name = "gpGestionProduits";
            this.gpGestionProduits.Size = new System.Drawing.Size(330, 280);
            this.gpGestionProduits.TabIndex = 11;
            this.gpGestionProduits.TabStop = false;
            this.gpGestionProduits.Text = "Gestion Produits";
            // 
            // listProduits
            // 
            this.listProduits.ContextMenuStrip = this.contextMenuStripProduits;
            this.listProduits.HideSelection = false;
            this.listProduits.Location = new System.Drawing.Point(21, 27);
            this.listProduits.Name = "listProduits";
            this.listProduits.Size = new System.Drawing.Size(279, 174);
            this.listProduits.TabIndex = 7;
            this.listProduits.UseCompatibleStateImageBehavior = false;
            // 
            // contextMenuStripProduits
            // 
            this.contextMenuStripProduits.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supprimerToolStripMenuItem,
            this.modifierToolStripMenuItem});
            this.contextMenuStripProduits.Name = "contextMenuStrip1";
            this.contextMenuStripProduits.Size = new System.Drawing.Size(130, 48);
            this.contextMenuStripProduits.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripProduits_Opening);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.modifierToolStripMenuItem.Text = "Modifier";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.affichageToolStripMenuItem,
            this.toolStripMenuItem1,
            this.commandesToolStripMenuItem,
            this.clientsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1038, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // affichageToolStripMenuItem
            // 
            this.affichageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.affichageProduits,
            this.affichageClients,
            this.commandesToolStripMenuItem1});
            this.affichageToolStripMenuItem.Name = "affichageToolStripMenuItem";
            this.affichageToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.affichageToolStripMenuItem.Text = "Affichage";
            // 
            // affichageProduits
            // 
            this.affichageProduits.Checked = true;
            this.affichageProduits.CheckState = System.Windows.Forms.CheckState.Checked;
            this.affichageProduits.Name = "affichageProduits";
            this.affichageProduits.Size = new System.Drawing.Size(180, 22);
            this.affichageProduits.Text = "Produits";
            this.affichageProduits.Click += new System.EventHandler(this.afficheProduit_Click);
            // 
            // affichageClients
            // 
            this.affichageClients.Checked = true;
            this.affichageClients.CheckState = System.Windows.Forms.CheckState.Checked;
            this.affichageClients.Name = "affichageClients";
            this.affichageClients.Size = new System.Drawing.Size(180, 22);
            this.affichageClients.Text = "Clients";
            this.affichageClients.Click += new System.EventHandler(this.affichageClients_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // commandesToolStripMenuItem
            // 
            this.commandesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterCommandeToolStrip});
            this.commandesToolStripMenuItem.Name = "commandesToolStripMenuItem";
            this.commandesToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.commandesToolStripMenuItem.Text = "Commandes";
            // 
            // ajouterCommandeToolStrip
            // 
            this.ajouterCommandeToolStrip.Name = "ajouterCommandeToolStrip";
            this.ajouterCommandeToolStrip.Size = new System.Drawing.Size(113, 22);
            this.ajouterCommandeToolStrip.Text = "Ajouter";
            this.ajouterCommandeToolStrip.Click += new System.EventHandler(this.ajouterCommandeToolStrip_Click);
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.créerToolStripMenuItem});
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.clientsToolStripMenuItem.Text = "Clients";
            // 
            // créerToolStripMenuItem
            // 
            this.créerToolStripMenuItem.Name = "créerToolStripMenuItem";
            this.créerToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.créerToolStripMenuItem.Text = "Créer";
            this.créerToolStripMenuItem.Click += new System.EventHandler(this.créerToolStripMenuItem_Click);
            // 
            // gpCommandes
            // 
            this.gpCommandes.Controls.Add(this.listCommandes);
            this.gpCommandes.Location = new System.Drawing.Point(29, 356);
            this.gpCommandes.Name = "gpCommandes";
            this.gpCommandes.Size = new System.Drawing.Size(614, 259);
            this.gpCommandes.TabIndex = 13;
            this.gpCommandes.TabStop = false;
            this.gpCommandes.Text = "Commandes";
            this.gpCommandes.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // listCommandes
            // 
            this.listCommandes.ContextMenuStrip = this.contextMenuStripCommandes;
            this.listCommandes.HideSelection = false;
            this.listCommandes.Location = new System.Drawing.Point(21, 27);
            this.listCommandes.Name = "listCommandes";
            this.listCommandes.Size = new System.Drawing.Size(572, 213);
            this.listCommandes.TabIndex = 14;
            this.listCommandes.UseCompatibleStateImageBehavior = false;
            // 
            // contextMenuStripCommandes
            // 
            this.contextMenuStripCommandes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supprimerContexteMenuStripCommandes,
            this.modifierContexteMenuStripCommandes});
            this.contextMenuStripCommandes.Name = "contextMenuStrip1";
            this.contextMenuStripCommandes.Size = new System.Drawing.Size(130, 48);
            this.contextMenuStripCommandes.Opening += new System.ComponentModel.CancelEventHandler(this.contexteMenuStripCommandes_Opening);
            // 
            // supprimerContexteMenuStripCommandes
            // 
            this.supprimerContexteMenuStripCommandes.Name = "supprimerContexteMenuStripCommandes";
            this.supprimerContexteMenuStripCommandes.Size = new System.Drawing.Size(129, 22);
            this.supprimerContexteMenuStripCommandes.Text = "Supprimer";
            this.supprimerContexteMenuStripCommandes.Click += new System.EventHandler(this.supprimerContexteMenuStripCommandes_Click);
            // 
            // modifierContexteMenuStripCommandes
            // 
            this.modifierContexteMenuStripCommandes.Name = "modifierContexteMenuStripCommandes";
            this.modifierContexteMenuStripCommandes.Size = new System.Drawing.Size(129, 22);
            this.modifierContexteMenuStripCommandes.Text = "Modifier";
            this.modifierContexteMenuStripCommandes.Click += new System.EventHandler(this.modifierContexteMenuStripCommandes_Click);
            // 
            // listClients
            // 
            this.listClients.ContextMenuStrip = this.contexteMenuStripClient;
            this.listClients.FullRowSelect = true;
            this.listClients.GridLines = true;
            this.listClients.HideSelection = false;
            this.listClients.Location = new System.Drawing.Point(21, 27);
            this.listClients.Name = "listClients";
            this.listClients.Size = new System.Drawing.Size(536, 174);
            this.listClients.TabIndex = 15;
            this.listClients.UseCompatibleStateImageBehavior = false;
            // 
            // contexteMenuStripClient
            // 
            this.contexteMenuStripClient.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supprimerContexteMenuStripClient,
            this.modifierContexteMenuStripClient});
            this.contexteMenuStripClient.Name = "contextMenuStrip1";
            this.contexteMenuStripClient.Size = new System.Drawing.Size(130, 48);
            this.contexteMenuStripClient.Opening += new System.ComponentModel.CancelEventHandler(this.contexteMenuStripClient_Opening);
            // 
            // supprimerContexteMenuStripClient
            // 
            this.supprimerContexteMenuStripClient.Name = "supprimerContexteMenuStripClient";
            this.supprimerContexteMenuStripClient.Size = new System.Drawing.Size(129, 22);
            this.supprimerContexteMenuStripClient.Text = "Supprimer";
            this.supprimerContexteMenuStripClient.Click += new System.EventHandler(this.supprimerContexteMenuStripClient_Click);
            // 
            // modifierContexteMenuStripClient
            // 
            this.modifierContexteMenuStripClient.Name = "modifierContexteMenuStripClient";
            this.modifierContexteMenuStripClient.Size = new System.Drawing.Size(129, 22);
            this.modifierContexteMenuStripClient.Text = "Modifier";
            this.modifierContexteMenuStripClient.Click += new System.EventHandler(this.modifierContexteMenuStripClient_Click);
            // 
            // gpClients
            // 
            this.gpClients.Controls.Add(this.listClients);
            this.gpClients.Location = new System.Drawing.Point(411, 47);
            this.gpClients.Name = "gpClients";
            this.gpClients.Size = new System.Drawing.Size(582, 227);
            this.gpClients.TabIndex = 16;
            this.gpClients.TabStop = false;
            this.gpClients.Text = "Clients";
            // 
            // supprimerList
            // 
            this.supprimerList.BackgroundImage = global::Gestion_de_commande_GUI.Properties.Resources.croix;
            this.supprimerList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.supprimerList.Location = new System.Drawing.Point(261, 207);
            this.supprimerList.Name = "supprimerList";
            this.supprimerList.Size = new System.Drawing.Size(39, 39);
            this.supprimerList.TabIndex = 10;
            this.supprimerList.UseVisualStyleBackColor = true;
            this.supprimerList.Click += new System.EventHandler(this.supprimerList_Click);
            this.supprimerList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.supprimerList_Click);
            // 
            // ajouterList
            // 
            this.ajouterList.BackgroundImage = global::Gestion_de_commande_GUI.Properties.Resources.plus;
            this.ajouterList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ajouterList.Location = new System.Drawing.Point(216, 207);
            this.ajouterList.Name = "ajouterList";
            this.ajouterList.Size = new System.Drawing.Size(39, 39);
            this.ajouterList.TabIndex = 9;
            this.ajouterList.UseVisualStyleBackColor = true;
            this.ajouterList.Click += new System.EventHandler(this.CréerProduit_Click);
            // 
            // refreshList
            // 
            this.refreshList.BackgroundImage = global::Gestion_de_commande_GUI.Properties.Resources.reload;
            this.refreshList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.refreshList.Location = new System.Drawing.Point(21, 207);
            this.refreshList.Name = "refreshList";
            this.refreshList.Size = new System.Drawing.Size(39, 39);
            this.refreshList.TabIndex = 8;
            this.refreshList.UseVisualStyleBackColor = true;
            this.refreshList.Click += new System.EventHandler(this.ActualiserListProduits);
            // 
            // commandesToolStripMenuItem1
            // 
            this.commandesToolStripMenuItem1.Checked = true;
            this.commandesToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.commandesToolStripMenuItem1.Name = "commandesToolStripMenuItem1";
            this.commandesToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.commandesToolStripMenuItem1.Text = "Commandes";
            this.commandesToolStripMenuItem1.Click += new System.EventHandler(this.commandesToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScrollMargin = new System.Drawing.Size(20, 20);
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1038, 649);
            this.Controls.Add(this.gpClients);
            this.Controls.Add(this.gpCommandes);
            this.Controls.Add(this.gpGestionProduits);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.ActualiserListProduits);
            this.gpGestionProduits.ResumeLayout(false);
            this.contextMenuStripProduits.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gpCommandes.ResumeLayout(false);
            this.contextMenuStripCommandes.ResumeLayout(false);
            this.contexteMenuStripClient.ResumeLayout(false);
            this.gpClients.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button supprimerList;
        public System.Windows.Forms.GroupBox gpGestionProduits;
        private System.Windows.Forms.Button ajouterList;
        public System.Windows.Forms.ListView listProduits;
        private System.Windows.Forms.Button refreshList;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem affichageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem affichageProduits;
        private System.Windows.Forms.ToolStripMenuItem commandesToolStripMenuItem;
        private System.Windows.Forms.GroupBox gpCommandes;
        private System.Windows.Forms.ListView listCommandes;
        private System.Windows.Forms.ListView listClients;
        private System.Windows.Forms.GroupBox gpClients;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripProduits;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem affichageClients;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem créerToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contexteMenuStripClient;
        private System.Windows.Forms.ToolStripMenuItem supprimerContexteMenuStripClient;
        private System.Windows.Forms.ToolStripMenuItem modifierContexteMenuStripClient;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ajouterCommandeToolStrip;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripCommandes;
        private System.Windows.Forms.ToolStripMenuItem supprimerContexteMenuStripCommandes;
        private System.Windows.Forms.ToolStripMenuItem modifierContexteMenuStripCommandes;
        private System.Windows.Forms.ToolStripMenuItem commandesToolStripMenuItem1;
    }
}

