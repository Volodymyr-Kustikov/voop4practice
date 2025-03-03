namespace ConsoleApp;

public class ClientsCounter : PersonBase
{
    private static int Clients = 0;
    protected string ClientsData = "Regular";
    protected readonly ILogger _logger;

    public ClientsCounter(string clientName, ILogger logger)
        : base(clientName)
    {
        Clients++;
        _logger = logger;
    }

    public ClientsCounter(string clientName, string clientType, ILogger logger)
        : base(clientName)
    {
        Clients++;
        ClientsData = clientType;
        _logger = logger;
    }

    public static int GetUserCount()
    {
        return Clients;
    }

    public override string GetRole()
    {
        return "Client";
    }

    public virtual void ShowClientsData()
    {
        _logger.Log($"Client: {Name}, Type: {ClientsData}");
    }
}