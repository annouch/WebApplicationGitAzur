using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplicationGit.Entities.MusicStoreEntities;

namespace WebApplicationGit.Entities.MusicStoreContext
{
    public class WebApplicationGitAzurDB : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public WebApplicationGitAzurDB() : base("name=WebApplicationGitAzurDB")
        {
        }

        public System.Data.Entity.DbSet<Album> Albums { get; set; }

        public System.Data.Entity.DbSet<Artist> Artists { get; set; }

        public System.Data.Entity.DbSet<Genre> Genres { get; set; }
    }
}
