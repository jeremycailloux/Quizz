using System;
using System.Collections.Generic;
using System.IO;

namespace Quizz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Saisissez votre Nom");
            string nom = Console.ReadLine();
            Console.WriteLine("Saisissez votre Prénom");
            string prenom = Console.ReadLine();

           // VisualiserFichier();
           //Console.ReadLine();

            List<QCM> qcm = DAL.GetQCM();
            foreach (var q in qcm) Console.WriteLine(q.Lignes);

        }

        /*
        private static void VisualiserFichier()
        {
            string[] lignes = File.ReadAllLines(@"..\..\..\QCM.txt");

            Console.WriteLine();
            QCM qcm;
            for (int i = 1; i < lignes.Length; i++);
            {
                qcm = new QCM (lignes[i]);
                Console.WriteLine(qcm);
        }
        */
        
    }
}
