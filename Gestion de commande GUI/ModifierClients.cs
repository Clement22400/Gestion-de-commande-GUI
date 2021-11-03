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
    public partial class ModifierClients : Form
    {
        private int codeclient;
        public ModifierClients(ListView listClients)
        {
            InitializeComponent();
            codeclient = int.Parse(listClients.SelectedItems[0].SubItems[0].Text);
            inputPrenomClient.Text = listClients.SelectedItems[0].SubItems[1].Text;
            inputNomClient.Text = listClients.SelectedItems[0].SubItems[2].Text;
            inputAdresse.Text = listClients.SelectedItems[0].SubItems[3].Text;
            inputVille.Text = listClients.SelectedItems[0].SubItems[4].Text;
            inputCodePostale.Text = listClients.SelectedItems[0].SubItems[5].Text;
        }

        private void ModifierClients_Load(object sender, EventArgs e)
        {

        }

        private void Valider_Click(object sender, EventArgs e)
        {
            {
                var nombre = new Regex("^[0-9]*$");
                var mot = new Regex("^[a-zA-Zéèêëçàâôù ûïî]*$");

                inputNomClient.BackColor = Color.White;
                inputPrenomClient.BackColor = Color.White;
                inputAdresse.BackColor = Color.White;
                inputCodePostale.BackColor = Color.White;
                inputVille.BackColor = Color.White;

                if (inputNomClient.Text == "") inputNomClient.BackColor = Color.Red;
                if (inputPrenomClient.Text == "") inputPrenomClient.BackColor = Color.Red;
                if (inputAdresse.Text == "") inputAdresse.BackColor = Color.Red;
                if (inputCodePostale.Text == "") inputCodePostale.BackColor = Color.Red;
                if (inputVille.Text == "") inputVille.BackColor = Color.Red;

                if (!nombre.Match(inputCodePostale.Text).Success) inputCodePostale.BackColor = Color.Red;

                if (inputNomClient.Text != "" & inputPrenomClient.Text != "" & inputAdresse.Text != "" & inputCodePostale.Text != "" & inputVille.Text != "" & nombre.Match(inputCodePostale.Text).Success)
                {

                    if (Gestion.SetNomClient(codeclient, inputNomClient.Text) & Gestion.SetPrenomClient(codeclient, inputPrenomClient.Text) & Gestion.SetAdresseClient(codeclient, inputAdresse.Text) & Gestion.SetVilleClient(codeclient, inputVille.Text) & Gestion.SetCodePostalClient(codeclient, int.Parse(inputCodePostale.Text)))
                    {
                        MessageBox.Show("Le client a été modifié.");
                        Form1.listClientsShare.SelectedItems[0].SubItems[0].Text = codeclient.ToString();
                        Form1.listClientsShare.SelectedItems[0].SubItems[1].Text = inputPrenomClient.Text;
                        Form1.listClientsShare.SelectedItems[0].SubItems[2].Text = inputNomClient.Text;
                        Form1.listClientsShare.SelectedItems[0].SubItems[3].Text = inputAdresse.Text;
                        Form1.listClientsShare.SelectedItems[0].SubItems[4].Text = inputVille.Text;
                        Form1.listClientsShare.SelectedItems[0].SubItems[5].Text = inputCodePostale.Text;
                        this.Close();
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
}
