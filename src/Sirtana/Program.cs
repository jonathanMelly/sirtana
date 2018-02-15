//Auteur: JMY
//Date: 15.02.2018
//Lieu: ETML
//Description: Version de base pour Sirtana
using System;
using System.IO;

namespace Sirtana
{
    /// <summary>
    /// Version simplifiée de sirtana (assistant textuel inutile) en programmation procédurale
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            //Lecture du fichier
            string[] answerData= File.ReadAllLines("../../../data/answers.csv");

            //Conversion du CSV en enlevant la première colonne qui numérote
            for (int i= 0; i< answerData.Length;i++)
            {
                //Remplacement avec uniquement le message
                answerData[i] = answerData[i].Split(';')[1];
            }

            //Programme inifini
            while (true)
            {
                Console.WriteLine("Quelle est votre question ?");

                string question = Console.ReadLine();
                string answer = "";

                //Vérification du format
                if (question.Contains("?"))
                {
                    //On prend au hasard
                    int randomNumber = random.Next(answerData.Length);

                    answer = answerData[randomNumber];
                    
                }
                //Mauvais format
                else
                    answer = "Veuiller poser une question en terminant avec un ?";

                //Affichage de la réponse
                Console.WriteLine(answer);
            }
        }
    }
}
