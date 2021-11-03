using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_de_commande_GUI
{
    // no_produit, quantité
    public class ContenuCommande
    {
        private int quantitéCommandé;
        private Produit produit;
        
        public ContenuCommande(Produit produit, int quantité)
        {
            this.produit = produit;
            this.quantitéCommandé = quantité;
        }
        public Produit GetProduit()
        {
            return this.produit;
        }
        public bool SetProduit(Produit produit)
        {
            try
            {
                this.produit = produit;
            } catch (Exception e)
            {
                Console.WriteLine("Erreur : " + e.ToString());
                return false;
            }
            return true;
        }
        public int GetQuantité()
        {
            return this.quantitéCommandé;
        }
        public bool SetQuantité(int quantitéCommandé)
        {
            try
            {
                this.quantitéCommandé = quantitéCommandé;
            } catch (Exception e)
            {
                Console.WriteLine("Erreur : " + e.ToString());
                return false;
            }
            return true;
        }

        public override string ToString()
        {
            return this.produit + ":" + this.quantitéCommandé + ":" + (this.produit.GetPrix() * this.quantitéCommandé);
        }
    }
}