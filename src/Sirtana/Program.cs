//Author: JMY
//Date: 15.02.2018
//Place: ETML
//Description: Base version for Sirtana
using System;

namespace Sirtana
{
    /// <summary>
    /// Simplified version of sirtana (useless text assistant)
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenue cher voyageur, je suis le drone Sirtana et attend votre question\n");

            //Speaking drone
            Drone drone = new Drone();

            //Main loop (infinite)
            while (true)
            {
                //User's question
                Console.Write("Question: ");
                string question = Console.ReadLine();

                //Drone's answer
                string answer = drone.Answer(question);
                Console.WriteLine("Réponse: "+answer);
            }
        }
    }
}
