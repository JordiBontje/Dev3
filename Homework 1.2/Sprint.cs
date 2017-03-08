using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Homework_1._2
{
    class Sprint
    {
        public int count = 0;
        UserStory[] UserStories = new UserStory[10];
        public void AddUserStory(UserStory userstory)
        {
            UserStories[count] = userstory;
            count += 1;
        }
        public int TotalHours()
        {
            int sum = 0;
            for (int i = 0 ; i < count; i++)
            {
                sum += UserStories[i].hours;
            }
            return sum;
        }
    }
}