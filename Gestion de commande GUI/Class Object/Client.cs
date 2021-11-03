using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_de_commande_GUI
{
    public class Client
    {
        private string nom, prenom, adresse, ville;
        private int codePostal, no_client;
        public Client(int no_client, string nom, string prenom, string adresse, string ville, int codePostal)
        {
            this.no_client = no_client;
            this.nom = nom;
            this.prenom = prenom;
            this.adresse = adresse;
            this.ville = ville;
            this.codePostal = codePostal;
        }
        public string GetNom()
        {
            return this.nom;
        }
        public string GetPrenom()
        {
            return this.prenom;
        }
        public string GetAdresse()
        {
            return this.adresse;
        }
        public string GetVille()
        {
            return this.ville;
        }
        public int GetCodePostal()
        {
            return this.codePostal;
        }
        public int GetNo_Client()
        {
            return this.no_client;
        }
        public override string ToString()
        {
            return string.Format("Code : {5}\tNom : {0}\tPrénom : {1}\nAdresse : {2}, {4} {3}", this.nom, this.prenom, this.adresse, this.ville, this.codePostal, this.no_client);
        }

    }
}
