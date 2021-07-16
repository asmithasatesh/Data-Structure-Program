﻿using System;

namespace DataStructurePrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Datastructure Programs!");
            Console.WriteLine("Enter 1-For Unordered List");
            Console.WriteLine("Enter 2-For Ordered List");
            Console.WriteLine("Enter 3-Check for Balanced Parentheses in an expression");
            Console.WriteLine("Enter 4-Simulate Banking Cash Counter");
            Console.WriteLine("Enter 5-Palindrome Checker");




            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    UnorderedList<string> unorderedList = new UnorderedList<string>();
                    unorderedList.GetInput();
                    break;
                case 2:
                    OrderedList<int> orderedList = new OrderedList<int>();
                    orderedList.GetInput();
                    break;
                case 3:
                    BalanceParentheses<string> balanceParenthesis = new BalanceParentheses<string>();
                    balanceParenthesis.GetInput();
                    break;
                case 4:
                    BankingCashCounter<int> bankingCashCounter = new BankingCashCounter<int>();
                    bankingCashCounter.PeopleInputPanel();
                    break;
                case 5:
                    PalindromeChecker<char> palindrome = new PalindromeChecker<char>();
                    palindrome.CheckPalindrome();
                    break;
            }
        }
    }
}
