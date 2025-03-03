using System;
using System.Collections.Generic;

namespace ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        ILogger logger = new ConsoleLogger();
        Company company = new Company(logger);

        ClientsCounter client1 = new ClientsCounter("Alice", "Regular", logger);
        ClientsCounter client2 = new ClientsCounter("Bobus", "New", logger);
        VipClient vipClient = new VipClient("Daddy", "Premium", "Gold", logger);

        company.AddClient(client1);
        company.AddClient(client2);
        company.AddClient(vipClient);

        Console.WriteLine("\nCompany Clients:");
        company.ShowAllClients();

        Console.WriteLine("\nTotal Users: " + ClientsCounter.GetUserCount());
    }
}