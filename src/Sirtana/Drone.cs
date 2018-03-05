//Auteur: JMY
//Date: 15.02.2018
//Lieu: ETML
//Description: Version de base pour Sirtana
using System;
using System.IO;

namespace Sirtana
{
    /// <summary>
    /// Drone parlant
    /// </summary>
    public class Drone //TODO : devenir observable
    {
        private Random random = new Random();
        private string[] answerData;

        /// <summary>
        /// Constructeur basique d'un drone avec chargement des réponses dans un fichier
        /// </summary>
        public Drone()
        {
            //Lecture du fichier
            answerData = File.ReadAllLines("../../../data/answers.csv");

            //Conversion du CSV en enlevant la première colonne qui numérote
            for (int i = 0; i < answerData.Length; i++)
            {
                //Remplacement avec uniquement le message
                answerData[i] = answerData[i].Split(';')[1];
            }
        }

        /// <summary>
        /// Donne une réponse selon la question posée ou un message d'erreur si le format est erroné
        /// </summary>
        /// <param name="question"></param>
        /// <returns>Une réponse ou un message d'erreur sur le format d'entrée</returns>
        public string Answer(string question)
        {
            string answer;

            //Vérification du format
            if (question.Contains("?"))
            {
                //TODO : notifier les observateurs qu'une question valide a été posée

                //On prend au hasard
                //TODO : remplacer par la factory pour obtenir une réponse...
                int randomNumber = random.Next(answerData.Length);
                answer = answerData[randomNumber];

                //TODO : notifier les observateurs qu'une réponse a été donnée

            }
            //Mauvais format
            else
                answer = "Veuiller poser une question en terminant avec un ?";

            //Affichage de la réponse
            return answer;
        }
    }
}
