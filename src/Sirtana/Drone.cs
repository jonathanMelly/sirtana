//Author: JMY
//Date: 15.02.2018
//Place: ETML
//Description: Base version of Sirtana
using System;
using System.IO;

namespace Sirtana
{
    /// <summary>
    /// Speaking drone
    /// </summary>
    public class Drone //TODO : become observable
    {
        private Random random = new Random();
        private string[] answerData;

        /// <summary>
        /// Base constructor with auto-loading of questions based on file
        /// </summary>
        public Drone()
        {
            //Read file
            answerData = File.ReadAllLines("../../../data/answers.csv");

            //Convert CSV removing first column which is line number
            for (int i = 0; i < answerData.Length; i++)
            {
                //Replace with message only
                answerData[i] = answerData[i].Split(';')[1];
            }
        }

        /// <summary>
        /// Gives an answer regarding the question asked or an error message if the format is invalid
        /// </summary>
        /// <param name="question">the text of the question</param>
        /// <returns>An answer or an error message about the input</returns>
        public string Answer(string question)
        {
            string answer;

            //Format check
            if (question.Contains("?"))
            {
                //TODO : Notify observers that a valid question has been asked

                //Take random answer
                //TODO : replae by a factory to get a suitable answer...
                int randomNumber = random.Next(answerData.Length);
                answer = answerData[randomNumber];

                //TODO : Notify observers that an answer has been given

            }
            //Bad format
            else
                answer = "Veuiller poser une question en terminant avec un ?";

            //Returns result
            return answer;
        }
    }
}
