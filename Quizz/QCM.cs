using System;
using System.Collections.Generic;
using System.Text;

namespace Quizz
{
    class QCM
    {
        private string _ligne;
        public string Question { get; set; } //Déclaration de la propriété Question
        public List<string> Propositions { get; set; } //Déclaration de la propriété Propositions qui est une liste
        public string BonneRéponse { get; set; } //Déclaration de la propriété BonneRéponse
        public QCM() //Création du constructeur QCM
        {

            Propositions = new List<string>();
        }
        /// <summary>
        /// Utilisation dela methode ToString de la classe Objet dont héritent toutes les classes. C'est pourquoi nous utilisons override dans son type pour faire appel à la classe ancêtre Objet.
        /// Elle permet d'afficher des chaînes de charactère, ici nous l'utilisons pour afficher les objet QCM.
        /// Ces objets sont composés des propriétés Question et Propositions.
        /// Question est de type string, Propositions est de type List. Pour que la methode ToString puisse l'afficher il faut qu'elle soit convertie en string.
        /// Pour cela nous créons une nouvelles variable string prop qui se compose de la liste des proposition retenues pour chaque question.
        /// Le type de retour de la methode ToString est string.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        { 
            string prop = "";
            for (int i = 0; i < Propositions.Count; i++)
            {
               prop += Propositions[i] + "\n";
            }

            return Question + "\n" + prop;
        }
    }

    
}
