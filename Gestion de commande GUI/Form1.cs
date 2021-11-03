using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;


namespace Gestion_de_commande_GUI
{
    public partial class Form1 : Form
    {
        public static Form1 instance;
        public static string dirProduits = "../../Données/Produits.csv";
        public static string dirCommandes = "../../Données/Commandes.csv";
        public static string dirClients = "../../Données/Clients.csv";
        public static ListView listProduitsShare;
        public static ListView listCommandesShare;
        public static ListView listClientsShare;

        public Form1()
        {
            InitializeComponent();
            instance = this;
            listProduits.View = View.Details;
            listProduits.GridLines = true;
            listProduits.FullRowSelect = true;
            listProduits.Columns.Add("Libellé", 100);
            listProduits.Columns.Add("Prix", 70);
            listProduits.Columns.Add("Code Produit", 100);
            listProduitsShare = listProduits;
            listCommandes.View = View.Details;
            listCommandes.GridLines = true;
            listCommandes.FullRowSelect = true;
            listCommandes.Columns.Add("N° Commande", 70);
            listCommandes.Columns.Add("Code Client", 100);
            listCommandes.Columns.Add("Validé", 100);
            listCommandes.Columns.Add("Total", 200);
            listCommandesShare = listCommandes;
            listClients.View = View.Details;
            listClients.GridLines = true;
            listClients.FullRowSelect = true;
            listClients.Columns.Add("Code Client", 70);
            listClients.Columns.Add("Prénom", 100);
            listClients.Columns.Add("Nom", 100);
            listClients.Columns.Add("Adresse", 200);
            listClients.Columns.Add("Ville", 100);
            listClients.Columns.Add("Code Postal", 100);
            listClientsShare = listClients;
        }
        private void CréerProduit_Click(object sender, EventArgs e)
        {
            FormulaireCréationProduit c = new FormulaireCréationProduit();
            c.ShowDialog();
        }
        private void supprimerList_Click(object sender, EventArgs e)
        {
             try
            {
                if (listProduits.SelectedItems.Count == 0) return;
                if (Gestion.SupprimerProduit(int.Parse(listProduits.SelectedItems[0].SubItems[2].Text)))
                {
                    listProduits.SelectedItems[0].Remove();
                    MessageBox.Show("Produit supprimé.");
                }
                else
                {
                    MessageBox.Show("Erreur de suppression.");
                        return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur de suppression.");
            }
        }
        private void supprimerListClients_Click(object sender, EventArgs e)
        {
            try
            {
                if (listClients.SelectedItems.Count == 0) return;
                if (Gestion.SupprimerClient(int.Parse(listClients.SelectedItems[0].SubItems[0].Text)))
                {
                    listClients.SelectedItems[0].Remove();
                    MessageBox.Show("Client supprimé.");
                }
                else
                {
                    MessageBox.Show("Erreur de suppression.");
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur de suppression.");
            }
        }
        public void ActualiserListProduits(object sender, EventArgs e)
        {
            string ligne = null;
            StreamReader fichierProduitRead = null;
            listProduits.Items.Clear();
            try
            {
                fichierProduitRead = new StreamReader(dirProduits);
                ligne = fichierProduitRead.ReadLine();
                while (ligne != null)
                {
                    var tabItem = new string[3];
                    string[] champ = ligne.Split(';');
                    Console.WriteLine(champ[0].ToString());
                    tabItem[0] = champ[2];
                    tabItem[1] = champ[1];
                    tabItem[2] = champ[0];
                    listProduits.Items.Add(new ListViewItem(tabItem));
                    ligne = fichierProduitRead.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                fichierProduitRead.Close();
            }
        }
        public void ActualiserListClients(object sender, EventArgs e)
        {
            string ligne = null;
            StreamReader fichierClientsRead = null;
            listClients.Items.Clear();
            try
            {
                fichierClientsRead = new StreamReader(dirClients);
                ligne = fichierClientsRead.ReadLine();
                while (ligne != null)
                {
                    var tabItem = new string[6];
                    string[] champ = ligne.Split(';');
                    Console.WriteLine(champ[0].ToString());
                    tabItem[0] = champ[0];
                    tabItem[1] = champ[2];
                    tabItem[2] = champ[1];
                    tabItem[3] = champ[3];
                    tabItem[4] = champ[4];
                    tabItem[5] = champ[5];
                    listClients.Items.Add(new ListViewItem(tabItem));
                    ligne = fichierClientsRead.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                fichierClientsRead.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ActualiserListProduits(sender, e);
            ActualiserListClients(sender, e);
            ActualiserListCommandes(sender, e);
        }

        private void afficheProduit_Click(object sender, EventArgs e)
        {
                if (affichageProduits.Checked)
                {
                    affichageProduits.Checked = false;
                    gpGestionProduits.Visible = false;
                } else
                {
                    affichageProduits.Checked = true;
                    gpGestionProduits.Visible = true;
                }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listProduits.SelectedItems.Count != 0)
            {
                supprimerList_Click(sender, e);
            }
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listProduits.SelectedItems.Count != 0)
            {
                ModifierProduits f = new ModifierProduits(listProduits);
                f.ShowDialog();
            }
        }

        private void affichageClients_Click(object sender, EventArgs e)
        {
            if (affichageClients.Checked)
            {
                affichageClients.Checked = false;
                gpClients.Visible = false;
            }
            else
            {
                affichageClients.Checked = true;
                gpClients.Visible = true;
            }
        }

        private void contextMenuStripProduits_Opening(object sender, CancelEventArgs e)
        {
            if (listProduits.SelectedItems.Count != 0)
            {
                supprimerToolStripMenuItem.Enabled = true;
                modifierToolStripMenuItem.Enabled = true;
            } else
            {
                supprimerToolStripMenuItem.Enabled = false;
                modifierToolStripMenuItem.Enabled = false;
            }
        }

        private void créerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormulaireCréationClient f = new FormulaireCréationClient();
            f.ShowDialog();
        }

        private void contexteMenuStripClient_Opening(object sender, CancelEventArgs e)
        {
            if (listClients.SelectedItems.Count != 0)
            {
                supprimerContexteMenuStripClient.Enabled = true;
                modifierContexteMenuStripClient.Enabled = true;
            }
            else
            {
                supprimerContexteMenuStripClient.Enabled = false;
                modifierContexteMenuStripClient.Enabled = false;
            }

        }

        private void supprimerContexteMenuStripClient_Click(object sender, EventArgs e)
        {
            if (listClients.SelectedItems.Count != 0)
            {
                supprimerListClients_Click(sender, e);
            }
        }

        private void modifierContexteMenuStripClient_Click(object sender, EventArgs e)
        {
            if (listClients.SelectedItems.Count != 0)
            {
                ModifierClients f = new ModifierClients(listClients);
                f.ShowDialog();
            }
        }

        private void contexteMenuStripCommandes_Opening(object sender, CancelEventArgs e)
        {
            if (listCommandes.SelectedItems.Count != 0)
            {
                supprimerContexteMenuStripCommandes.Enabled = true;
                modifierContexteMenuStripCommandes.Enabled = true;
            }
            else
            {
                supprimerContexteMenuStripCommandes.Enabled = false;
                modifierContexteMenuStripCommandes.Enabled = false;
            }

        }

        private void supprimerContexteMenuStripCommandes_Click(object sender, EventArgs e)
        {
            if (listCommandes.SelectedItems.Count != 0)
            {
                supprimerListCommandes_Click(sender, e);
            }
        }

        private void supprimerListCommandes_Click(object sender, EventArgs e)
        {
            try
            {
                if (listCommandes.SelectedItems.Count == 0) return;
                if (Gestion.SupprimerCommande(int.Parse(listCommandes.SelectedItems[0].SubItems[0].Text)))
                {
                    listCommandes.SelectedItems[0].Remove();
                    MessageBox.Show("Commande supprimé.");
                }
                else
                {
                    MessageBox.Show("Erreur de suppression.");
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur de suppression.");
            }
        }

        private void modifierContexteMenuStripCommandes_Click(object sender, EventArgs e)
        {
            if (listCommandes.SelectedItems.Count != 0)
            {
                ModifierContenuCommande f = new ModifierContenuCommande(listCommandes);
                f.ShowDialog();
            }
        }

        private void ajouterCommandeToolStrip_Click(object sender, EventArgs e)
        {
            FormulaireCréationCommande f = new FormulaireCréationCommande();
            f.ShowDialog();
        }
        public void ActualiserListCommandes(object sender, EventArgs e)
        {
            string ligne = null;
            StreamReader fichierCommandesRead = null;
            listCommandes.Items.Clear();
            try
            {
                fichierCommandesRead = new StreamReader(dirCommandes);
                ligne = fichierCommandesRead.ReadLine();
                
                while (ligne != null)
                {
                    string[] champ = ligne.Split(';');
                    string[] contenu = champ[3].Split(',');
                    int total = 0;

                    for (int i = 0; i < contenu.Length - 1; i++)
                    {
                        total += Gestion.RechercherProduit(int.Parse(contenu[i].Split(':')[0])).GetPrix() * int.Parse(contenu[i].Split(':')[1]);
                    }
                    string[] tabItem = 
                    {
                        champ[0],
                        champ[1],
                        bool.Parse(champ[2]) ? "Oui" : "Non",
                        total.ToString() + "€"
                    };
                    listCommandes.Items.Add(new ListViewItem(tabItem));
                    ligne = fichierCommandesRead.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                fichierCommandesRead.Close();
            }
        }

        private void supprimerList_Click(object sender, MouseEventArgs e)
        {

        }

        private void commandesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
                if (commandesToolStripMenuItem1.Checked)
                {
                    commandesToolStripMenuItem1.Checked = false;
                    gpCommandes.Visible = false;
                }
                else
                {
                    commandesToolStripMenuItem1.Checked = true;
                    gpCommandes.Visible = true;
                }
        }
    }
}
