using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BGDatabase.Models
{
    public class GameStoreDataContext : DbContext
    {
        public DbSet<BoardGame> Games { get; set; }

        public System.Data.Entity.DbSet<BGDatabase.Models.GameDesigner> GameDesigners { get; set; }
    }
}