﻿using System;
using System.Collections.Generic;
using System.IO;

namespace Quizz
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Saisissez votre Nom");
            string nom = Console.ReadLine();
            Console.WriteLine("Saisissez votre Prénom");
            string prenom = Console.ReadLine();

            Joueur joueur = new Joueur(nom, prenom);

            List<QCM> qcms = DAL.GetQCM();
            List<int> indicesErreurs = new List<int>();

            //instructions données au joueur
            Console.WriteLine("Bienvenue sur le Quizz! \nVeuillez saisir la/les lettre(s) correspondant à/aux réponse(s) en majuscule(s) et sans espaces (ex : AC). \n" +
                "Appuyez sur une touche pour commencer\n");
            Console.ReadLine();
            Console.Clear();

            //On initialise la variable 'compteur' de bonnes réponses à 0
            int compteur = 0;
            for (int i = 0; i < qcms.Count; i++)
            {
                //On affiche la question et ses propositions
                Console.WriteLine(qcms[i]);
                //on enregistre la chaine de caractères dans la variable réponse
                string reponse = "";
                bool repOK = false;
                while (!repOK)
                {
                    try
                    {
                        reponse = Console.ReadLine();
                        VerificationFormat(reponse);
                        repOK = true;

                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine(e.Message);

                    }
                }
                //si la réponse du joueur est correcte, on incrémente le compteur de 1
                if (reponse == qcms[i].BonneRéponse)
                {
                    compteur++;
                }
                else indicesErreurs.Add(i);
            }

            Console.WriteLine("Votre score est de {0} sur {1}", compteur, qcms.Count);
            joueur.Score = compteur;
            string repfaux = "";
            foreach (var item in indicesErreurs)
            {
                Console.WriteLine(qcms[item]);
                Console.WriteLine("La bonne réponse était " + qcms[item].BonneRéponse + '\n');
                repfaux += item + 1 + ",";
            }
            Console.Clear();

            bool continuer = true;
            Console.WriteLine("Souhaitez-vous voir vos statistiques? (O/N)");
            string repstat = Console.ReadLine();
            if (repstat == "o" || repstat == "O")
            {
                Console.WriteLine(joueur.Date.ToString() + " " + joueur.Nom + " " + joueur.Prenom + " " + joueur.Score + "/" + qcms.Count + " " + repfaux);
                Console.WriteLine();
                Console.WriteLine("Merci d'avoir joué \n Appuyez sur Q pour quitter l'application");
            }
            else
            {
                continuer = false;
                Console.WriteLine("Merci d'avoir joué \n Appuyez sur Q pour quitter l'application");
            }
            char touche = ' ';
            while (char.ToLower(touche) != 'q')
            {
                touche = Console.ReadKey().KeyChar;
            }
        }

        public static void VerificationFormat(string rep)
        {
            char valeur;
            for (int i = 0; i < rep.Length; i++)
            {
                valeur = rep[i];
                if (valeur > 64 && valeur < 91)
                {

                }

                else throw new FormatException("Le format de la réponse n'est pas valide, veuillez resaisir une réponse en lettres majuscules.");
            }
        }
    }
}
