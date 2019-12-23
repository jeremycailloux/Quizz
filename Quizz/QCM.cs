using System;
using System.Collections.Generic;
using System.Text;

namespace Quizz
{
    class QCM
    {
        
        public string Question { get; set; }
        public string MauvaiseRéponse { get; set; }
        public string BonneRéponse { get; set; }

        /// <summary>
        /// Constructeur QCM
        /// </summary>
        /// <param name="lignes"></param>
        public QCM(string[] lignes)
        {
            Lignes = lignes;
        }


   
     

    }
}
