using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BGDatabase.Models
{
    public class GameStoreDataContextInitializer : DropCreateDatabaseAlways<GameStoreDataContext>
    {
        protected override void Seed(GameStoreDataContext context)
        {
            context.Games.Add(new BoardGame() { GameName = "Root" });
            context.Games.Add(new BoardGame() { GameName = "Concordia" });
        }
    }
}