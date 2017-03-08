using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1._2
{
    class UserStory
    {
        private int hours { get; set;}
        private string description { get; set;}

        public UserStory(int hours, string description)
        {
            this.hours = hours;
            this.description = description;
        }

        public string ToString()
        {
            return "UserStory:" + this.description + "will take" + this.hours;
        }


        static void Main(string[] args)
        {
            UserStory U1 = new UserStory(5, "lekker leuk");
            UserStory U2 = new UserStory(7, "HEHE EKSDIE");
            UserStory U3 = new UserStory(9, "Fijn");
        }
    }
}
