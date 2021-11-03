using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Gestion_de_commande_GUI
{
    public partial class Gestion
    {
        const string dirProduit = "../../Données/Produits.csv";
        public static bool CréerProduit(int no_produit, int prix, string libelle)
        {

            string contenuFichierProduit = null;
            string  ligne = null;
            StreamReader fichierProduitRead = null;
            try {
                fichierProduitRead = new StreamReader(dirProduit);
                ligne = fichierProduitRead.ReadLine();
                while (ligne != null)
                {
                    if (ligne.Split(char.Parse(";"))[0] == no_produit.ToString()) return false;
                    contenuFichierProduit = contenuFichierProduit + ligne + "\n";
                    ligne = fichierProduitRead.ReadLine();
                }
                } catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            } finally
            {
                fichierProduitRead.Close();
            }
            StreamWriter fichierProduitsWrite = null;
            try {
                fichierProduitsWrite = new StreamWriter(dirProduit);
                fichierProduitsWrite.Write(contenuFichierProduit);
                fichierProduitsWrite.WriteLine($"{no_produit};{prix};{libelle};");

            } catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            } finally
            {
                fichierProduitsWrite.Close();
            }
            
            return true;
        }

        public static Produit RechercherProduit(int no_produit)
        {
            string ligne = null;
            StreamReader fichierProduitRead = null;
            try
            {
                fichierProduitRead = new StreamReader(dirProduit);
                ligne = fichierProduitRead.ReadLine();
                while (ligne != null)
                {
                    string[] champ = ligne.Split(char.Parse(";"));
                    if (champ[0] == no_produit.ToString())
                    {
                        return new Produit(int.Parse(champ[0]), int.Parse(champ[1]), champ[2]);
                    }
                    ligne = fichierProduitRead.ReadLine();
                }
            } catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            } finally
            {
                fichierProduitRead.Close();
            }
            return null;
        }
        
        public static bool SupprimerProduit(int no_produit)
        {
            bool trouve = false;
            string contenuFichierProduit = null;
            string ligne = null;
            StreamReader fichierProduitRead = null;
            try
            {
                fichierProduitRead = new StreamReader(dirProduit);
                ligne = fichierProduitRead.ReadLine();
                while (ligne != null)
                {
                    if (ligne.Split(char.Parse(";"))[0] != no_produit.ToString())
                    {
                        contenuFichierProduit = contenuFichierProduit + ligne + "\n";
                    } else
                    {
                        trouve = true;
                    }
                    ligne = fichierProduitRead.ReadLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
            finally
            {
                fichierProduitRead.Close();
            }
            StreamWriter fichierProduitsWrite = null;
            try
            {
                fichierProduitsWrite = new StreamWriter(dirProduit);
                fichierProduitsWrite.Write(contenuFichierProduit);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
            finally
            {
                fichierProduitsWrite.Close();
            }
            return trouve;
        }
        public static bool SupprimerTousLesProduits()
        {
            StreamWriter fichierProduitsWrite = null;
            try
            {
                fichierProduitsWrite = new StreamWriter(dirProduit);
                fichierProduitsWrite.Write("");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
            finally
            {
                fichierProduitsWrite.Close();
            }
            return true;
        }
        public static bool SetPrixProduit(int no_produit, int prix)
        {
            bool trouve = false;
            string contenuFichierProduit = null;
            string ligne = null;
            StreamReader fichierProduitRead = null;
            try
            {
                fichierProduitRead = new StreamReader(dirProduit);
                ligne = fichierProduitRead.ReadLine();
                while (ligne != null)
                {
                    string[] champ = ligne.Split(char.Parse(";"));
                    if (champ[0] == no_produit.ToString())
                    {
                        champ[1] = prix.ToString();
                        trouve = true;
                        ligne = null;
                        for (int i = 0; i < champ.Length - 1; i++)
                        {
                            ligne = ligne + champ[i] + ";";
                        }
                    }
                    contenuFichierProduit = contenuFichierProduit + ligne + "\n";
                    ligne = fichierProduitRead.ReadLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
            finally
            {
                fichierProduitRead.Close();
            }
            StreamWriter fichierProduitsWrite = null;
            try
            {
                fichierProduitsWrite = new StreamWriter(dirProduit);
                fichierProduitsWrite.Write(contenuFichierProduit);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
            finally
            {
                fichierProduitsWrite.Close();
            }
            return trouve;
        }
        public static bool SetLibelleProduit(int no_produit, string libelle)
        {
            bool trouve = false;
            string contenuFichierProduit = null;
            string ligne = null;
            StreamReader fichierProduitRead = null;
            try
            {
                fichierProduitRead = new StreamReader(dirProduit);
                ligne = fichierProduitRead.ReadLine();
                while (ligne != null)
                {
                    string[] champ = ligne.Split(char.Parse(";"));
                    if (champ[0] == no_produit.ToString())
                    {
                        champ[2] = libelle;
                        trouve = true;
                        ligne = null;
                        for (int i = 0; i < champ.Length - 1; i++)
                        {
                            ligne = ligne + champ[i] + ";";
                        }
                    }
                    contenuFichierProduit = contenuFichierProduit + ligne + "\n";
                    ligne = fichierProduitRead.ReadLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
            finally
            {
                fichierProduitRead.Close();
            }
            StreamWriter fichierProduitsWrite = null;
            try
            {
                fichierProduitsWrite = new StreamWriter(dirProduit);
                fichierProduitsWrite.Write(contenuFichierProduit);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
            finally
            {
                fichierProduitsWrite.Close();
            }
            return trouve;
        }
    }
}
