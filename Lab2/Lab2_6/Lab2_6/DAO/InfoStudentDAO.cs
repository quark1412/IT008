using System.Data;

namespace Lab2_6.DAO
{
    internal class InfoStudentDAO
    {
        private InfoStudentDAO() { }
        private static InfoStudentDAO _instance;

        public static InfoStudentDAO Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new InfoStudentDAO();
                }
                return _instance;
            }
            private set => _instance = value;
        }

        public DataTable LoadInfoStudent()
        {
            string query = "EXEC LoadInfoStudent";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }
    }
}
