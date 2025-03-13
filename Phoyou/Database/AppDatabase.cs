using SQLite;
using Phoyou.Models;

namespace Phoyou.Data;

public class AppDatabase
{
    private readonly SQLiteAsyncConnection _database;

    public AppDatabase(string dbPath)
    {
        _database = new SQLiteAsyncConnection(dbPath);
        _database.CreateTableAsync<User>().Wait();
        _database.CreateTableAsync<Assignment>().Wait();
        _database.CreateTableAsync<Photo>().Wait();
        _database.CreateTableAsync<Comment>().Wait();
        _database.CreateTableAsync<PointsTransaction>().Wait();
    }

    public Task<List<T>> GetItemsAsync<T>() where T : new()
    {
        return _database.Table<T>().ToListAsync();
    }

    public Task<int> SaveItemAsync<T>(T item)
    {
        return _database.InsertAsync(item);
    }
}
