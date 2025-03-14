using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            string optionSlug = "\0";

            do
            {
                PrintInConsole("========================================\n");
                PrintOtions(GetOptions());
                PrintInConsole("========================================\n");
                PrintInConsole("Enter your choice: ");
                optionSlug = (Console.ReadLine()).ToUpper();

                switch (optionSlug)
                {
                    case "P":
                        if (ListIsEmpty(list))
                            PrintInConsole("[] - the list is empty");
                        else
                            PrintInConsole($"{GetListInString(list)}");
                        break;

                    case "A":
                        PrintInConsole("Enter The number To Add : ");
                        int number = Convert.ToInt32(Console.ReadLine());
                        if (IsFound(list, number))
                            PrintInConsole($"{number} can't be added. it's already in the list");
                        else
                        {
                            AddNumberToList(list, number);
                            PrintInConsole($"{number} added");
                        }
                        break;
                    case "M":
                        if (ListIsEmpty(list))
                            PrintInConsole("Mean = 0 Because List is Empty");
                        else
                            PrintInConsole($"Mean = {GetListMean(list)}");
                        break;

                    case "S":
                        if (ListIsEmpty(list))
                            PrintInConsole("List Is Empty");
                        else
                            PrintInConsole($"The smallest number is {GetSmallestNumberInList(list)}");
                        break;

                    case "L":
                        if (ListIsEmpty(list))
                            PrintInConsole("List Is Empty");
                        else
                            PrintInConsole($"The largest number is {GetLargestNumberInList(list)}");
                        break;
                    case "F":
                        if (ListIsEmpty(list))
                            PrintInConsole("List Is Empty");
                        else
                        {
                            PrintInConsole("Enter the number to search");
                            number = Convert.ToInt32(Console.ReadLine());
                            int index = GetIndex(list, number);
                            if (index < 0)
                                PrintInConsole($"{number} is not in list");
                            else
                                PrintInConsole($"Needed number in index {index} and position {index + 1}"); ;
                        }
                        break;

                    case "C":
                        ClearList(list);
                        PrintInConsole("List Cleared Success");
                        break;

                    case "W":
                        if (ListIsEmpty(list))
                        {
                            PrintInConsole("Sorry, List Is Empty");
                            return;
                        }
                        PrintInConsole("Ente the first number ");
                        int firstNumber = Convert.ToInt32(Console.ReadLine());
                        PrintInConsole("Ente the second number ");
                        int secondNumber = Convert.ToInt32(Console.ReadLine());

                        if(firstNumber == secondNumber)
                            PrintInConsole("Sorry, You must enter different numbers");
                        else if(!IsFound(list, firstNumber))
                            PrintInConsole($"{firstNumber} is not in list");
                        else if (!IsFound(list, secondNumber))
                            PrintInConsole($"{secondNumber} is not in list");
                        else
                        {
                            Swap(list, GetIndex(list, firstNumber), GetIndex(list, secondNumber));
                            PrintInConsole("Swapped");
                        }
                         
                        break;
                    default:
                        PrintInConsole("Please enter correct char");
                        break;

                }

            } while (optionSlug != "Q");


        }

        public static void PrintInConsole(string message)
        {
            Console.WriteLine(message);
        }

        public static void PrintOtions(Dictionary<char, string> options)
        {
            for(int i=0; i<options.Count; i++)
            {
                var element = options.ElementAt(i);
                PrintInConsole($"{element.Key} - {element.Value}");
            }
        }

        public static Dictionary<char, string> GetOptions()
        {
            Dictionary<char, string> options = new Dictionary<char, string>();
            options.Add('p', "Print numbers");
            options.Add('A', "Add a number");
            options.Add('M', "Display mean of the numbers");
            options.Add('S', "Display the smallest number");
            options.Add('L', "Display the largest number");
            options.Add('F', "Find a number");
            options.Add('C', "Clear the list");
            options.Add('W', "Swap");
            options.Add('Q', "Quit");
            return options;
        }

        public static StringBuilder GetListInString(List<int> list) 
        {
            StringBuilder listInString = new StringBuilder();
            listInString.Append("[ ");
            for (int i = 0; i < list.Count(); i++) 
            {
                listInString.Append(list[i]);
                listInString.Append(" ");
            }

            listInString.Append("]");
            return listInString;
        }

        public static void AddNumberToList(List<int> list, int number)
        {
            list.Add(number);
        }

        public static double GetListMean(List<int> list)
        {
            int sum = 0, count = list.Count();
            for (int i = 0; i < count; i++) 
            {
                sum += list[i];
            }

            return sum / count;
        }

        public static int GetSmallestNumberInList(List<int> list)
        {
            int smallestNumber = list[0];
            for(int i=1; i<list.Count(); i++)
            {
                if(smallestNumber > list[i])
                {
                    smallestNumber = list[i];
                }
            }

            return smallestNumber;
        }

        public static int GetLargestNumberInList(List<int> list)
        {
            int largestNumber = list[0];
            for (int i = 1; i < list.Count(); i++)
            {
                if (largestNumber < list[i])
                {
                    largestNumber = list[i];
                }
            }

            return largestNumber;
        }

        public static void Swap(List<int> list, int firstIndex, int secondIndex)
        {
            int swap = list[firstIndex];
            list[firstIndex] = list[secondIndex];
            list[secondIndex] = swap; 
        }

        public static void ClearList(List<int> list)
        {
            list.Clear();
        }

        public static int GetIndex(List<int> list,int number)
        {
            for(int i =0; i<list.Count(); i++)
            {
                if (list[i] == number)
                    return i;
            }
            return -1;
        }

        private static bool ListIsEmpty(List<int> list)
        {
            return list.Count == 0;
        }

        private static bool IsFound(List<int> list, int number)
        {
            for(int i=0;  i<list.Count(); i++)
            {
                if (list[i] == number)
                    return true;
            }
            return false;
        }
    }
}
