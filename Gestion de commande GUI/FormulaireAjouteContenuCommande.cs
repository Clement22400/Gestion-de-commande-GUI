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
    public partial class FormulaireAjouteContenuCommande : Form
    {
        public FormulaireAjouteContenuCommande()
        {
            InitializeComponent();
            for (int i = 0; i < Form1.listProduitsShare.Items.Count; i++)
            {
                cbProduits.Items.Add(Form1.listProduitsShare.Items[i].SubItems[0].Text + " - " + Form1.listProduitsShare.Items[i].SubItems[1].Text + "€ - n°" + Form1.listProduitsShare.Items[i].SubItems[2].Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nombre = new Regex("^[0-9]*$");
            var mot = new Regex("^[a-zA-Zéèêëçàâôù ûïî]*$");

            cbProduits.BackColor = Color.White;
            inputQuantité.BackColor = Color.White;
            if (cbProduits.SelectedIndex == -1) cbProduits.BackColor = Color.Red;
            if (inputQuantité.Text == "") inputQuantité.BackColor = Color.Red;
            if (!nombre.Match(inputQuantité.Text).Success) inputQuantité.BackColor = Color.Red;

            if (cbProduits.SelectedIndex != -1 & inputQuantité.Text != "" & nombre.Match(inputQuantité.Text).Success)
            {
                string[] cbProduitSplit = cbProduits.SelectedItem.ToString().Replace(" ", "").Replace("€", "").Replace("n°", "").Split(char.Parse("-"));
                string[] items =
                {
                    cbProduitSplit[0],
                    cbProduitSplit[2],
                    inputQuantité.Text,
                    (int.Parse(inputQuantité.Text) * int.Parse(cbProduitSplit[1])).ToString(),
                };
                FormulaireCréationCommande.listContenuShare.Items.Add(new ListViewItem(items));
                cbProduits.SelectedItem = -1;
                inputQuantité.Clear();
                MessageBox.Show("Produit ajouté.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Erreur d'ajout du produit.");
            }
        }
    }
}
