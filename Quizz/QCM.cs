using System;
using System.Collections.Generic;
using System.Text;

namespace Quizz
{
    class QCM
    {

        private string _ligne;
        public string Question { get; set; }

        public List<string> Propositions { get; set; }



        public QCM()
        {

            Propositions = new List<string>();
        }


        public override string ToString()
        { string prop = "";
            for (int i = 0; i < Propositions.Count; i++)
            {
               prop += Propositions[i];
            }



            return Question + prop ;
        }

    }

    
}
