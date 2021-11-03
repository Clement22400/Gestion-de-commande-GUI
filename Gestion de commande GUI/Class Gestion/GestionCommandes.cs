using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Gestion_de_commande_GUI
{
    public partial class Gestion
    {
        const string dirCommandes = "../../Données/Commandes.csv";
        public static bool CréerCommande(int no_commande, int no_client, bool statue, List<ContenuCommande> content)
        {
            string contenuFichierCommandes = null;
            string ligne = null;
            StreamReader fichierCommandesRead = null;
            try
            {
                fichierCommandesRead = new StreamReader(dirCommandes);
                ligne = fichierCommandesRead.ReadLine();
                while (ligne != null)
                {
                    if (ligne.Split(char.Parse(";"))[0] == no_commande.ToString()) return false;
                    contenuFichierCommandes = contenuFichierCommandes + ligne + "\n";
                    ligne = fichierCommandesRead.ReadLine();
                } 
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
            finally
            {
                fichierCommandesRead.Close();
            }
            StreamWriter fichierCommandessWrite = null;
            try
            {
                fichierCommandessWrite = new StreamWriter(dirCommandes);
                fichierCommandessWrite.Write(contenuFichierCommandes);
                string list = null;
                for (int i = 0; i < content.Count; i++)
                {
                    list = list + content[i].GetProduit().GetNo_Produit().ToString() + ":" + content[i].GetQuantité().ToString() + ",";
                }
                fichierCommandessWrite.WriteLine($"{no_commande};{no_client};{statue};{list};");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
            finally
            {
                fichierCommandessWrite.Close();
            }

            return true;
        }
        public static Commande RechercherCommande(int no_commande)
        {
            string ligne = null;
            StreamReader fichierCommandesRead = null;
            try
            {
                fichierCommandesRead = new StreamReader(dirCommandes);
                ligne = fichierCommandesRead.ReadLine();
                while (ligne != null)
                {
                    string[] champ = ligne.Split(char.Parse(";"));
                    if (champ[0] == no_commande.ToString())
                    {
                        string[] champContent = champ[3].Split(char.Parse(";"));
                        List<ContenuCommande> c = new List<ContenuCommande>();
                        for (int i = 0; i < champContent.Length - 1; i++)
                        {
                            ContenuCommande content = new ContenuCommande(RechercherProduit(int.Parse(champContent[i].Split(char.Parse(";"))[0])), int.Parse(champContent[i].Split(char.Parse(":"))[1]));
                            c.Add(content);
                        }
                        return new Commande(int.Parse(champ[0]), RechercherClient(int.Parse(champ[1])), bool.Parse(champ[2]), c);
                    }
                    ligne = fichierCommandesRead.ReadLine();
                } 
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                fichierCommandesRead.Close();
            }
            return null;
        }
        public static bool SupprimerCommande(int no_commande)
        {
            bool trouve = false;
            string contenuFichierCommandes = null;
            string ligne = null;
            StreamReader fichierCommandesRead = null;
            try
            {
                fichierCommandesRead = new StreamReader(dirCommandes);
                ligne = fichierCommandesRead.ReadLine();
                while (ligne != null)
                {
                    if (ligne.Split(char.Parse(";"))[0] != no_commande.ToString())
                    {
                        contenuFichierCommandes = contenuFichierCommandes + ligne + "\n";
                    }
                    else
                    {
                        trouve = true;
                    }
                    ligne = fichierCommandesRead.ReadLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
            finally
            {
                fichierCommandesRead.Close();
            }
            StreamWriter fichierCommandesWrite = null;
            try
            {
                fichierCommandesWrite = new StreamWriter(dirCommandes);
                fichierCommandesWrite.Write(contenuFichierCommandes);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
            finally
            {
                fichierCommandesWrite.Close();
            }
            return trouve;
        }
        public static bool SupprimerToutesLesCommandes()
        {
            StreamWriter fichierCommandessWrite = null;
            try
            {
                fichierCommandessWrite = new StreamWriter(dirCommandes);
                fichierCommandessWrite.Write("");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
            finally
            {
                fichierCommandessWrite.Close();
            }
            return true;
        }
        public static bool SetStatueCommande(int no_commande, bool statue)
        {
            bool trouve = false;
            string contenuFichierCommandes = null;
            string ligne = null;
            StreamReader fichierCommandesRead = null;
            try
            {
                fichierCommandesRead = new StreamReader(dirCommandes);
                ligne = fichierCommandesRead.ReadLine();
                while (ligne != null) 
                {
                    string[] champ = ligne.Split(char.Parse(";"));
                    if (champ[0] == no_commande.ToString())
                    {
                        champ[2] = statue.ToString();
                        trouve = true;
                        ligne = null;
                        for (int i = 0; i < champ.Length - 1; i++)
                        {
                            ligne = ligne + champ[i] + ";";
                        }
                    }
                    contenuFichierCommandes = contenuFichierCommandes + ligne + "\n";
                    ligne = fichierCommandesRead.ReadLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
            finally
            {
                fichierCommandesRead.Close();
            }
            StreamWriter fichierCommandesWrite = null;
            try
            {
                fichierCommandesWrite = new StreamWriter(dirCommandes);
                fichierCommandesWrite.Write(contenuFichierCommandes);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
            finally
            {
                fichierCommandesWrite.Close();
            }
            return trouve;
        }
        public static bool SetClientCommande(int no_commande, int no_client)
        {
            bool trouve = false;
            string contenuFichierCommandes = null;
            string ligne = null;
            StreamReader fichierCommandesRead = null;
            try
            {
                fichierCommandesRead = new StreamReader(dirCommandes);
                ligne = fichierCommandesRead.ReadLine();
                while (ligne != null)
                {
                    string[] champ = ligne.Split(char.Parse(";"));
                    if (champ[0] == no_commande.ToString())
                    {
                        champ[1] = no_client.ToString();
                        trouve = true;
                        ligne = null;
                        for (int i = 0; i < champ.Length - 1; i++)
                        {
                            ligne = ligne + champ[i] + ";";
                        }
                    }
                    contenuFichierCommandes = contenuFichierCommandes + ligne + "\n";
                    ligne = fichierCommandesRead.ReadLine();
                } 
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
            finally
            {
                fichierCommandesRead.Close();
            }
            StreamWriter fichierCommandesWrite = null;
            try
            {
                fichierCommandesWrite = new StreamWriter(dirCommandes);
                fichierCommandesWrite.Write(contenuFichierCommandes);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
            finally
            {
                fichierCommandesWrite.Close();
            }
            return trouve;
        }
        public static bool SupprimerContenuCommande(int no_commande, int no_produit)
        {
            bool trouve = false;
            string contenuFichierCommandes = null;
            string ligne = null;
            StreamReader fichierCommandesRead = null;
            try
            {
                fichierCommandesRead = new StreamReader(dirCommandes);
                ligne = fichierCommandesRead.ReadLine();
                while (ligne != null)
                {
                    string[] champ = ligne.Split(char.Parse(";"));
                    if (champ[0] == no_commande.ToString())
                    {
                        ligne = null;

                        for (int i = 0; i < champ.Length - 1; i++)
                        {
                            if (i == 3)
                            {
                                string[] champContent = champ[i].Split(char.Parse(","));
                                for (int y = 0; y < champContent.Length - 1; y++)
                                {
                                    string[] champContentContent = champContent[y].Split(char.Parse(":")) ;
                                    if (champContentContent[0] != no_produit.ToString())
                                    {
                                        ligne = ligne + champContent[y] + ",";
                                    }
                                }
                                ligne = ligne + ";";
                            } else { 
                            ligne = ligne + champ[i] + ";";
                            }
                        }
                        trouve = true;
                    }
                    contenuFichierCommandes = contenuFichierCommandes + ligne + "\n";
                    ligne = fichierCommandesRead.ReadLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
            finally
            {
                fichierCommandesRead.Close();
            }
            StreamWriter fichierCommandesWrite = null;
            try
            {
                fichierCommandesWrite = new StreamWriter(dirCommandes);
                fichierCommandesWrite.Write(contenuFichierCommandes);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
            finally
            {
                fichierCommandesWrite.Close();
            }
            return trouve;
        }
        public static bool AjouterContenuCommande(int no_commande, int no_produit, int quantité)
        {
            bool trouve = false;
            string contenuFichierCommandes = null;
            string ligne = null;
            StreamReader fichierCommandesRead = null;
            try
            {
                fichierCommandesRead = new StreamReader(dirCommandes);
                ligne = fichierCommandesRead.ReadLine();
                while (ligne != null)
                {
                    string[] champ = ligne.Split(char.Parse(";"));
                    if (champ[0] == no_commande.ToString())
                    {
                        ligne = null;
                        for (int i = 0; i < champ.Length - 1; i++)
                        {
                            if (i == 3)
                            {
                                string[] champContent = champ[i].Split(char.Parse(";"));
                                for (int y = 0; y < champContent.Length - 1; y++)
                                {

                                    string[] champContentContent = champContent[y].Split(char.Parse(":"));
                                    if (champContentContent[0] != no_produit.ToString())
                                    {
                                        ligne = ligne + champContent[y] + ",";
                                    }
                                }
                                ligne = ligne + no_produit.ToString() + ":" + quantité.ToString() + ",;";
                            } else 
                            { 
                            ligne = ligne + champ[i] + ";";
                            }
                        }
                        trouve = true;
                    }
                    contenuFichierCommandes = contenuFichierCommandes + ligne + "\n";
                    ligne = fichierCommandesRead.ReadLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
            finally
            {
                fichierCommandesRead.Close();
            }
            StreamWriter fichierCommandesWrite = null;
            try
            {
                fichierCommandesWrite = new StreamWriter(dirCommandes);
                fichierCommandesWrite.Write(contenuFichierCommandes);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
            finally
            {
                fichierCommandesWrite.Close();
            }
            return trouve;
        }
        public static bool ModifierContenuCommande(int no_commande, int no_produit, int quantité)
        {
            bool trouve = false;
            string contenuFichierCommandes = null;
            string ligne = null;
            StreamReader fichierCommandesRead = null;
            try
            {
                fichierCommandesRead = new StreamReader(dirCommandes);
                ligne = fichierCommandesRead.ReadLine();
                while (ligne != null)
                {
                    string[] champ = ligne.Split(char.Parse(";"));
                    if (champ[0] == no_commande.ToString())
                    {
                        ligne = null;
                        for (int i = 0; i < champ.Length - 1; i++)
                        {
                            if (i == 3)
                            {
                                string[] champContent = champ[i].Split(char.Parse(","));
                                for (int y = 0; y < champContent.Length - 1; y++)
                                {

                                    string[] champContentContent = champContent[y].Split(char.Parse(":"));
                                        if (champContentContent[0] == no_produit.ToString())
                                        {
                                            ligne = ligne + no_produit.ToString() + ":" + quantité.ToString() + ",";
                                        }
                                        else
                                        {
                                            ligne = ligne + champContent[y] + ",";
                                        }
                                }
                                ligne = ligne + ";";
                            }
                            else
                            {
                                ligne = ligne + champ[i] + ";";
                            }
                        }
                        trouve = true;
                    }
                    contenuFichierCommandes = contenuFichierCommandes + ligne + "\n";
                    ligne = fichierCommandesRead.ReadLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
            finally
            {
                fichierCommandesRead.Close();
            }
            StreamWriter fichierCommandesWrite = null;
            try
            {
                fichierCommandesWrite = new StreamWriter(dirCommandes);
                fichierCommandesWrite.Write(contenuFichierCommandes);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
            finally
            {
                fichierCommandesWrite.Close();
            }
            return trouve;
        }
    }
}
