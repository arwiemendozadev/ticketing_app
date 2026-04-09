public class EventCustomer
{
    public required int CustomerId { get; set; }
    public required int BoughtTickets { get; set; }
}

public class Event
{
    public string Name { get; set; } = "";
    public required int AgeRestriction { get; set; }
    public required DateTime EventDate { get; set; }
    public required int Capacity { get; set; }
    public int TicketsSold { get; set; }

    public List<EventCustomer> Customers { get; set; } = new List<EventCustomer>();
}

public static class EventData
{
    public static List<Event> Events = new List<Event>
    {
        new Event
        {
            Name = "Brick Show 25",
            AgeRestriction = 0,
            EventDate = new DateTime(2025,7,5),
            Capacity = 2000,
            TicketsSold = 18,
            Customers = new List<EventCustomer>
            {
                new EventCustomer { CustomerId = 923, BoughtTickets = 2 },
                new EventCustomer { CustomerId = 810, BoughtTickets = 4 },
                new EventCustomer { CustomerId = 924, BoughtTickets = 3 },
                new EventCustomer { CustomerId = 786, BoughtTickets = 9 }
            }
        },

        new Event
        {
            Name = "Selwyn Sounds 25",
            AgeRestriction = 18,
            EventDate = new DateTime(2025,3,1),
            Capacity = 1000,
            TicketsSold = 5,
            Customers = new List<EventCustomer>
            {
                new EventCustomer { CustomerId = 816, BoughtTickets = 5 }
            }
        },

        new Event
        {
            Name = "Brick Show 24",
            AgeRestriction = 0,
            EventDate = new DateTime(2024,7,13),
            Capacity = 2000,
            TicketsSold = 18,
            Customers = new List<EventCustomer>
            {
                new EventCustomer { CustomerId = 816, BoughtTickets = 2 },
                new EventCustomer { CustomerId = 810, BoughtTickets = 5 },
                new EventCustomer { CustomerId = 786, BoughtTickets = 3 },
                new EventCustomer { CustomerId = 924, BoughtTickets = 8 }
            }
        },

        new Event
        {
            Name = "Secret Music 25",
            AgeRestriction = 18,
            EventDate = new DateTime(2025,7,21),
            Capacity = 10,
            TicketsSold = 9,
            Customers = new List<EventCustomer>
            {
                new EventCustomer { CustomerId = 923, BoughtTickets = 2 },
                new EventCustomer { CustomerId = 786, BoughtTickets = 4 },
                new EventCustomer { CustomerId = 121, BoughtTickets = 4 }
            }
        }
    };
}
