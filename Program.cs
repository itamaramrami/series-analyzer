using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace series_analyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("series analyzer");
            int choice;
            int[] numbers;
            if (!IsArgsValid(args))
            {
                numbers = Array.ConvertAll(args, int.Parse);
                Console.WriteLine("The series was captured in args");
            }
            else
            {
                numbers = InputOfUser();
            }
            menu();
            Console.WriteLine("enter a choice:");
            choice = int.Parse(Console.ReadLine());
            while (choice < 1 || choice > 10)
            {
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 10.");
                choice = int.Parse(Console.ReadLine());
            }
            do
            {
               

                switch (choice)
                    {
                        case 1:
                            InputOfUser();
                            menu();
                        Console.WriteLine("Enter your choice:");
                        choice = int.Parse(Console.ReadLine());
                        break;
                        case 2:
                            ShowSeries(numbers);
                            menu();
                            Console.WriteLine("Enter your choice:");
                            choice = int.Parse(Console.ReadLine());
                            break;  
                        case 3:
                            ShowSeriesInReverse(numbers);
                            menu();
                            Console.WriteLine("Enter your choice:");
                            choice = int.Parse(Console.ReadLine());
                            break;
                        case 4:
                            ShowSeriesSorted(numbers);
                            menu();
                            Console.WriteLine("Enter your choice:");
                            choice = int.Parse(Console.ReadLine());
                            break;
                        case 5:
                            ShowMaxValue(numbers);
                            menu();
                            Console.WriteLine("Enter your choice:");
                            choice = int.Parse(Console.ReadLine());
                            break;
                        case 6:
                            ShowMinValue(numbers);
                            menu();
                            Console.WriteLine("Enter your choice:");
                            choice = int.Parse(Console.ReadLine());
                            break;
                        case 7:
                            ShowAverageValue(numbers);
                            menu();
                            Console.WriteLine("Enter your choice:");
                            choice = int.Parse(Console.ReadLine());
                            break;
                        case 8:
                            ShowCountOfValues(numbers);
                            menu();
                            Console.WriteLine("Enter your choice:");
                            choice = int.Parse(Console.ReadLine());
                            break;
                        case 9:
                            ShowTotalAmount(numbers);
                            menu();
                            Console.WriteLine("Enter your choice:");
                            choice = int.Parse(Console.ReadLine());
                            break;
                        
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    

                }
            } while (choice != 10);
            Console.WriteLine("Exiting the program.");







        }
        static bool IsArgsValid(string[] argss)
        {
            if (argss.Length < 3)
            {
                return true;
            }

            foreach (string arg in argss)
            {
                if (!int.TryParse(arg, out int number) || number <= 0)
                {
                    return true;
                }
            }

            return false;
        }
        static int[] InputOfUser()
        {
            List<int> numbers = new List<int>();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Enter number {i + 1}:");
                string input = Console.ReadLine();
                int num;

                while (!int.TryParse(input, out num) || num <= 0)
                {
                    Console.WriteLine("Invalid input. Please enter a positive integer.");
                    input = Console.ReadLine();
                }

                numbers.Add(num);
            }

            return numbers.ToArray();
        }
        static void menu()
        {
            Console.WriteLine("To enter a new series, enter 1.");
            Console.WriteLine("To view the series in the usual order, enter 2.");
            Console.WriteLine("To view the series in reverse order, press 3.");
            Console.WriteLine("To view the sorted series, see Conference 4.");
            Console.WriteLine("To display the maximum value, enter 5.");
            Console.WriteLine("To display the minimum value, enter 6.");
            Console.WriteLine("To display the average value, enter 7.");
            Console.WriteLine("To display the number of values, enter 8.");
            Console.WriteLine("To display the total amount number, enter 9.");
            Console.WriteLine("Exit the program Enter 10.");
        }

        static void ShowSeries(int[] numbers)
        {
            Console.WriteLine("The series is: [" + string.Join(", ", numbers) + "]");

        }

        static void ShowSeriesInReverse(int[] numbers)
        {
            List<int> reversedNumbers = new List<int>();
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                reversedNumbers.Add(numbers[i]);
            }
            Console.WriteLine("The series in reverse order is: [" + string.Join(", ", reversedNumbers)+ "]");
        }

        static void ShowSeriesSorted(int[] numbers)
        {
            for (int i =0 ; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        int temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }
            Console.WriteLine("The sorted series is: [" + string.Join(", ", numbers) + "]");
        }

        static void ShowMaxValue(int[] numbers)
        {
            int maxValue = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > maxValue)
                {
                    maxValue = numbers[i];
                }
            }
            Console.WriteLine("The maximum value is: [" + maxValue + "]") ;
        }

        static void ShowMinValue(int[] numbers) {
            int minValue = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < minValue)
                {
                    minValue = numbers[i];
                }
            }
            Console.WriteLine("The minimum value is: [" + minValue + "]");
        }

        static void ShowAverageValue(int[] numbers) {
            double sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            double average = sum / numbers.Length;
            Console.WriteLine("The average value is: [" + average + "]");
        }
        static void ShowCountOfValues(int[] numbers) {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += 1;
            }
            Console.WriteLine("The count of values is: [" + sum + "]");
        }

        static void ShowTotalAmount(int[] numbers) {
            int total = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                total += numbers[i];
            }
            Console.WriteLine("The total amount is: [" + total + "]");
        }






    }
}
