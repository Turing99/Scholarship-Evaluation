namespace EmployeesApi.Settings
{
    public interface IMongoDBSettings
    {
        string EmployeeCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
