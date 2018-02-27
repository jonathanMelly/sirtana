//Auteur: JMY
//Date: 15.02.2018
//Lieu: ETML
//Description: Version de base pour Sirtana

namespace Sirtana
{
    /// <summary>
    /// Structure de base pour observer un drone avec 2 évènements possibles
    /// </summary>
    public abstract class ObservableDrone
    {
        public enum NOTIFICATION_TYPE  {QUESTION,ANSWER};

        //Observateur unique : TODO supporter plusieurs observateurs
        private DroneObserver observer;

        /// <summary>
        /// Affectation de l'observateur (1 seul pour l'instant)
        /// </summary>
        /// <param name="observer"></param>
        public void SetObserver(DroneObserver observer)
        {
            this.observer = observer;
        }

        /// <summary>
        /// Lance la notification à l'observateur
        /// </summary>
        /// <param name="content">contenu du message</param>
        /// <param name="type">type de notification</param>
        protected void NotifyObserver(string content, NOTIFICATION_TYPE type)
        {
            switch(type)
            {
                case NOTIFICATION_TYPE.QUESTION:
                    observer.QuestionAsked(content);
                    break;

                case NOTIFICATION_TYPE.ANSWER:
                    observer.AnswerGiven(content);
                    break;
            }
        }

    }
}
