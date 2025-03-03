namespace ConsoleApp;

public class Company
{
    private readonly List<ClientsCounter> _clients = new();
    private readonly ILogger _logger;

    public Company(ILogger logger)
    {
        _logger = logger;
    }

    public void AddClient(ClientsCounter client)
    {
        _clients.Add(client);
        _logger.Log($"New client added: {client.Name}");
    }

    public void ShowAllClients()
    {
        foreach (var client in _clients)
        {
            client.ShowClientsData();
        }
    }
}
