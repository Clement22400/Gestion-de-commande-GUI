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
    public partial class FormulaireCréationClient : Form
    {
        public FormulaireCréationClient()
        {
            InitializeComponent();
        }

        private void FormulaireCréationClient_Load(object sender, EventArgs e)
        {

        }

        private void Valider_Click(object sender, EventArgs e)
        {
            var nombre = new Regex("^[0-9]*$");
            var mot = new Regex("^[a-zA-Zéèêëçàâôù ûïî]*$");

            inputNomClient.BackColor = Color.White;
            inputPrenomClient.BackColor = Color.White;
            inputAdresse.BackColor = Color.White;
            inputCodePostale.BackColor = Color.White;
            inputVille.BackColor = Color.White;
            inputCodeClient.BackColor = Color.White;

            if (inputNomClient.Text == "") inputNomClient.BackColor = Color.Red;
            if (inputPrenomClient.Text == "") inputPrenomClient.BackColor = Color.Red;
            if (inputAdresse.Text == "") inputAdresse.BackColor = Color.Red;
            if (inputCodePostale.Text == "") inputCodePostale.BackColor = Color.Red;
            if (inputVille.Text == "") inputVille.BackColor = Color.Red;
            if (inputCodeClient.Text == "") inputCodeClient.BackColor = Color.Red;

            if (!nombre.Match(inputCodeClient.Text).Success) inputCodeClient.BackColor = Color.Red;
            if (!nombre.Match(inputCodePostale.Text).Success) inputCodePostale.BackColor = Color.Red;

            for (int i = 0; i < Form1.listClientsShare.Items.Count; i++)
            {
                if (Form1.listProduitsShare.Items[i].SubItems[2].Text == inputCodeClient.Text)
                {
                    inputCodeClient.BackColor = Color.Red;
                }
            }
            if (inputNomClient.Text != "" & inputPrenomClient.Text != "" & inputAdresse.Text != "" & inputCodePostale.Text != "" & inputVille.Text != "" & inputCodeClient.Text != "" & nombre.Match(inputCodeClient.Text).Success & nombre.Match(inputCodePostale.Text).Success)
            {

                if (Gestion.CréerClient(int.Parse(inputCodeClient.Text), inputNomClient.Text, inputPrenomClient.Text, inputAdresse.Text, inputVille.Text, int.Parse(inputCodePostale.Text)))
                {
                    var tabItem = new string[6];
                    tabItem[0] = inputCodeClient.Text;
                    tabItem[1] = inputPrenomClient.Text;
                    tabItem[2] = inputNomClient.Text;
                    tabItem[3] = inputAdresse.Text;
                    tabItem[4] = inputVille.Text;
                    tabItem[5] = inputCodePostale.Text;
                    Form1.listClientsShare.Items.Add(new ListViewItem(tabItem));
                    MessageBox.Show("Le client a été créé.");
                    inputCodeClient.Clear();
                    inputNomClient.Clear();
                    inputPrenomClient.Clear();
                    inputAdresse.Clear();
                    inputVille.Clear();
                    inputCodePostale.Clear();
                }
                else
                {
                    MessageBox.Show("Erreur de création du client.");
                }
            }
            else
            {
                MessageBox.Show("Erreur de création du client.");
            }
        }
    }
}
