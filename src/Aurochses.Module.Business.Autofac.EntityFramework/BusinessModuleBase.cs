namespace Aurochses.Module.Business.Autofac.EntityFramework
{
    /// <summary>
    /// Autofac module for business layer.
    /// </summary>
    /// <seealso cref="Module" />
    public class BusinessModuleBase : global::Autofac.Module
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessModuleBase"/> class.
        /// </summary>
        /// <param name="nameOrConnectionString">The database name or connection string.</param>
        /// <param name="schemaName">Name of the schema.</param>
        public BusinessModuleBase(string nameOrConnectionString, string schemaName)
        {
            NameOrConnectionString = nameOrConnectionString;
            SchemaName = schemaName;
        }

        /// <summary>
        /// The NameOrConnectionString parameter name
        /// </summary>
        public const string NameOrConnectionStringParameter = "nameOrConnectionString";

        /// <summary>
        /// The SchemaName parameter name.
        /// </summary>
        public const string SchemaNameParameter = "schemaName";

        /// <summary>
        /// Gets the database name or connection string.
        /// </summary>
        /// <value>The database name or connection string.</value>
        public string NameOrConnectionString
        {
            get;
        }

        /// <summary>
        /// Gets the database schema name.
        /// </summary>
        /// <value>The database schema name.</value>
        public string SchemaName
        {
            get;
        }
    }
}