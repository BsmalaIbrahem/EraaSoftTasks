namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> Numbers = new List<int>();
            int num = 0;

            try
            {
               CheckString("Bas354@");
               CheckString("56_@");
            }
            catch(Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ForegroundColor = ConsoleColor.White;
            }
            finally
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("The input string has been read.");
                Console.ForegroundColor = ConsoleColor.White;
            }
            

            try
            {
                do
                {
                    Console.WriteLine("Enter the number to add it to the list or enter -1 if you do not want to add a new number : ");
                    num = Convert.ToInt32(Console.ReadLine());
                    CheckNumbser(Numbers, num);
                    AddNumberToList(Numbers, num);
                }while (num != -1);
                
            }
            catch (Exception ex) 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        private static void AddNumberToList(List<int> nums, int number)
        {
            nums.Add(number);
        }

        private static void CheckNumbser(List<int> nums, int number)
        {
            foreach (int item in nums) 
            {
                if (item == number)
                    throw new Exception($"Number {number} is already on the list.");
            }
        }

        private static void CheckString(string text)
        {
            bool flag = false;
            text = text.ToUpper();
            for(int i=0; i<text.Length; i++)
            {
                if (text[i] >= 65 && text[i] <= 91)
                {
                    flag = true;
                    break;
                }
            }

            if (!flag)
                throw new Exception("the string does not contain vowels.");

        }


    }
}
