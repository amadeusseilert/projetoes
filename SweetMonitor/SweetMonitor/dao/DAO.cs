namespace SweetMonitor.dao
{
    using modelo;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Linq;

    public class DAO : DbContext
    {
        // Your context has been configured to use a 'DAO' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'SweetMonitor.dao.DAO' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'DAO' 
        // connection string in the application configuration file.
        public DAO()
            : base("name=DAO")
        {
            Configuration.ProxyCreationEnabled = false;
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Alarme> alarmes { get; set; }
        public virtual DbSet<Dado> dados { get; set; }
        public virtual DbSet<Comando> comandos { get; set; }

    }

}