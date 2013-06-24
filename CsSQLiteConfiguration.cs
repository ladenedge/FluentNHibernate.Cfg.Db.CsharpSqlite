
using FluentNHibernate.Cfg.Db;
using NHibernate.Dialect;

namespace FluentNHibernate.Cfg.Db.CsharpSqlite
{
    /// <summary>
    /// Fluent configuration for the C#-SQLite driver.
    /// </summary>
    public class CsharpSqliteConfiguration : SQLiteConfiguration
    {
        /// <summary>
        /// Instantiates a new configuration object.
        /// </summary>
        public CsharpSqliteConfiguration()
        {
            Driver<CsharpSqliteDriver>();
            Dialect<SQLiteDialect>();
            Raw("query.substitutions", "true=1;false=0"); 
        }
    }
}
