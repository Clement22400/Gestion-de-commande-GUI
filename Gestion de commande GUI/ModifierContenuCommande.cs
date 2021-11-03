using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_commande_GUI
{
    public partial class ModifierContenuCommande : Form
    {
        public static ListView listContenuModifierShare;
        public ModifierContenuCommande(ListView listCommandes)
        {
            InitializeComponent();

            listContenu.View = View.Details;
            listContenu.GridLines = true;
            listContenu.FullRowSelect = true;
            listContenu.Columns.Add("Libellé", 100);
            listContenu.Columns.Add("Code Produit", 70);
            listContenu.Columns.Add("Quantité Commandée", 70);
            listContenu.Columns.Add("Prix Total", 70);
            ActualiserListContenu();
            inputCodeClient.Text = listCommandes.SelectedItems[0].SubItems[1].Text;
            switch (listCommandes.SelectedItems[0].SubItems[2].Text)
            {
                case "Oui":
                    statueCommande.Checked = true;
                    break;
                case "Non":
                    statueCommande.Checked = false;
                    break;
            }
            listContenuModifierShare = listContenu;
        }
        public void ActualiserListContenu()
        {
            string ligne = null;
            StreamReader fichierCommandesRead = null;
            listContenu.Items.Clear();
            try
            {
                fichierCommandesRead = new StreamReader(Form1.dirCommandes);
                ligne = fichierCommandesRead.ReadLine();

                while (ligne != null)
                {
                    string[] champ = ligne.Split(';');
                    string[] contenu = champ[3].Split(',');
                    for (int i = 0; i < contenu.Length; i++)
                    {
                        Produit x = Gestion.RechercherProduit(int.Parse(contenu[i].Split(':')[0]));
                        string[] tabItem =
                            {
                            x.GetLibelle(),
                            x.GetNo_Produit().ToString(),
                            contenu[i].Split(':')[1],
                            (int.Parse(contenu[i].Split(':')[1]) * x.GetPrix()).ToString(),
                            };
                        listContenu.Items.Add(new ListViewItem(tabItem));
                    }
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

        private void ajouterContenu_Click(object sender, EventArgs e)
        {
            FormulaireModifierContenuCommande f = new FormulaireModifierContenuCommande();
            f.ShowDialog();
        }

        private void supprimerContenu_Click(object sender, EventArgs e)
        {
            try
            {
                if (listContenu.SelectedItems.Count != 0)
                {
                    listContenu.SelectedItems[0].Remove();
                    MessageBox.Show("Suppression réussite.");
                }
                else
                {
                    MessageBox.Show("Erreur de suppression.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur de suppression.");
            }
        }

        private void Valider_Click(object sender, EventArgs e)
        {
            var nombre = new Regex("^[0-9]*$");
            var mot = new Regex("^[a-zA-Zéèêëçàâôù ûïî]*$");

            inputCodeClient.BackColor = Color.White;
            listContenu.BackColor = Color.White;

            if (inputCodeClient.Text == "") inputCodeClient.BackColor = Color.Red;
            if (listContenu.Items.Count <= 0) listContenu.BackColor = Color.Red;

            if (!nombre.Match(inputCodeClient.Text).Success) inputCodeClient.BackColor = Color.Red;
            bool clientExiste = true;
            for (int i = 0; i < Form1.listClientsShare.Items.Count; i++)
            {
                if (inputCodeClient.Text != Form1.listClientsShare.Items[i].SubItems[0].Text)
                {
                    inputCodeClient.BackColor = Color.Red;
                    clientExiste = false;
                }
                else
                {
                    inputCodeClient.BackColor = Color.White;
                    clientExiste = true;
                    break;
                }
            }
            if (clientExiste & inputCodeClient.Text != "" & listContenu.Items.Count > 0 & nombre.Match(inputCodeClient.Text).Success)
            {
                List<ContenuCommande> leContenu = new List<ContenuCommande>();
                double totalPrix = 0;
                for (int i = 0; i < listContenu.Items.Count; i++)
                {
                    var x = int.Parse(listContenu.Items[i].SubItems[3].Text) / int.Parse(listContenu.Items[i].SubItems[2].Text);
                    Produit p = new Produit(int.Parse(listContenu.Items[i].SubItems[1].Text), x, listContenu.Items[i].SubItems[0].Text);
                    ContenuCommande c = new ContenuCommande(p, int.Parse(listContenu.Items[i].SubItems[2].Text));
                    leContenu.Add(c);
                    totalPrix += int.Parse(listContenu.Items[i].SubItems[3].Text);
                }
                if (Gestion.SupprimerCommande(int.Parse(Form1.listCommandesShare.SelectedItems[0].SubItems[0].Text)) & Gestion.CréerCommande(int.Parse(Form1.listCommandesShare.SelectedItems[0].SubItems[0].Text), int.Parse(inputCodeClient.Text), statueCommande.Checked, leContenu))
                {
                    string[] items =
                    {
                        Form1.listCommandesShare.SelectedItems[0].SubItems[0].Text,
                        inputCodeClient.Text,
                        statueCommande.Checked ? "Oui" : "Non",
                        totalPrix.ToString() + "€"
                    };
                    Form1.listCommandesShare.SelectedItems[0].Remove();
                    Form1.listCommandesShare.Items.Add(new ListViewItem(items));
                    MessageBox.Show("La commande a été modifié.");
                    inputCodeClient.Clear();
                    listContenu.Clear();
                    statueCommande.Checked = false;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erreur de modification de la commande.");
                }
            }
            else
            {
                MessageBox.Show("Erreur de modification de la commande.");
            }
        }
    }
}
