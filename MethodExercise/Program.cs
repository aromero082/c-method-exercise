using System;

namespace MethodExercise
{
    class Program
    {
        static void Main(string[] args)

        {  //exercise ----- 1

            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();

            Console.WriteLine("What is your favorite color?");
            string userFavoriteColor = Console.ReadLine();

            Console.WriteLine("What is your favorite animal?");
            string userFavoriteAnimal = Console.ReadLine();

            Console.WriteLine("What is your favorite band?");
            string userFavoriteBand = Console.ReadLine();

            Console.WriteLine($"There was once a guy named {userName}");
            Console.WriteLine($"His truck was his favorite color {userFavoriteColor}");
            Console.WriteLine($"His favorite animal was his pet a {userFavoriteAnimal}");
            Console.WriteLine($"His favorite band was the gratest band of all time {userFavoriteBand}");
        }
        
    }



        }
        
    
    


}




}
