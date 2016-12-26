#if NETSTANDARD1_6
using Microsoft.EntityFrameworkCore;

namespace MyEntity
{
    public class LogContext : DbContext
    {
        public DbSet<LogItem> Logs { get; set; }

        public static string ConnectionString =
            @"Server=localhost\SQLEXPRESS;Database=MyLog;integrated security=true";

        #region Constructors

        public LogContext() { }

        public LogContext(DbContextOptions<LogContext> options) : base(options) { }

        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
    }
}
#endif

#if NET46
using Microsoft.Data.Entity;

namespace MyEntity
{
    public class LogContext : DbContext
    {
        public DbSet<LogItem> Logs { get; set; }

        public static string ConnectionString =
            @"Server=localhost\SQLEXPRESS;Database=MyLog;integrated security=true";


        public LogContext() : base (ConnectionString) { }
    }
}

#endif