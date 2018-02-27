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
            Console.WriteLine("Bienvenue cher voyageur, je suis le drone Sirtana et attend votre question\n");

            //Création d'un drone parlant
            Drone drone = new Drone();

            //Programme infini
            while (true)
            {
                //Question de l'utilisateur
                Console.Write("Question: ");
                string question = Console.ReadLine();

                //Réponse du drone
                string answer = drone.Answer(question);
                Console.WriteLine("Réponse: "+answer);
            }
        }
    }
}
