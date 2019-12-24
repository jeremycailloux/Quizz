using System;
using System.Collections.Generic;
using System.IO;

namespace Quizz
{
    class Program
    {
        static void Main()
        {
            //L'utilisateur saisi son Nom et son Prenom
            Console.WriteLine("Saisissez votre Nom");
            string nom = Console.ReadLine();
            Console.WriteLine("Saisissez votre Prénom");
            string prenom = Console.ReadLine();

            //Déclaration de l'objet joueur
            Joueur joueur = new Joueur(nom, prenom);

           //Creation des listes qcms et indicesErreurs
           // indicesErreurs collecte les indices correspondant aux questions et propositions fausses données par l'utilisateur    
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
                        // Application de la méthode VerificationFormat pour vérifier que les réponses sont au format démandé (MAJ, sans espaces)
                        //le paramètre réponse correspond à la réponse tappée par le joueur
                        VerificationFormat(reponse);
                        repOK = true;

                    } //on attrape l'exception de format et on affiche le message d'érreur au joueur qui demande une réponse valide
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
                //si la réponse est fause on enregistre la valeur de l'indice de la mauvaise réponse dans la liste indicesErreurs
                else indicesErreurs.Add(i);
            }
            Console.WriteLine("Votre score est de {0} sur {1}", compteur, qcms.Count);
            joueur.Score = compteur;
            string repfaux = "";
            foreach (var item in indicesErreurs)
            { //la variable repfaux permet de concaténer les valeurs des numéros des questions pour lesquelles les réponses sont fausses
              // Celles-ci sont obtenues en récupérant les indices dans indicesErreurs incrémentés de 1 (car les indices commencent à 0 et les questions à 1)
                Console.WriteLine(qcms[item]);
                Console.WriteLine("La bonne réponse était " + qcms[item].BonneRéponse + '\n');
                repfaux += item + 1 + ",";
            }
            Console.Clear();
            bool continuer = true;
            Console.WriteLine("Souhaitez-vous voir vos statistiques? (O/N)");
            string repstat = Console.ReadLine();
            if (repstat == "o" || repstat == "O")
            {  //On affiche les données du joueur sur l'écran s'il le désire (touche 'O' ou 'o')
                Console.WriteLine("Date |  Nom   |  Prenom    |   Score    |   Erreurs  ");
                Console.WriteLine("--------------------------------------------------------------------- ");
                Console.WriteLine(joueur.Date.ToString("yyyy-MM-dd") + " " + joueur.Nom + " " + joueur.Prenom + " " + joueur.Score + "/" + qcms.Count + " " + repfaux);
                Console.WriteLine();
                Console.WriteLine("Merci d'avoir joué \n Appuyez sur Q pour quitter l'application");
            }
            else
            {
                continuer = false;
                Console.WriteLine("Merci d'avoir joué \n Appuyez sur Q pour quitter l'application");
            }
            //Tant que le joueur n'appuie pas sur la touche 'Q', l'application ne se ferme pas.
            char touche = ' ';
            while (char.ToLower(touche) != 'q')
            {
                touche = Console.ReadKey().KeyChar;
            }
        }

        /// <summary>
        /// Creation de la méthode Vérification Format permettant de vérifier le format de la réponse du joueur
        /// </summary>
        /// <param name="rep"></param>
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
