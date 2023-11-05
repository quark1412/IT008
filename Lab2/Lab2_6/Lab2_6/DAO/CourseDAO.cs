using System.Data;

namespace Lab2_6.DAO
{
    internal class CourseDAO
    {
        private CourseDAO() { }
        private static CourseDAO _instance;

        public static CourseDAO Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CourseDAO();
                }
                return _instance;
            }
            private set => _instance = value;
        }

        public DataTable LoadListCourse()
        {
            string query = "select * from Course";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }

    }
}
