using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_AlgorithmAndProgrammingProblems.AlgorithmPrograms;

public class CustomizeMessage
{
    public void ReplaceString()
    {
        string input = "Hello <<name>>, We have your full name as << full name >> in our system." +
            " your contact number is 91 - xxxxxxxxxx.Please,let us know in case of any clarification." +
            "Thank you BridgeLabz";
        Console.WriteLine("Enter Name");
        string name = Console.ReadLine();
        input = input.Replace("<<name>>", name);
        Console.WriteLine("Enter Full Name");
        string fullName = Console.ReadLine();
        input = input.Replace("<< full name >>", fullName);
        Console.WriteLine("Enter Mobile Number");
        string mobile = Console.ReadLine();
        input = input.Replace("- xxxxxxxxxx", mobile);
        Console.WriteLine(input);
    }
}
