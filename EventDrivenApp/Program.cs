using System;
using EventDrivenApp;

class Program 
{
    public static void Main(string[] args)
    {
        Publisher publisher = new Publisher();
        Subscriber1 sub1 = new Subscriber1("Duha");
        Subscriber2 sub2 = new Subscriber2("Alaa");
        Collection subscribers = new Collection();
        subscribers.AddSubscriber(sub1);
        subscribers.AddSubscriber(sub2);
        foreach (var sub in subscribers)
        {
            Console.WriteLine($"{sub}");
        }
        foreach (var sub in subscribers)
        {
            publisher.OnPrimary += sub.HandlePrimaryMessage;
            publisher.OnPromotions += sub.HandlePromotionalMessage;
            publisher.OnSocial += sub.HandleSocialMessage;
            publisher.OnUpdates += sub.HandleUpdateMessage;
        }
        publisher.NotifyPrimary("Your account was accessed from a new device.", DateTime.Now);
        publisher.NotifyPromotions("50% off on all items!", DateTime.Now);
        publisher.NotifySocial("You have a new friend request.", DateTime.Now);
        publisher.NotifyUpdates("This new IDE from Google is an absolute game changer | Tari Ibaba in Coding Beauty", DateTime.Now);
    }
}