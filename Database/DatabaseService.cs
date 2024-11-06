using SQLite;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LiveStockApp.Database
{
    public class DatabaseService
    {
        private readonly SQLiteAsyncConnection _database;

        public DatabaseService(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Livestock>().Wait();
        }

        public Task<List<Livestock>> GetLivestockAsync()
        {
            return _database.Table<Livestock>().ToListAsync();
        }

        public Task<int> SaveLivestockAsync(Livestock livestock)
        {
            return _database.InsertAsync(livestock);
        }
    }
}
