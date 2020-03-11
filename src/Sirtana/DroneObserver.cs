//Author: JMY
//Date: 15.02.2018
//Place: ETML
//Description: Base version of Sirtana
namespace Sirtana
{
    /// <summary>
    /// Drone observer contract
    /// </summary>
    public interface DroneObserver
    {
        /// <summary>
        /// Notify when a question is asked
        /// </summary>
        /// <param name="question">question text</param>
        void QuestionAsked(string question);

        /// <summary>
        /// Notify when an answer is given
        /// </summary>
        /// <param name="answer">text of the answer</param>
        void AnswerGiven(string answer);
    }
}
