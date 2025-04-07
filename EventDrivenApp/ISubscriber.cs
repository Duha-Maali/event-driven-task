
namespace EventDrivenApp
{
    public interface ISubscriber
    {
        public void HandlePrimaryMessage(string message, DateTime time);
        public void HandlePromotionalMessage(string message, DateTime time);
        public void HandleSocialMessage(string message, DateTime time);
        public void HandleUpdateMessage(string message, DateTime time);

    }
}
