using System;
using System.Collections.Generic;
using System.Text;

namespace Quizz
{
    class Joueur
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime Date { get; set; }
        public int Score { get; set; }
        
            

        /// <summary>
        /// Constructeur de la classe Joueur
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
public Joueur(string nom, string prenom)
        {
            Nom = nom;
            Prenom = prenom;
            Date = DateTime.Today;
        }
    }

    
}
