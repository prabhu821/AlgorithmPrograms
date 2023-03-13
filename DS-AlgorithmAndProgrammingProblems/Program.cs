using DS_AlgorithmAndProgrammingProblems.AlgorithmPrograms;

namespace DS_AlgorithmAndProgrammingProblems;

public class Program
{
    public static string filepath = @"D:\OneDrive\Desktop\bridgelabz\DS-AlgorithmAndProgrammingProblems\DS-AlgorithmAndProgrammingProblems\AlgorithmPrograms\WordFile.txt";
    static void Main(string[] args)
    {
        Console.WriteLine("DS-Algorithm and Programming Problems");
        bool flag = true;
        while (flag)
        {
            Console.WriteLine("\nSelect option to execute \n1.Binary Search \n2.Insertion Sort \n3.Bubble Sort \n4.Exit");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    BinarySearch search = new BinarySearch();
                    search.ReadTextFile(filepath);
                    Console.WriteLine("Enter word you want to search");
                    string str = Console.ReadLine();
                    search.BinarySearchOperation(str);
                    break;
                case 2:
                    InsertionSort insertionSort = new InsertionSort();
                    insertionSort.Sort();
                    break;
                case 3:
                    BubbleSort bubbleSort = new BubbleSort();
                    bubbleSort.Sort();
                    break;
                default:
                    flag = false;
                    break;
            }
        }
    }
}