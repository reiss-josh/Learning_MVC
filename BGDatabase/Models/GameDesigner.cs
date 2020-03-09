using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BGDatabase.Models
{
    public class GameDesigner
    {
        public int GameDesignerID { get; set; }
        [Required]
        public string DesignerName { get; set; }
        public virtual List<BoardGame> GamesDesigned { get; set; }
    }
}