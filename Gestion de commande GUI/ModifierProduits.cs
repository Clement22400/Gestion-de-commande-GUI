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
    public partial class ModifierProduits : Form
    {
        public static ModifierProduits instance;
        public string cp;
        public ModifierProduits(ListView listProduits)
        {
            instance = this;
            InitializeComponent();
            inputLibelle.Text = listProduits.SelectedItems[0].SubItems[0].Text;
            inputPrix.Text = listProduits.SelectedItems[0].SubItems[1].Text;
            cp = listProduits.SelectedItems[0].SubItems[2].Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var nombre = new Regex("^[0-9]*$");
            var mot = new Regex("^[a-zA-Zéèêëçàâôù ûïî]*$");

            inputLibelle.BackColor = Color.White;
            inputPrix.BackColor = Color.White;

            if (inputLibelle.Text == "") inputLibelle.BackColor = Color.Red;
            if (inputPrix.Text == "") inputPrix.BackColor = Color.Red;
            if (!nombre.Match(inputPrix.Text).Success) inputPrix.BackColor = Color.Red;

            if (inputLibelle.Text != "" & inputPrix.Text != "" & nombre.Match(inputPrix.Text).Success) 
            { 
                if (Gestion.SetPrixProduit(int.Parse(cp), int.Parse(inputPrix.Text)) & Gestion.SetLibelleProduit(int.Parse(cp), inputLibelle.Text))
                {
                    Form1.listProduitsShare.SelectedItems[0].SubItems[1].Text = inputPrix.Text;
                    Form1.listProduitsShare.SelectedItems[0].SubItems[0].Text = inputLibelle.Text;
                    this.Close();
                } else
                {
                    MessageBox.Show("Erreur de modification de votre produit.");
                }
            } else
            {
                MessageBox.Show("Erreur de modification de votre produit.");
            }
        }

        private void ModifierProduits_Load(object sender, EventArgs e)
        {

        }
    }
}
