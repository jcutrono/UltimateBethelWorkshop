using System;
using System.Collections.Generic;

using MongoDB.Driver;

namespace CovidWeb
{
    public interface ILocationData
    {
        IEnumerable<Location> Get();
    }

    public class LocationData : DataAccess, ILocationData
    {
        public LocationData() : base("location")
        {
            
        }

        public IEnumerable<Location> Get()
        {
            return GetCollection<Location>().Find(_ => true).ToList();
        }
    }

    public abstract class DataAccess
    {
        protected IMongoDatabase database;
        private string _collectionName;

        protected DataAccess(string collectionName)
        {
            string url = Environment.GetEnvironmentVariable("MONGO_URL");
            string databaseName;

            if (string.IsNullOrEmpty(url))
            {
                url = "mongodb://localhost";
                databaseName = "covid";
            }
            else
            {
                var parts = url.Split('/');
                databaseName = parts[parts.Length - 1];
            }
            
            IMongoClient client = new MongoClient(url);
            database = client.GetDatabase(databaseName);

            _collectionName = collectionName;
        }

        protected IMongoCollection<T> GetCollection<T>()
        {
            return database.GetCollection<T>(_collectionName);
        }
    }
}