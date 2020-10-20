namespace Anifun.Data.Configuration
{
    public class DbSettings : IDbSettings
    {
        public string ConnectionString { get; set; }
        public string DbName { get; set; }
    }

    public interface IDbSettings
    {
        string ConnectionString { get; set; }
        string DbName { get; set; }
    }
}
