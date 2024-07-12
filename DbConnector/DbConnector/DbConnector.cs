
namespace DbExercise.DbConnector;
public abstract class DbConnector
{
    public string ConnectionString { get; private set; }
    public TimeSpan Timeout { get; private set; }
    protected bool IsConnectionOpen = false;

    protected DbConnector(string connectionString)
    {
        if (string.IsNullOrWhiteSpace(connectionString))
            throw new InvalidOperationException("Connection string cannot be null or empty.");

        ConnectionString = connectionString;
    }

    protected void CheckIfConnectionOpen()
    {
        if (IsConnectionOpen)
            throw new InvalidOperationException("Connection is already open.");
    }

    protected void CheckIfConnectionClosed()
    {
        if (!IsConnectionOpen)
            throw new InvalidOperationException("Connection is already closed.");
    }



    public abstract void Open();
    public abstract void Close();
}
