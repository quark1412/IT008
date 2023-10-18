using System.Data;
using System.Data.SqlClient;

namespace Lab2_6.DAO
{
    internal class DataProvider
    {
        private DataProvider() { }
        private static DataProvider _instance;

        internal static DataProvider Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DataProvider();
                }
                return _instance;
            }
            private set => _instance = value;
        }

        private string connectSTR = "Data Source=.\\;Initial Catalog=Lab2_6;Integrated Security=True";

        public DataTable ExecuteQuery(string query, object[] parameters = null)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameters != null)
                {
                    int i = 0;
                    string[] listParam = query.Split(' ');

                    foreach (var item in listParam)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, parameters[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);

                connection.Close();
            }
            return data;
        }

        public int ExecuteNonQuery(string query, object[] parameters = null)
        {
            int data = 0;

            using (SqlConnection connection = new SqlConnection(connectSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameters != null)
                {
                    int i = 0;
                    string[] listParam = query.Split(' ');

                    foreach (var item in listParam)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, parameters[i]);
                            i++;
                        }
                    }
                }

                // Hãy điển các parameter cách nhau bởi khoảng trắng và dấu phấy 
                // Ví dụ @id , @name , @des 

                data = command.ExecuteNonQuery();

                connection.Close();
            }
            return data;
        }

        public object ExecuteScalar(string query, object[] parameters = null)
        {
            object data = 0;

            using (SqlConnection connection = new SqlConnection(connectSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameters != null)
                {
                    int i = 0;
                    string[] listParam = query.Split(' ');

                    foreach (var item in listParam)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, parameters[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteScalar();

                connection.Close();
            }
            return data;
        }
    }
}
