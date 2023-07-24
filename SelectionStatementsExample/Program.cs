namespace SelectionStatementsExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bool condition = false;

            //if(condition)
            //{
            //    Console.WriteLine("This is true");
            //}
            //else
            //{
            //    Console.WriteLine("This is false");
            //}

            int a = 5;
            int b = 10;

            if(a == b)
            {
                Console.WriteLine("a is equal to b");
            }
            else if(a > b && a == 10)
            {
                Console.WriteLine("a is greater than b");
            }
            else
            {
                Console.WriteLine("none of these were true");
            }

            int i = 1;
            string positiveMessage = (i > 0) ? "You are positive" : (i == 0) ? "You are zero" : "You're not positive";
            Console.WriteLine(positiveMessage);


            string day = "Monday";

            switch(day)
            {
                case "Sunday":
                case "sunday":
                    Console.WriteLine("Sunday");
                    break;
                case "Monday":
                    Console.WriteLine("Monday");
                    break;
                case "Tuesday":
                    Console.WriteLine("Tuesday");
                    break;
                case "Wednesday":
                    Console.WriteLine("Wednesday");
                    break;
                case "Thursday":
                    Console.WriteLine("Thursday");
                    break;
                case "Friday":
                    Console.WriteLine("Friday");
                    break;
                case "Saturday":
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Not a day of the week");
                    break;
            }
        }
    }
}