using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_commande_GUI
{
    public partial class FormulaireCréationCommande : Form
    {
        public static ListView listContenuShare;
        public FormulaireCréationCommande()
        {
            InitializeComponent();
            listContenu.View = View.Details;
            listContenu.GridLines = true;
            listContenu.FullRowSelect = true;
            listContenu.Columns.Add("Libellé", 100);
            listContenu.Columns.Add("Code Produit", 70);
            listContenu.Columns.Add("Quantité Commandée", 70);
            listContenu.Columns.Add("Prix Total", 70);
            listContenuShare = listContenu;
        }

        private void ajouterContenu_Click(object sender, EventArgs e)
        {
            FormulaireAjouteContenuCommande f = new FormulaireAjouteContenuCommande();
            f.ShowDialog();
        }

        private void supprimerList_Click(object sender, EventArgs e)
        {
            try
            {
                if (listContenu.SelectedItems.Count != 0)
                {
                    listContenu.SelectedItems[0].Remove();
                    MessageBox.Show("Suppression réussite.");
                } else
                {
                    MessageBox.Show("Erreur de suppression.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur de suppression.");
            }
        }

        private void supprimerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (listContenu.SelectedItems.Count != 0)
            {
                supprimerList_Click(sender, e);
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (listContenu.SelectedItems.Count != 0)
            {
                supprimerToolStripMenuItem.Enabled = true;
            }
            else
            {
                supprimerToolStripMenuItem.Enabled = false;
            }
        }

        private void Valider_Click(object sender, EventArgs e)
        {
            var nombre = new Regex("^[0-9]*$");
            var mot = new Regex("^[a-zA-Zéèêëçàâôù ûïî]*$");

            inputCodeClient.BackColor = Color.White;
            inputNoCommande.BackColor = Color.White;
            listContenu.BackColor = Color.White;

            if (inputCodeClient.Text == "") inputCodeClient.BackColor = Color.Red;
            if (inputNoCommande.Text == "") inputNoCommande.BackColor = Color.Red;
            if (listContenu.Items.Count <= 0) listContenu.BackColor = Color.Red;

            if (!nombre.Match(inputCodeClient.Text).Success) inputCodeClient.BackColor = Color.Red;
            if (!nombre.Match(inputNoCommande.Text).Success) inputNoCommande.BackColor = Color.Red;
            bool clientExiste = true;
            bool commandeExiste = false;
            for (int i = 0; i < Form1.listCommandesShare.Items.Count; i++)
            {
                if (Form1.listCommandesShare.Items[i].SubItems[0].Text == inputNoCommande.Text)
                {
                    inputNoCommande.BackColor = Color.Red;
                    commandeExiste = true;
                    break;
                }
            }
            for (int i = 0; i < Form1.listClientsShare.Items.Count; i++)
            {
                if (inputCodeClient.Text != Form1.listClientsShare.Items[i].SubItems[0].Text)
                {
                    inputCodeClient.BackColor = Color.Red;
                    clientExiste = false;
                } else
                {
                    inputCodeClient.BackColor = Color.White;
                    clientExiste = true;
                    break;
                }
            }
            if (clientExiste & !commandeExiste & inputCodeClient.Text != "" & inputNoCommande.Text != "" & listContenu.Items.Count > 0 & nombre.Match(inputCodeClient.Text).Success & nombre.Match(inputNoCommande.Text).Success)
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
                if (Gestion.CréerCommande(int.Parse(inputNoCommande.Text), int.Parse(inputCodeClient.Text), statueCommande.Checked, leContenu))
                {
                    string[] items =
                    {
                        inputNoCommande.Text,
                        inputCodeClient.Text,
                        statueCommande.Checked ? "Oui" : "Non",
                        totalPrix.ToString() + "€"
                    };
                    Form1.listCommandesShare.Items.Add(new ListViewItem(items));
                    MessageBox.Show("La commande a été ajouté.");
                    inputCodeClient.Clear();
                    inputNoCommande.Clear();
                    listContenu.Clear();
                    statueCommande.Checked = false;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erreur d'ajout de la commande.");
                }
            }
            else
            {
                MessageBox.Show("Erreur d'ajout de la commande.");
            }
        }
    }
}
