using SQLite;

namespace LocalDatabaseTutorial
{
    public class Person
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public int Size { get; set; }
        public string Gender { get; set; }
        public string Color { get; set; }
        public string Address { get; set; }
    }
}
