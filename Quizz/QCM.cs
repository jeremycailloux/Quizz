using System;
using System.Collections.Generic;
using System.Text;

namespace Quizz
{
    class QCM
    {
        
        public string _lignes { get;  }
        public string _question { get;  }
        public string _mauvaiseRéponse { get;  }
        public string _bonneRéponse { get; }



        /// <summary>
        /// Constructeur QCM
        /// </summary>
        /// <param name="lignes"></param>
        public QCM(string lignes)
        {
            _lignes = lignes;
        }


        /// <summary>
        /// Surcharge du constructeur de  QCM
        /// </summary>
        /// <param name="lignes"></param>
        /// <param name="question"></param>
        /// <param name="mauvaiseréponse"></param>
        /// <param name="bonneréponse"></param>
        public QCM(string lignes, string question, string mauvaiseréponse, string bonneréponse)
        {
            _lignes = lignes;
            _question = question;
            _mauvaiseRéponse = mauvaiseréponse;
            _bonneRéponse = bonneréponse;

        }

    }
}
