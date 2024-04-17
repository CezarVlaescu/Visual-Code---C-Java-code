    public class FootballEvent : EventArgs // Event -> this is our custom event 
    {
        public string FootballMatch {  get; set; }

        public FootballEvent(string footballMatch) => FootballMatch = footballMatch;
    }

    public class TVChannel // Observable / Subject
    {
        public event EventHandler<FootballEvent> MatchEvent; // here we handle the event, this is the prop. of a subject to create events

        public void Notify(string match) => OnMatchChanged(new FootballEvent(match)); // this function creates a new event using the function below

        protected virtual void OnMatchChanged(FootballEvent e) => MatchEvent?.Invoke(this, e); // this method takes an event and invoke, waiting for the observer to subscribe for that event and override it
        // This method is a protected virtual method intended to be a safe place to raise the event.
        // The null-conditional operator (?.) checks if there are any subscribers before invoking the event to avoid a NullReferenceException if there are no subscribers.
    }

    public class Spectator // Subscriber / Observer
    {
        public void Subscribe(TVChannel channel) => channel.MatchEvent += OnMatchChanged; // subscribing for event

        public void UnSubcribe(TVChannel channel) => channel.MatchEvent -= OnMatchChanged; // unsubscribe for event

        private void OnMatchChanged(object sender, FootballEvent e) => Console.WriteLine($"Today's match is {e.FootballMatch}"); // it handles the event, this method is an event handler that responds to the event triggered by the TVChannel.
    }

    public class Test
    {
        static void Main(string[] args)
        {
            var notifier = new TVChannel();
            var subscriber = new Spectator();

            subscriber.Subscribe(notifier);

            notifier.Notify("Barcelona - Real Madrid");
        }
    }
