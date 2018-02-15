//Auteur: JMY
//Date: 15.02.2018
//Lieu: ETML
//Description: Version de base pour Sirtana
using System;

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
                    int randomNumber = random.Next(3);

                    //Premier cas
                    if (randomNumber == 0)
                        answer = "C'est une bonne question et je ne suis pas certain d'avoir la réponse";

                    //Deuxième cas
                    else if (randomNumber == 1)
                        answer = "Je comprends votre interrogation et vais y réfléchir";
                    //Dernier cas
                    else
                        answer = "Je ne sais pas";
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
