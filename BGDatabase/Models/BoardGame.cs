using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BGDatabase.Models
{
    public class BoardGame
    {
        public int BoardGameID { get; set; }
        [Required]
        public string GameName { get; set; }
        public float? Weight { get; set; }
        public int PlayTime { get; set; }

        public int GameDesignerID { get; set; }
        public virtual GameDesigner Designer { get; set; }
    }
}