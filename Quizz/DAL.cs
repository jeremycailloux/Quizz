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
            var questionsPropositions = new List<QCM>();

            // Chargement des lignes du fichier dans un tableau
            string[] lignes = File.ReadAllLines(CHEMIN_FICHIER);





            // Chargement des données dans la liste
            for (int i = 0; i < lignes.Length; i++)
            {
                QCM qcm = null;
            
                if (lignes[i].Substring(0, 8) == "Question")
                {

                    qcm = new QCM();
                    qcm.Question = lignes[i];

                }

                else if (lignes[i].Length == 0)
                {

                }

                else
                {
                    qcm.Propositions.Add(lignes[i]);
                    
                }
                
                questionsPropositions.Add(qcm);

            }

            return questionsPropositions;
        }

    }
}
