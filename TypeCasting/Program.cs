namespace Type_Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Implicit Casting (automatically) - converting a smaller type to a larger type size
            Console.WriteLine("Please enter a whole number!");
            // int myNum = 9;
            int myFavNum = Convert.ToInt32(Console.ReadLine());
            // myFavNum is now an integer, and we can use it as such
            Console.WriteLine("Your favorite number is: " + myFavNum);
            // Implicit casting example
            Console.WriteLine("Do you love Meowstic? (Please enter 'true' ir 'false')");
            // bool isTrue = true; // This is an example of implicit casting, where the boolean value 'true' is automatically converted to a string when concatenated with the rest of the message.
            bool isTrue = Convert.ToBoolean(Console.ReadLine());
            // isTrue is now a boolean, and we can use it as such
            Console.WriteLine($"It is {isTrue} that I love Meowstic!");

        }
    }
}
