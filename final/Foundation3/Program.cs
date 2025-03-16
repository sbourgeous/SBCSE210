public class Program
{
    public static void Main()
    {
        Address address1 = new Address("123 Main St", "Springfield", "IL", "62704");
        Address address2 = new Address("456 Elm St", "Boston", "MA", "02108");
        Address address3 = new Address("789 Oak St", "Denver", "CO", "80202");

        Lectures lecture = new Lectures("Tech Conference", "A talk on AI advancements", "2025-04-10", "10:00 AM", address1, "Dr. Smith", 100);
        Receptions reception = new Receptions("Networking Gala", "Meet industry professionals", "2025-05-15", "6:00 PM", address2, "rsvp@example.com");
        OutdoorGatherings outdoor = new OutdoorGatherings("Music Festival", "Live bands and food trucks", "2025-06-20", "4:00 PM", address3, "Sunny with a chance of clouds");

        Event[] events = { lecture, reception, outdoor };

        foreach (var ev in events)
        {
            Console.WriteLine("\nSTANDARD DETAILS:");
            Console.WriteLine(ev.GetDetails());

            Console.WriteLine("\nFULL DETAILS:");
            Console.WriteLine(ev.GetFullDetails());

            Console.WriteLine("\nSHORT DESCRIPTION:");
            Console.WriteLine(ev.GetShortDescription());

            Console.WriteLine("--------------------------------");
        }
    }
}