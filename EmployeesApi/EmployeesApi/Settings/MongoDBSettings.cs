namespace EmployeesApi.Settings
{
    public class MongoDBSettings : IMongoDBSettings
    {
        public string EmployeeCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
