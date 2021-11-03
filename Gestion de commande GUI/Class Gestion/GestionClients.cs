using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Gestion_de_commande_GUI
{
    public partial class Gestion
    {
        const string dirClients = "../../Données/Clients.csv";
        public static bool CréerClient(int no_client, string nom, string prenom, string adresse, string ville, int codePostal)
        {
            string contenuFichierClient = null;
            string ligne = null;
            StreamReader fichierClientRead = null;
            try
            {

                fichierClientRead = new StreamReader(dirClients);
                ligne = fichierClientRead.ReadLine();
                while (ligne != null) 
                {
                    if (ligne.Split(char.Parse(";"))[0] == no_client.ToString()) return false;
                    contenuFichierClient = contenuFichierClient + ligne + "\n";
                    ligne = fichierClientRead.ReadLine();
                } 
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
            finally
            {
                fichierClientRead.Close();
            }
            StreamWriter fichierClientsWrite = null;
            try
            {
                fichierClientsWrite = new StreamWriter(dirClients);
                fichierClientsWrite.Write(contenuFichierClient);
                fichierClientsWrite.WriteLine($"{no_client};{nom};{prenom};{adresse};{ville};{codePostal};");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
            finally
            {
                fichierClientsWrite.Close();
            }

            return true;
        }
        public static Client RechercherClient(int no_client)
        {
            string ligne = null;
            StreamReader fichierClientRead = null;
            try
            {
                fichierClientRead = new StreamReader(dirClients);
                ligne = fichierClientRead.ReadLine();
                while (ligne != null)
                {
                    string[] champ = ligne.Split(char.Parse(";"));
                    if (champ[0] == no_client.ToString())
                    {
                        return new Client(int.Parse(champ[0]), champ[1], champ[2], champ[3], champ[4], int.Parse(champ[5]));
                    }
                    ligne = fichierClientRead.ReadLine();
                } 
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                fichierClientRead.Close();
            }
            return null;
        }
        public static bool SupprimerClient(int no_client)
        {
            bool trouve = false;
            string contenuFichierClients = null;
            string ligne = null;
            StreamReader fichierClientsRead = null;
            try
            {
                fichierClientsRead = new StreamReader(dirClients);
                ligne = fichierClientsRead.ReadLine();
                while (ligne != null)
                {
                    if (ligne.Split(char.Parse(";"))[0] != no_client.ToString())
                    {
                        contenuFichierClients = contenuFichierClients + ligne + "\n";
                    }
                    else
                    {
                        trouve = true;
                    }
                    ligne = fichierClientsRead.ReadLine();
                } 
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
            finally
            {
                fichierClientsRead.Close();
            }
            StreamWriter fichierClientsWrite = null;
            try
            {
                fichierClientsWrite = new StreamWriter(dirClients);
                fichierClientsWrite.Write(contenuFichierClients);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
            finally
            {
                fichierClientsWrite.Close();
            }
            return trouve;
        }
        public static bool SupprimerTousLesClients()
        {
            StreamWriter fichierClientsWrite = null;
            try
            {
                fichierClientsWrite = new StreamWriter(dirClients);
                fichierClientsWrite.Write("");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
            finally
            {
                fichierClientsWrite.Close();
            }
            return true;
        }
        public static bool SetNomClient(int no_client, string nom)
        {
            bool trouve = false;
            string contenuFichierClients = null;
            string ligne = null;
            StreamReader fichierClientsRead = null;
            try
            {
                fichierClientsRead = new StreamReader(dirClients);
                ligne = fichierClientsRead.ReadLine();
                while (ligne != null)
                {
                    string[] champ = ligne.Split(char.Parse(";"));
                    if (champ[0] == no_client.ToString())
                    {
                        champ[1] = nom;
                        trouve = true;
                        ligne = null;
                        for (int i = 0; i < champ.Length - 1; i++)
                        {
                            ligne = ligne + champ[i] + ";";
                        }
                    }
                    contenuFichierClients = contenuFichierClients + ligne + "\n";
                    ligne = fichierClientsRead.ReadLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
            finally
            {
                fichierClientsRead.Close();
            }
            StreamWriter fichierClientsWrite = null;
            try
            {
                fichierClientsWrite = new StreamWriter(dirClients);
                fichierClientsWrite.Write(contenuFichierClients);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
            finally
            {
                fichierClientsWrite.Close();
            }
            return trouve;
        }
        public static bool SetPrenomClient(int no_client, string prenom)
        {
            bool trouve = false;
            string contenuFichierClients = null;
            string ligne = null;
            StreamReader fichierClientsRead = null;
            try
            {
                fichierClientsRead = new StreamReader(dirClients);
                ligne = fichierClientsRead.ReadLine();
                while (ligne != null)
                {
                    string[] champ = ligne.Split(char.Parse(";"));
                    if (champ[0] == no_client.ToString())
                    {
                        champ[2] = prenom;
                        trouve = true;
                        ligne = null;
                        for (int i = 0; i < champ.Length - 1; i++)
                        {
                            ligne = ligne + champ[i] + ";";
                        }
                    }
                    contenuFichierClients = contenuFichierClients + ligne + "\n";
                    ligne = fichierClientsRead.ReadLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
            finally
            {
                fichierClientsRead.Close();
            }
            StreamWriter fichierClientsWrite = null;
            try
            {
                fichierClientsWrite = new StreamWriter(dirClients);
                fichierClientsWrite.Write(contenuFichierClients);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
            finally
            {
                fichierClientsWrite.Close();
            }
            return trouve;
        }
        public static bool SetAdresseClient(int no_client, string adresse)
        {
            bool trouve = false;
            string contenuFichierClients = null;
            string ligne = null;
            StreamReader fichierClientsRead = null;
            try
            {
                fichierClientsRead = new StreamReader(dirClients);
                ligne = fichierClientsRead.ReadLine();
                while (ligne != null)
                {
                    string[] champ = ligne.Split(char.Parse(";"));
                    if (champ[0] == no_client.ToString())
                    {
                        champ[3] = adresse;
                        trouve = true;
                        ligne = null;
                        for (int i = 0; i < champ.Length - 1; i++)
                        {
                            ligne = ligne + champ[i] + ";";
                        }
                    }
                    contenuFichierClients = contenuFichierClients + ligne + "\n";
                    ligne = fichierClientsRead.ReadLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
            finally
            {
                fichierClientsRead.Close();
            }
            StreamWriter fichierClientsWrite = null;
            try
            {
                fichierClientsWrite = new StreamWriter(dirClients);
                fichierClientsWrite.Write(contenuFichierClients);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
            finally
            {
                fichierClientsWrite.Close();
            }
            return trouve;
        }
        public static bool SetVilleClient(int no_client, string ville)
        {
            bool trouve = false;
            string contenuFichierClients = null;
            string ligne = null;
            StreamReader fichierClientsRead = null;
            try
            {
                fichierClientsRead = new StreamReader(dirClients);
                ligne = fichierClientsRead.ReadLine();
                while (ligne != null)
                {
                    string[] champ = ligne.Split(char.Parse(";"));
                    if (champ[0] == no_client.ToString())
                    {
                        champ[4] = ville;
                        trouve = true;
                        ligne = null;
                        for (int i = 0; i < champ.Length - 1; i++)
                        {
                            ligne = ligne + champ[i] + ";";
                        }
                    }
                    contenuFichierClients = contenuFichierClients + ligne + "\n";
                    ligne = fichierClientsRead.ReadLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
            finally
            {
                fichierClientsRead.Close();
            }
            StreamWriter fichierClientsWrite = null;
            try
            {
                fichierClientsWrite = new StreamWriter(dirClients);
                fichierClientsWrite.Write(contenuFichierClients);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
            finally
            {
                fichierClientsWrite.Close();
            }
            return trouve;
        }
        public static bool SetCodePostalClient(int no_client, int codePostal)
        {
            bool trouve = false;
            string contenuFichierClients = null;
            string ligne = null;
            StreamReader fichierClientsRead = null;
            try
            {
                fichierClientsRead = new StreamReader(dirClients);
                ligne = fichierClientsRead.ReadLine();
                while (ligne != null)
                {
                    string[] champ = ligne.Split(char.Parse(";"));
                    if (champ[0] == no_client.ToString())
                    {
                        champ[5] = codePostal.ToString();
                        trouve = true;
                        ligne = null;
                        for (int i = 0; i < champ.Length - 1; i++)
                        {
                            ligne = ligne + champ[i] + ";";
                        }
                    }
                    contenuFichierClients = contenuFichierClients + ligne + "\n";
                    ligne = fichierClientsRead.ReadLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
            finally
            {
                fichierClientsRead.Close();
            }
            StreamWriter fichierClientsWrite = null;
            try
            {
                fichierClientsWrite = new StreamWriter(dirClients);
                fichierClientsWrite.Write(contenuFichierClients);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
            finally
            {
                fichierClientsWrite.Close();
            }
            return trouve;
        }
    }
}
