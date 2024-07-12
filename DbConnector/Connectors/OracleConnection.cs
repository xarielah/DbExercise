
namespace DbExercise.Connectors;

// var oc = new OracleConnection("http://localhost:8080")
// oc.Open();
// oc.Open(); // Throwing a new exception
// oc.Close();

public class OracleConnection(string connectionString) : DbConnector(connectionString)
{
    public override void Open()
    {
        CheckIfConnectionOpen();
        IsConnectionOpen = true;
        Console.WriteLine("Oracle connection is open.");

    }

    public override void Close()
    {
        CheckIfConnectionClosed();
        IsConnectionOpen = false;
        Console.WriteLine("Oracle connection is closed.");

    }
}

