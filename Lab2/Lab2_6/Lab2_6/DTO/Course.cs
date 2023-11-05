using System.Data;

namespace Lab2_6.DTO
{
    internal class Course
    {
        private string _id;
        private string _name;

        public Course(string id, string name)
        {
            Id = id;
            Name = name;
        }

        public string Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }

        public Course(DataRow row)
        {
            Id = row["id"].ToString();
            Name = row["name"].ToString();
        }
    }
}
