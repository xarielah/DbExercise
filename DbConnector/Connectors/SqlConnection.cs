

namespace DbExercise.Connectors;

public class SqlConnection(string connectionString) : DbConnector(connectionString)
{
    public override void Open()
    {
        CheckIfConnectionOpen();
        IsConnectionOpen = true;
        Console.WriteLine("SQL connection is open.");
    }

    public override void Close()
    {
        CheckIfConnectionClosed();
        Console.WriteLine("SQL connection is closed.");
    }
}
