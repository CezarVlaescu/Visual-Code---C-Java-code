using System.Security;

class Program
{
    public interface INotifications
    {
        // members of interface
        void showNotifications();
        string getDate();
    }

    public class Notifications : INotifications
    {
        private string sender;
        private string date;
        private string message;

        // Default constructor

        public Notifications() 
        {
            sender = "Cezar";
            date = " ";
            message = "What's up";            
        }

        public Notifications(string sender, string date, string message)
        {
            this.sender = sender;
            this.date = date;
            this.message = message;
        }

        public void showNotifications()
        {
            Console.WriteLine($"{this.message} by {this.sender} in date {this.date}");
        }

        public string getDate()
        {
            return date;
        }
    }
    
    
    
    static void Main(string[] args)
    {
        Notifications not1 = new Notifications("Alex", "10.02.2022", "Hello there");
        not1.showNotifications();
    }
}
