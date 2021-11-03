using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace Gestion_de_commande_GUI
{
    public partial class FormulaireCréationProduit : Form
    {
        public static FormulaireCréationProduit instance;
        public FormulaireCréationProduit()
        {
            instance = this;
            InitializeComponent();
        }
        private void Valider_Click(object sender, EventArgs e)
        {
            var nombre = new Regex("^[0-9]*$");
            var mot = new Regex("^[a-zA-Zéèêëçàâôù ûïî]*$");

            inputLibelle.BackColor = Color.White;
            inputCodeProduit.BackColor = Color.White;
            inputPrix.BackColor = Color.White;

            if (inputLibelle.Text == "") inputLibelle.BackColor = Color.Red;
            if (inputCodeProduit.Text == "") inputCodeProduit.BackColor = Color.Red;
            if (inputPrix.Text == "") inputPrix.BackColor = Color.Red;
            if (!nombre.Match(inputPrix.Text).Success) inputPrix.BackColor = Color.Red;
            if (!nombre.Match(inputCodeProduit.Text).Success) inputCodeProduit.BackColor = Color.Red;
            bool produitExiste = false;
            for (int i = 0; i < Form1.listProduitsShare.Items.Count; i++)
            {
                if (Form1.listProduitsShare.Items[i].SubItems[2].Text == inputCodeProduit.Text)
                {
                    inputCodeProduit.BackColor = Color.Red;
                    produitExiste = true;
                }
            }
            if (!produitExiste & inputLibelle.Text != "" & inputCodeProduit.Text != "" & inputPrix.Text != "" & nombre.Match(inputPrix.Text).Success & nombre.Match(inputCodeProduit.Text).Success)
            {

                if (Gestion.CréerProduit(int.Parse(inputCodeProduit.Text), int.Parse(inputPrix.Text), inputLibelle.Text))
                {
                    var tabItem = new string[3];
                    tabItem[0] = inputLibelle.Text;
                    tabItem[1] = inputPrix.Text;
                    tabItem[2] = inputCodeProduit.Text;
                    Form1.listProduitsShare.Items.Add(new ListViewItem(tabItem));
                    MessageBox.Show("Votre produit a été créé.");
                    inputLibelle.Clear();
                    inputPrix.Clear();
                    inputCodeProduit.Clear();
                }
                else
                {
                    MessageBox.Show("Erreur de création de votre produit.");
                }
            } else
            {
                MessageBox.Show("Erreur de création de votre produit.");
            }
        }

        private void FormulaireCréationProduit_Load(object sender, EventArgs e)
        {

        }
    }
}
