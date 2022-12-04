using Microsoft.EntityFrameworkCore;

namespace Final
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AppDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>()))
            {
              
                if (context.Players.Any())
                {
                    return; 
                
                context.Players.AddRange(
                    new Player
                    {
                        FirstName ="Willam",
                        LastName ="Burn",
                        Points= 18,
                        Assist = 12,
                        
                    },
                    new Player
                    {
                        FirstName ="Damien",
                        LastName ="Grey",
                        Points= 18,
                        Assist = 4,
                        
                    },
                    new Player
                    {
                        FirstName ="Evan",
                        LastName ="Phansna",
                        Points= 4,
                        Assist = 33,
                        
                    },
                    new Player
                    {
                        FirstName ="Eric",
                        LastName ="Blaze",
                        Points= 19,
                        Assist =8,
                        
                    },
                    new Player
                    {
                        FirstName ="Lee",
                        LastName ="wiggins",
                        Points= 22,
                        Assist =7,
                        
                    },
                    new Player
                    {
                        FirstName ="Lamar",
                        LastName ="Jackson",
                        Points= 45,
                        Assist = 12,
                        
                    },
                    new Player
                    {
                        FirstName ="waldo",
                        LastName ="Where",
                        Points= 0,
                        Assist = 0,
                        
                    },
                    new Player
                    {
                        FirstName ="Patrick",
                        LastName ="Mahomes",
                        Points= 14,
                        Assist = 12,
                        
                    },
                    new Player
                    {
                        FirstName ="Buzz",
                        LastName ="Lightyear",
                        Points= 8,
                        Assist = 12,
                        
                    },
                    new Player
                    {
                        FirstName ="Magic",
                        LastName ="johnson",
                        Points= 8,
                        Assist = 45,
                        
                    },
                     new Player
                    {
                        FirstName ="Tavi",
                        LastName ="Price",
                        Points= 30,
                        Assist = 4,
                        
                    },
                    new Player
                    {
                        FirstName ="Big",
                        LastName ="Country",
                        Points= 50,
                        Assist = 2,
                        
                    },
                    new Player
                    {
                        FirstName ="Berry",
                        LastName ="Allen",
                        Points= 25,
                        Assist = 10,
                        
                    },
                    new Player
                    {
                        FirstName ="troy",
                        LastName ="Bolton",
                        Points= 18,
                        Assist = 12,
                        
                    },
                    new Player
                    {
                        FirstName ="Bruce",
                        LastName ="Wayne",
                        Points= 45,
                        Assist = 13,
                        
                    },
                    new Player
                    {
                        FirstName ="Clark",
                        LastName ="Kent",
                        Points= 999,
                        Assist = 999,
                        
                    },
                    new Player
                    {
                        FirstName ="Peter",
                        LastName ="Parker",
                        Points= 22,
                        Assist = 30,
                        
                    },
                    new Player
                    {
                        FirstName ="Rick",
                        LastName ="James",
                        Points= 0,
                        Assist = 0,
                        
                    },
                    new Player
                    {
                        FirstName ="Leborn",
                        LastName ="James",
                        Points= 100,
                        Assist = 100,
                        
                    },
                    new Player
                    {
                        FirstName ="Shama",
                        LastName ="Espinoza",
                        Points= 33,
                        Assist = 7,
                        
                    },
                    new Player
                    {
                        FirstName ="Donniw",
                        LastName ="Wright",
                        Points= 100,
                        Assist = 2,
                        
                    },
                    new Player
                    {
                        FirstName ="Kobe",
                        LastName ="Bryant",
                        Points= 81,
                        Assist = 8,
                        
                    },
                    new Player
                    {
                        FirstName ="Dandre",
                        LastName ="Johnson",
                        Points= 3,
                        Assist = 45,
                        
                    },
                    new Player
                    {
                        FirstName ="Brandon",
                        LastName ="White",
                        Points= 8,
                        Assist = 1,
                        
                    },
                    new Player
                    {
                        FirstName ="Dorian",
                        LastName ="George",
                        Points= 30,
                        Assist = 10,
                        
                    }
                    
                );
                
                

                context.SaveChanges();

            }
        }
    }
}
}
                