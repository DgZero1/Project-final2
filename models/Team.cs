using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace Final
{
    public class Team
    {
        public int  TeamID {get; set;}
         [BindProperty]
        [Required]
        public string TeamName {get; set;} = string.Empty;
    [Required]
        public string Coach {get; set;} = string.Empty;
    [Required]
        public string Location {get; set;} = string.Empty;
    [Required]
         public List <Player> Players {get; set;} = null!; 

       
    }
}