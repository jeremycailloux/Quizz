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
        {
            return base.ToString(Question, );
        }








    }

       

        






    }
}
