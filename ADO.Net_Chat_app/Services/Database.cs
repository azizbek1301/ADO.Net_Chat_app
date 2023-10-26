using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ADO.Net_Chat_app.Services
{
    public class Database
    {
        public static void Insert(String userName, string password)
        {

            using (SqlConnection connect = new SqlConnection())
            {
                connect.ConnectionString = @"Server=(localdb)\MSSQLLocalDB;Database=ChatDb;Trusted_Connection=True;";
                connect.Open();
                if(!CheckInfo(userName,password))
                {
                    string query = $"insert into Users (userName,password)values" +
                    $"('{userName}','{password}')";
                    SqlCommand sqlCommand = new SqlCommand(query, connect);
                    sqlCommand.ExecuteNonQuery();
                    
                }
              
            }
        }
        public static bool CheckInfo(string username,string password)
        {
            using (SqlConnection connect = new SqlConnection())
            {
                connect.ConnectionString = @"Server=(localdb)\MSSQLLocalDB;Database=ChatDb;Trusted_Connection=True;";
                connect.Open();

                string query = $"select * from Users where userName='{username}' and password='{password}'";
                SqlCommand sqlCommand = new SqlCommand(query, connect);
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    int c = 0;
                    while (reader.Read())
                    {
                        c++;
                    }

                    return c > 0;
                    
                }
                

            }
        }

        public static void MessageInsert(string message,string userName)
        {
            using (SqlConnection connect = new SqlConnection())
            {
                int userId = 0;
                connect.ConnectionString = @"Server=(localdb)\MSSQLLocalDB;Database=ChatDb;Trusted_Connection=True;";
                connect.Open();

                string query = $"select * from Users where userName='{userName}'";
                SqlCommand sqlCommand = new SqlCommand(query, connect);
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                       userId = int.Parse(reader["userId"].ToString());
                    }
                   
                    
                }

                string query2 = $"insert into Message (text,senderId)values ('{message}',{userId})";
                SqlCommand sqlCommand2 = new SqlCommand(query2, connect);
                using(SqlDataReader reader = sqlCommand2.ExecuteReader())
                {
                    
                }



            }
        }
        public static List<string> GetMessages()
        {
            using (SqlConnection connect = new SqlConnection())
            {
                connect.ConnectionString = @"Server=(localdb)\MSSQLLocalDB;Database=ChatDb;Trusted_Connection=True;";
                connect.Open();

                string query = $"select userName,text from Message Inner Join Users on userId=Message.senderId; ";
                SqlCommand sqlCommand = new SqlCommand(query, connect);
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    List<string> messages = new List<string>();
                    string result = String.Empty;
                    while (reader.Read())
                    {
                        result += reader["userName"] + " => " + reader["text"] + "\n";
                        messages.Add(result);
                    }
                    return messages;
                }
            }
        }
    }
}
