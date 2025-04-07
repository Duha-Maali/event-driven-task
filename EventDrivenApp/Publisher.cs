
namespace EventDrivenApp
{
    public class Publisher
    {
        //declare delegate
        public delegate void NotoficatioEventHandler(string message,DateTime time);

        //declare events for different types of notifications
        public event NotoficatioEventHandler OnPrimary;

        public event NotoficatioEventHandler OnPromotions;

        public event NotoficatioEventHandler OnSocial;

        public event NotoficatioEventHandler OnUpdates;

        // method to trigger Primary message event
        public void NotifyPrimary(string message, DateTime time)
        {
            OnPrimary?.Invoke(message, time);
        }

        // method to trigger Promotions message event
        public void NotifyPromotions(string message, DateTime time)
        {
            OnPromotions?.Invoke(message, time);
        }

        // method to trigger Social message event
        public void NotifySocial(string message, DateTime time)
        {
            OnSocial?.Invoke(message, time);
        }

        // method to trigger Updates message event
        public void NotifyUpdates(string message, DateTime time)
        {
            OnUpdates?.Invoke(message, time);
        }
    }
}

