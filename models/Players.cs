using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace Final
{
    public class Player
    {
        public int PlayerID {get; set;}
        [BindProperty]
        [Required]
        public string FirstName {get; set;} = string.Empty;
        [Required]
        public string LastName {get; set;} = string.Empty;
        [Required]
        public int Points {get; set;} 

        public int Assist {get; set;} 

        public Team Team {get; set;} = null!;

        public int TeamID {get; set;}

        


    }
}
// using System;
// using System.Collections.Generic;
// using Microsoft.EntityFrameworkCore;

// namespace WTOverflow
// {
//     public class Answer
//     {
//        public int  AnswerID {get; set;}
//        public string Write {get; set;} = string.Empty;
//        public User User {get; set;} = null!;

//        public int UserID {get; set;}

//         public Question Question {get; set;} = null!;

//        public int QuestionID {get; set;}
//     }
// }