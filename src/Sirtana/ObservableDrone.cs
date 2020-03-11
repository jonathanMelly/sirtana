//Author: JMY
//Date: 15.02.2018
//Place: ETML
//Description: Base version for Sirtana

namespace Sirtana
{
    /// <summary>
    /// Base structure to observe a drone with 2 events
    /// </summary>
    public abstract class ObservableDrone
    {
        public enum NOTIFICATION_TYPE  {QUESTION,ANSWER};

        //Unique observer : TODO support multiple observers
        private DroneObserver observer;

        /// <summary>
        /// Set observer (only one for now)
        /// </summary>
        /// <param name="observer"></param>
        public void SetObserver(DroneObserver observer)
        {
            this.observer = observer;
        }

        /// <summary>
        /// Notify observer
        /// </summary>
        /// <param name="content">message content</param>
        /// <param name="type">notification type</param>
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
