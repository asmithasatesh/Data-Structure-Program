using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructurePrograms
{
    public class CalenderUsingWeekObjects<T>
    {
        public string date;
        public string day;
        public CalenderUsingWeekObjects<T> next;
        CalenderUsingWeekObjects<T> head;
        //CalenderUsingWeekObjects<T> Week;

        public CalenderUsingWeekObjects()
        {
        }
        public CalenderUsingWeekObjects(string days, string dates)
        {
            this.date = dates;
            this.day = days;
            this.next = null;
        }
        public void Append(CalenderUsingWeekObjects<T> newNode)
        {
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                CalenderUsingWeekObjects<T> temp = GetLastNode();
                temp.next = newNode;

            }
        }
        //Return Last node in Linked List
        public CalenderUsingWeekObjects<T> GetLastNode()
        {
            CalenderUsingWeekObjects<T> temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }
        //Push operation for Stack
        public void InsertAtFront(CalenderUsingWeekObjects<T> newNode)
        {
            CalenderUsingWeekObjects<T> temp = head;
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                newNode.next = head;
                head = newNode;
            }
        }
        //Pop operation for stack
        public CalenderUsingWeekObjects<T> DeQueue(CalenderUsingWeekObjects<T> stack)
        {
            CalenderUsingWeekObjects<T> temp = head;
            stack.InsertAtFront(temp);
            return stack;
        }
        //Display Calendar
        public void DisplayWeek()
        {
            CalenderUsingWeekObjects<T> temp = head;
            while (temp != null)
            {
                if (temp.date == "")
                {
                    Console.Write("    ");
                    temp = temp.next;
                    continue;
                }

                Console.Write(temp.date);
                if (temp.date.Length >= 2)
                {
                    Console.Write("  ");
                }
                else
                {
                    Console.Write("   ");
                }
                temp = temp.next;
            }
            Console.WriteLine("\n");
        }
    }
}
