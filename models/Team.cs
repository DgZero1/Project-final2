using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Final
{
    public class Team
    {
        public int  TeamID {get; set;}
        
        public string TeamName {get; set;} = string.Empty;

        public string Coach {get; set;} = string.Empty;

        public string Location {get; set;} = string.Empty;

         public List <Player> Players {get; set;} = null!; 

       
    }
}