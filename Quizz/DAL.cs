using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Quizz
{
    class DAL
    {
        public const string CHEMIN_FICHIER = @"..\..\..\QCM.txt";
        /// <summary>
        /// Indique le chemin d'accès au fichier texte QCM contenant les questions et réponses du QCM
        /// </summary>
        /// <returns></returns>

         public static List<QCM> GetQCM()
         {
            // Création d'une liste pour stocker les données
            var questionsRéponses = new List<QCM>();

            // Chargement des lignes du fichier dans un tableau
            string[] lignes = File.ReadAllLines(CHEMIN_FICHIER);

            // Chargement des données dans la liste
            for (int i = 0; i < lignes.Length; i++)
            {
                var qcm = new QCM(lignes[i]);
                questionsRéponses.Add(qcm);
            }

            return questionsRéponses;
         }

    }
}
