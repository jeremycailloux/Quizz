using System;
using System.Collections.Generic;
using System.IO;

namespace Quizz
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Saisissez votre Nom");
           // string nom = Console.ReadLine();
           // Console.WriteLine("Saisissez votre Prénom");
           // string prenom = Console.ReadLine();

           // VisualiserFichier();
           //Console.ReadLine();

            List<QCM> qcms = DAL.GetQCM();


            //foreach (var q in qcms) Console.WriteLine(q);



            //instructions données au joueur
            Console.WriteLine("Bienvenue sur le Quizz! \nVeuillez saisir la/les lettre(s) correspondant à/aux réponse(s) en majuscule(s) et sans espaces (ex : AC). \n" +
                "Appuyez sur une touche pour commencer\n");
            Console.ReadLine();
            Console.Clear();

                //On initialise la variable 'compteur' de bonnes réponses à 0
            int compteur=0;
            for (int i = 0; i < qcms.Count; i++)
            {
                
            
            //On affiche la question et ses propositions
            Console.WriteLine(qcms[i]);
            //on enregistre la chaine de caractères dans la variable réponse
            string reponse=Console.ReadLine();

            //si la réponse du joueur est correcte, on incrémente le compteur de 1
            if (reponse==qcms[i].BonneRéponse)
            {
                compteur++;
            }

            }
            Console.WriteLine("Votre score est de {0} sur {1}", compteur, qcms.Count);

        }


        



       /* private static void VisualiserFichier()
        {
            string[] lignes = File.ReadAllLines(@"..\..\..\QCM.txt");
                                                  
        }*/
        
    }
}
