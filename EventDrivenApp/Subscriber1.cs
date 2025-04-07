

namespace EventDrivenApp
{
    public class Subscriber1: ISubscriber
    {
        public string Name { get; set; }

       
        public Subscriber1(string name)
        {
            Name = name;
        }
        public void HandlePrimaryMessage(string message, DateTime time)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{Name} received Primary: {message} at {time} \n");
            Console.ResetColor();
        }
        public void HandlePromotionalMessage(string message, DateTime time)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{Name} received Promotion: {message} at {time} \n");
            Console.ResetColor();
        }
        public void HandleSocialMessage(string message, DateTime time)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{Name} received Social: {message} at {time} \n");
            Console.ResetColor();
        }
        public void HandleUpdateMessage(string message, DateTime time)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{Name} received Update: {message} at {time} \n");
            Console.ResetColor();
        }
    }
}
