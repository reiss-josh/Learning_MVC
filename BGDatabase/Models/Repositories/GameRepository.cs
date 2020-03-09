using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BGDatabase.Models.Repositories
{
    public class GameRepository : Repository<BoardGame>
    {
        public List<BoardGame> GetByName(String name)
        {
            return DbSet.Where(s => s.GameName.Contains(name)).ToList();
        }
    }
}