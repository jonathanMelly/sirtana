//Auteur: JMY
//Date: 15.02.2018
//Lieu: ETML
//Description: Version de base pour Sirtana
namespace Sirtana
{
    /// <summary>
    /// Contrat pour un observateur de drone
    /// </summary>
    public interface DroneObserver
    {
        /// <summary>
        /// Notification qu'une question valide a été posée
        /// </summary>
        /// <param name="question">la question posée en texte</param>
        void QuestionAsked(string question);

        /// <summary>
        /// Notification qu'une réponse a été donnée par le drone
        /// </summary>
        /// <param name="answer">la réponse du drone en texte</param>
        void AnswerGiven(string answer);
    }
}