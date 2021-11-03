using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_de_commande_GUI
{
    // no_produit, libelle, prix
    public class Produit
    {
        private int no_produit, prix;
        private string libelle;

        public Produit(int no_produit, int prix, string libelle)
        {
            this.no_produit = no_produit;
            this.prix = prix;
            this.libelle = libelle;
        }

        public int GetNo_Produit()
        {
            return this.no_produit;
        }
        public int GetPrix()
        {
            return this.prix;
        }
        public string GetLibelle()
        {
            return this.libelle;
        }
        public override string ToString()
        {
            return string.Format("{0}:{1}:{2}", this.libelle, this.no_produit, this.prix);
        }

    }
}
