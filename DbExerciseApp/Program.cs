using DbExercise.Connectors;
using DbCommand = DbExercise.Commands.DbCommand;

namespace DbExerciseApp;

public class Program
{
    public static void Main()
    {
        // Cannot instantiate an abstract class
        // var db = new DbConnector("http://localhost:8080");

        var oc = new OracleConnection("http://localhost:8080");
        //oc.Open();
        //oc.Close();

        var sc = new SqlConnection("http://localhost:8080");
        //sc.Open();
        // sc.Open(); - Will throw an exception.
        //sc.Close();

        var dbCommand1 = new DbCommand(oc);

        var dbCommand2 = new DbCommand(sc);

        dbCommand1.Execute("SELECT * FROM Oracle_Database");
        dbCommand2.Execute("SELECT * FROM SQL_Database");
    }
}