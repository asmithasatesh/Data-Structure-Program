using System;
using System.IO;
using System.Numerics;
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
            Console.WriteLine("Enter 6-Prime Numbers in 2D array");
            Console.WriteLine("Enter 7-Number of Binary Search Tree");
            Console.WriteLine("Enter 8-To Search an element in Hash Table");

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
                case 6:
                    PrimeNumbers<int>.PrimeChecker(0,1000);
                    break;
                case 7:
                    NumbertofBST numbertofBST = new NumbertofBST();
                    Console.WriteLine("Enter the size of tree");
                    BigInteger number = Convert.ToInt32(Console.ReadLine());
                    BigInteger count =numbertofBST.NumberOfTree(number);
                    Console.WriteLine("Total count of BST with size {0} is: {1}", number, count);
                    break;
                case 8:
                    HashedSlots<int> hashedSlots = new HashedSlots<int>(11);
                    GetInput(hashedSlots);
                    break;
            }

        }
        public static void GetInput(HashedSlots<int> hashedSlots)
        {
            string filePath = @"D:\Assignments\DataStructurePrograms\DataStructurePrograms\NumberSlots.txt";
            string text = File.ReadAllText(filePath);
            string[] numbers = text.Split(" ");
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                hashedSlots.AddNode(Convert.ToInt32(numbers[i]));
            }
            hashedSlots.Display();
            Console.WriteLine("Enter the number to search:");
            int searchValue = Convert.ToInt32(Console.ReadLine());

            //Search element in Hash Table
            if (hashedSlots.Search(searchValue) == 1)
            {
                Console.WriteLine("Value {0} is Present in Hash Table", searchValue);
                File.WriteAllText(filePath, hashedSlots.Display());
            }
            else
            {
                hashedSlots.AddNode(searchValue);
                Console.WriteLine("Value {0} is not Present in Hash Table", searchValue);
                File.WriteAllText(filePath, hashedSlots.Display());
            }
        }
    }
}
