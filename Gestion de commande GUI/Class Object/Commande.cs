using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_de_commande_GUI
{
    // no_commande, no_client, ContenuCommande, statut(true = validé)
    public class Commande
    {
        private int no_commande;
        private bool statue;
        private List<ContenuCommande> content;
        private Client client;

        public Commande(int no_commande, Client client, bool statue, List<ContenuCommande> content)
        {
            this.no_commande = no_commande;
            this.client = client;
            this.statue = statue;
            this.content = content;
        }

        public int GetNo_Commande()
        {
            return this.no_commande;
        }
        public Client GetClient()
        {
            return this.client;
        }
        public bool GetStatue()
        {
            return this.statue;
        }
        public List<ContenuCommande> GetContenu()
        {
            return this.content;
        }
        public override string ToString()
        {
            string x = string.Empty;
            for (int i = 0; i < content.Count; i++)
            {
                x = x + content[i];
            }
            return string.Format("N°commande : {0}\nN°client : {1}\nValidé : {2}\nList Contenu : \n{3}", this.no_commande, this.client, this.statue, x);
        }
    }
}
