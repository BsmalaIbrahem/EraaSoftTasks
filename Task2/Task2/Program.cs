using System.Collections.Generic;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            string choiceSlug = "\0";
            do
            {
                Console.WriteLine("P - Print numbers");
                Console.WriteLine("A - Add a number");
                Console.WriteLine("M - Display mean of the numbers");
                Console.WriteLine("S - Display the smallest number");
                Console.WriteLine("L - Display the largest number");
                Console.WriteLine("F - Find a number");
                Console.WriteLine("C - Clear the list");
                Console.WriteLine("W - Swap");
                Console.WriteLine("Q - Quit\n");
                Console.WriteLine("Enter your choice: ");
                choiceSlug = (Console.ReadLine()).ToUpper();

                switch (choiceSlug) 
                {
                    case "P": 
                        if(GetListCount(numbers) > 0)
                        {
                            string listNums = "[ ";
                            for(int i=0; i< numbers.Count(); i++)
                            {
                                listNums += Convert.ToString(numbers[i]);
                                listNums += " ";
                            }
                            listNums += "]";
                            Console.WriteLine(listNums);
                        }
                        else
                        {
                            Console.WriteLine("[] - the list is empty");
                        }
                        break;
                    case "A": 
                        Console.WriteLine("Enter The number To Add : ");
                        int newNumber = Convert.ToInt32(Console.ReadLine());
                        if(FindElement(numbers, newNumber) == 0)
                        {
                            numbers.Add(newNumber);
                            Console.WriteLine($"{newNumber} added");
                        }
                        else
                        {
                            Console.WriteLine($"{newNumber} can't be added. it's already in the list");
                        }
                        
                        break;
                    case "M":
                        int count = GetListCount(numbers);
                        if (count > 0)
                        {
                            Console.WriteLine($"Mean : {GetListMean(numbers, count)}");
                        }
                        else
                        {
                            Console.WriteLine("Unable to calculate the mean - no data");
                        }
                        break;
                    case "S": 
                        if(GetListCount(numbers) > 0)
                        {
                            Console.WriteLine($"The smallest number is {GetSmallestNumber(numbers)}");
                        }
                        else
                        {
                            Console.WriteLine("Unable to determine the smallest number - list is empty");
                        }
                        break;
                    case "L":
                        if (GetListCount(numbers) > 0)
                        {
                            Console.WriteLine($"The largest  number is {GetLargestNumber(numbers)}");
                        }
                        else
                        {
                            Console.WriteLine("Unable to determine the largest  number - list is empty");
                        }
                        break;
                    case "F":
                        if (GetListCount(numbers) > 0)
                        {
                            Console.WriteLine("Enter the number to search");
                            int search = Convert.ToInt32(Console.ReadLine());
                            int elemntPosition = FindElement(numbers, search);
                            if (elemntPosition != 0)
                            {
                                Console.WriteLine($"Needed number in index {elemntPosition - 1} and position {elemntPosition}");
                            }
                            else
                            {
                                Console.WriteLine($"{search} is not in list");
                            }
                        }
                        else
                        {
                            Console.WriteLine("List is Empty");
                        }
                            
                        break;
                    case "C":
                        if (GetListCount(numbers) > 0)
                        {
                            numbers.Clear();
                            Console.WriteLine("List Cleared Success");
                        }
                        else
                        {
                            Console.WriteLine("List is Empty");
                        }

                        break;
                    case "W":
                        if (GetListCount(numbers) > 0)
                        {
                            Console.WriteLine("Enter the First number");
                            int firstNumber = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter the Second number");
                            int secondNumber = Convert.ToInt32(Console.ReadLine());
                            if(firstNumber == secondNumber)
                            {
                                Console.WriteLine("Please, Select Different numbers");
                            }
                            else
                            {
                                int firstNumberPosition = FindElement(numbers, firstNumber);
                                if(firstNumberPosition == 0)
                                {
                                    Console.WriteLine($"{firstNumber} is not in list");
                                    return;
                                }
                                int secondNumberPosition = FindElement(numbers, secondNumber);
                                if (secondNumberPosition == 0)
                                {
                                    Console.WriteLine($"{secondNumberPosition} is not in list");
                                    return;
                                }

                                int swap = numbers[firstNumberPosition - 1];
                                numbers[firstNumberPosition - 1] = numbers[secondNumberPosition - 1];
                                numbers[secondNumberPosition - 1] = swap;

                                Console.WriteLine("Swapped Successfully !");

                            }
                        }
                        else
                        {
                            Console.WriteLine("List is Empty");
                        }
                        break;
                    case "Q":
                        break;
                    default:
                        Console.WriteLine("You made the wrong choice , Try Again");
                        break;
                }

            } while (choiceSlug != "Q");
        }

        public static int GetListCount(List<int> list)
        {
            return list.Count();
        }

        public static int FindElement(List<int> list, int searchValue)
        {
            for (int i = 0; i < list.Count; i++) 
            {
                if(list[i] == searchValue)
                {
                    return i + 1;
                }
            }
            return 0;
        }

        public static double GetListMean(List<int> list, int length) 
        {
            int sum = 0;
            for(int i = 0; i < list.Count(); i++)
            {
                sum += list[i];
            }
            return sum / length;
        }

        public static int GetSmallestNumber(List<int> list)
        {
            int smallestNumber = list[0];
            for (int i = 1; i < list.Count(); i++) 
            {
                if(list[i] < smallestNumber)
                {
                    smallestNumber = list[i];
                }
            }

            return smallestNumber;
        }

        public static int GetLargestNumber(List<int> list)
        {
            int largestNumber = list[0];
            for (int i = 1; i < list.Count(); i++)
            {
                if (list[i] > largestNumber)
                {
                    largestNumber = list[i];
                }
            }

            return largestNumber;
        }



    }
}
