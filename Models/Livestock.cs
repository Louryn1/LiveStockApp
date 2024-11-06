using SQLite;

namespace LiveStockApp.Models
{
    public class Livestock
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
    }
}
