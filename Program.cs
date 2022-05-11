using System;

namespace GroupProjectt
{
    internal class Program
    {
        static void Main()
        {
            int answer;
            string temp;
            Console.WriteLine("Whats 2 + 3?");
            temp = Console.ReadLine();
            answer = Convert.ToInt32(temp);
            if (answer == 5)
            {
                Console.WriteLine("Correct!")
            }
            else
            {
                Console.WriteLine("Wrong")
         
              } public void question2()
            {
                 int answer;
            string temp;
            Console.WriteLine("Whats 5 + 3?");
            temp = Console.ReadLine();
            answer = Convert.ToInt32(temp);
            if (answer == 8)
            {
                Console.WriteLine("Correct!")
            }
            else
            {
                Console.WriteLine("Wrong")
            }
            
            
        }
            public void question3()
            {
                int answer;
                string temp;
                Console.WriteLine("Whats is 5 * 4 =?");
                temp = Console.ReadLine();
                answer = Convert.ToInt32(temp);
                if (answer == 20)
                {
                    Console.WriteLine("Correct!")
                }
                else
                {
                 Console.WriteLine("Wrong")
                }

            }
    }
}
