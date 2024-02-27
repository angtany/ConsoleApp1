using System.Data.SqlClient;

public void RunQuery(string input)
{
    string query = "SELECT * FROM users WHERE name = '" + input + "'";

    using (var connection = new SqlConnection("..."))
    using (var command = new SqlCommand(query, connection))
    {
        connection.Open();
        command.ExecuteNonQuery();
    }
}


