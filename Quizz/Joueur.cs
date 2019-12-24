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
        public int Erreur { get; set; }
            


public Joueur(string nom, string prenom)
        {
            Nom = nom;
            Prenom = prenom;
            Date = DateTime.Today;
        }
    }

    
}
