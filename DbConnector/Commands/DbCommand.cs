using DbExercise.Connectors;
namespace DbExercise.Commands;

public class DbCommand
{
    private readonly DbConnector _connector;

    public DbCommand(DbConnector Connector)
    {
        if (Connector == null)
            throw new ArgumentNullException(nameof(Connector));
        this._connector = Connector;
    }

    public void Execute(string query)
    {
        if (string.IsNullOrWhiteSpace(query))
            throw new ArgumentNullException(nameof(query));
        this._connector.Open();
        Console.WriteLine($"Executing query: {query} on {this._connector.GetType()}");
        this._connector.Close();
    }
}
