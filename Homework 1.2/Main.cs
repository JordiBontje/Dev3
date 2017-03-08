using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1._2
{
    class MainFile
    {
        static void Main(string[] args)
        {
            UserStory U1 = new UserStory(5, "lekker leuk");
            UserStory U2 = new UserStory(7, "HEHE EKSDIE");
            UserStory U3 = new UserStory(9, "Fijn");

            Sprint sprint = new Sprint();

            sprint.AddUserStory(U1);
            sprint.AddUserStory(U2);
            sprint.AddUserStory(U3);
            
            Console.WriteLine(sprint.TotalHours());
            Console.ReadLine();
        }
    }
}
