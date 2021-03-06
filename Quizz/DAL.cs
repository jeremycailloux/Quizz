﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Quizz
{
    class DAL
    {
        public const string CHEMIN_FICHIER = @"..\..\..\QCM.txt"; //Indique le chemin d'accès au fichier texte QCM contenant les questions et réponses du QCM
        /// <summary>
        /// La méthode GetQCM permet d'afficher la liste QCM qui correspond au texte du fichier QCM
        /// Elle est de type static.
        /// </summary>
        /// <returns></returns>
        public static List<QCM> GetQCM()
        {
            // Création d'une liste pour stocker les données
            var questionsPropositions = new List<QCM>();

            // Chargement des lignes du fichier dans un tableau
            string[] lignes = File.ReadAllLines(CHEMIN_FICHIER);
            QCM qcm = null;
            // Chargement des données dans la liste qcm
            for (int i = 0; i < lignes.Length; i++)
            {// si la chaine de caractères 'Question' est inscrite dans les 8 premiers caractères de la ligne, la ligne est enregistrée dans les questions.
                if (lignes[i].Length >= 8 && lignes[i].Substring(0, 8) == "Question")
                {

                    qcm = new QCM();
                    qcm.Question = lignes[i];

                } //si si la ligne est vide, on crée un nouveau bloc QuestionsPropositions
                else if (lignes[i].Length == 0)
                {
                    questionsPropositions.Add(qcm);
                }

                else
                {    //si la ligne commence par le caractère '*', la ligne est enregistée dans les bonnes réponses, le caractère est effacé pour masquer au joueur la bonne réponse.
                    if (lignes[i].Substring(0, 1) == "*")
                    {
                        lignes[i] = lignes[i].Substring(1);
                        qcm.BonneRéponse += lignes[i].Substring(0, 1);
                    }
                    qcm.Propositions.Add(lignes[i]);
                }
            }
            //Rajoute la dernière question qui n'est pas reconnue car le programme ne considère pas le dernier esapce comme une limite pour l'ajout du dernier 'questionsPropositions'
            questionsPropositions.Add(qcm);
            return questionsPropositions;
        }
    }
}
