
using NHibernate.Driver;

namespace FluentNHibernate.Cfg.Db.CsharpSqlite
{
    /// <summary>
    /// C#-SQLite driver for Fluent NHibernate.
    /// </summary>
    public class CsharpSqliteDriver : ReflectionBasedDriver
    {
        /// <summary>
        /// Instantiates a new C#-SQLite driver class.
        /// </summary>
        public CsharpSqliteDriver() : base(
            "Community.CsharpSqlite.SQLiteClient",
            "Community.CsharpSqlite.SQLiteClient.SqliteConnection",
            "Community.CsharpSqlite.SQLiteClient.SqliteCommand")
        {
        }

        /// <summary>
        /// Gets whether this driver requires the use of the Named Prefix when trying to reference the Parameter in the Command's Parameter collection.
        /// </summary>
        public override bool UseNamedPrefixInParameter
        {
            get { return true; }
        }

        /// <summary>
        /// Gets whether this driver requires the use of a Named Prefix in the SQL statement.
        /// </summary>
        public override bool UseNamedPrefixInSql
        {
            get { return true; }
        }

        /// <summary>
        /// Gets the Named Prefix for parameters.
        /// </summary>
        public override string NamedPrefix
        {
            get { return "@"; }
        }

        /// <summary>
        /// Gets whether the driver supports more than one open IDataReader and only one IDbConnection.
        /// </summary>
        public override bool SupportsMultipleOpenReaders
        {
            get { return false; }
        }
    }
}
