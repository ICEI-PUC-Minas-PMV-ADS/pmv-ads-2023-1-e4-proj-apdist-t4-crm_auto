using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace CRMobil.Entities
{
    public class CnnStoreDatabaseSettings
    {
        public string ConnectionString { get; set; } = null!;
        public string DatabaseName { get; set; } = null!;
        public string EntityCollectionName { get; set; } = null!;
    }
}
