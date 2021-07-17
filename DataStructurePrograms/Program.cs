using System;

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
                    int number = Convert.ToInt32(Console.ReadLine());
                    int count=numbertofBST.NumberOfTree(number);
                    Console.WriteLine("Total count of BST with size {0} is: {1}", number, count);
                    break;
            }
        }
    }
}
