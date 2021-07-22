using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructurePrograms
{
    class QueueUsindStack
    {

        public void GetInput()
        {
            //Create object for Calendar Class
            Calendar calendar = new Calendar();
            //Create Stack Week Objects
            Queue<CalenderUsingWeekObjects<Calendar>> Stackqueue = calendar.StackImplementation();
            int n = Stackqueue.Count;
            //Use another Stack to implement queue using two stacks
            for (int i=0;i<n;i++)
            { 
                CalenderUsingWeekObjects<Calendar> StackQueue = new CalenderUsingWeekObjects<Calendar>();
                Stackqueue.Dequeue().DeQueue(StackQueue);
                Stackqueue.Enqueue(StackQueue);
            }
            //Display Calendar using Two stacks implementation
            Console.WriteLine("*****Queue using Two Stacksfor week objects*****");
            calendar.Header();
            foreach (var i in Stackqueue)
            {
                i.DisplayWeek();
            }
        }
    }
}
