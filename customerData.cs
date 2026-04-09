public class Customer
{
    public required int Id { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required DateTime BirthDate { get; set; }
    public string? Email { get; set; }
}

public static class CustomerData
{
    public static List<Customer> Customers = new List<Customer>
    {
        new Customer { Id = 816, FirstName = "Simon", LastName = "Charles", BirthDate = new DateTime(1952,7,15), Email = "simon@charles.nz" },
        new Customer { Id = 923, FirstName = "Simone", LastName = "Charles", BirthDate = new DateTime(1987,9,1), Email = "simone.charles@kiwi.nz" },
        new Customer { Id = 343, FirstName = "Charlie", LastName = "Charles", BirthDate = new DateTime(1954,1,25), Email = "charlie@charles.nz" },
        new Customer { Id = 810, FirstName = "Kate", LastName = "McArthur", BirthDate = new DateTime(1972,9,30), Email = "K_McArthur94@gmail.com" },
        new Customer { Id = 786, FirstName = "Jack", LastName = "Hopere", BirthDate = new DateTime(1980,2,10), Email = "Jack643@gmail.com" },
        new Customer { Id = 801, FirstName = "Chloe", LastName = "Mathewson", BirthDate = new DateTime(1980,3,15), Email = "Chloe572@gmail.com" },
        new Customer { Id = 121, FirstName = "Kate", LastName = "McLeod", BirthDate = new DateTime(1952,7,15), Email = "KMcLeod112@gmail.com" },
        new Customer { Id = 924, FirstName = "Samantha", LastName = "Charles", BirthDate = new DateTime(2013,7,24), Email = "simone.charles@kiwi.nz" }
    };
}

public class CustomerEventInfo
{
    public required string EventName { get; set; } = "";
    public required int TicketsBought { get; set; }
}
