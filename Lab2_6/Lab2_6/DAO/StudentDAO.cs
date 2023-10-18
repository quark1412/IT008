namespace Lab2_6.DAO
{
    internal class StudentDAO
    {
        private StudentDAO() { }
        private static StudentDAO _instance;

        public static StudentDAO Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new StudentDAO();
                }
                return _instance;
            }
            private set => _instance = value;
        }

        public bool UpdateStudent(string id, string name, string idCourse, double math, double literature, double english)
        {
            string query = "EXEC UpdateStudent @id , @name , @idCourse , @math , @literature , @english";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id, name, idCourse, math, literature, english });

            return result > 0;
        }

        public bool DeleteStudent(string id)
        {
            string query = "EXEC DeleteStudent @id";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });

            return result > 0;
        }

        public bool AddStudent(string id, string name, string idCourse, double math, double literature, double english)
        {
            string query = "EXEC AddStudent @id , @name , @idCourse , @math , @literature , @english";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id, name, idCourse, math, literature, english });

            return result > 0;
        }
    }
}
