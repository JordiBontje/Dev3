using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1._2
{
    class UserStory
    {
        public int hours { get;  set; }
        private string description { get; set;}

        public UserStory(int hours, string description)
        {
            this.hours = hours;
            this.description = description;
        }

        public override string ToString()
        {
            return "UserStory:" + this.description + "will take" + this.hours;
        }
    }
}
