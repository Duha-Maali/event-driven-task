

namespace EventDrivenApp
{
    public class Subscriber2: ISubscriber
    {
        public string Name { get; set; }

        public Subscriber2(string name)
        {
            Name = name;
        }
        public void HandlePrimaryMessage(string message, DateTime time)
        {
            Console.WriteLine($"[Subscriber {Name} ALERT] >>> PRIMARY RECEIVED <<<\nMessage: {message}\nTime: {time}\n");
        }
        public void HandlePromotionalMessage(string message, DateTime time)
        {
            Console.WriteLine($"[Subscriber {Name} ALERT] >>> PROMOTION RECEIVED <<<\nMessage: {message}\nTime: {time}\n");
        
        }
        public void HandleSocialMessage(string message, DateTime time)
        {
            Console.WriteLine($"[Subscriber {Name} ALERT] >>> SOCIAL RECEIVED <<<\nMessage: {message}\nTime: {time}\n");
        }
        public void HandleUpdateMessage(string message, DateTime time)
        {
            Console.WriteLine($"[Subscriber {Name} ALERT] >>> Update RECEIVED <<<\nMessage: {message}\nTime: {time}\n");
        }
    }
}
