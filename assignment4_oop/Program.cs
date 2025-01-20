using assignment1_oop;
using common;
namespace assignment1_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region weekdays

            Console.WriteLine("Days of the Week:");

            foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            {
                Console.WriteLine(day);

            }

            #endregion

            #region seas on

            Console.WriteLine("Enter a season (Spring, Summer, Autumn, Winter):");
            string input = Console.ReadLine();

            if (Enum.TryParse(typeof(Seas_on), input, true, out var season))
            {
                switch ((Seas_on)season)
                {
                    case Seas_on.Spring:
                        Console.WriteLine("Spring: March to May");
                        break;
                    case Seas_on.Summer:
                        Console.WriteLine("Summer: June to August");
                        break;
                    case Seas_on.Autumn:
                        Console.WriteLine("Autumn: September to November");
                        break;
                    case Seas_on.Winter:
                        Console.WriteLine("Winter: December to February");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter one of the following: Spring, Summer, Autumn, Winter.");
            }

            #endregion

            #region Permissions

            Permissions userPermissions = Permissions.None;

           
            userPermissions |= Permissions.Read;
            userPermissions |= Permissions.Write;
            Console.WriteLine($"Current Permissions: {userPermissions}");

        
            userPermissions &= ~Permissions.Write;
            Console.WriteLine($"Permissions after removing Write: {userPermissions}");

           
            bool canExecute = (userPermissions & Permissions.Execute) == Permissions.Execute;
            Console.WriteLine($"Can Execute: {canExecute}");

            
            userPermissions |= Permissions.Execute;
            Console.WriteLine($"Permissions after adding Execute: {userPermissions}");
            canExecute = (userPermissions & Permissions.Execute) == Permissions.Execute;
            Console.WriteLine($"Can Execute: {canExecute}");






            #endregion


            #region colors


            Console.WriteLine("Enter a color name:");
            string input1 = Console.ReadLine();

            if (Enum.TryParse(typeof(Colors), input1, true, out var color))
            {
                Console.WriteLine($"{input1} is a primary color.");
            }
            else
            {
                Console.WriteLine($"{input1} is not a primary color.");
            }






            #endregion








        }
    }
}
