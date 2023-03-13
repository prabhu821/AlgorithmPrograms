using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace DS_AlgorithmAndProgrammingProblems.AlgorithmPrograms;

public class BinarySearch
{
    string[] binaryArray;
    public void ReadTextFile(string filepath)
    {
        string words = File.ReadAllText(filepath);
        binaryArray = words.Split(",");
    }
    public void BinarySearchOperation(string input)
    {
        foreach (var words in binaryArray)
        {
            if (words.Equals(input))
            {
                Console.WriteLine("Found the word in the Word file");
                return;
            }
        }
        Console.WriteLine("Element not available in the list of words");
    }
}