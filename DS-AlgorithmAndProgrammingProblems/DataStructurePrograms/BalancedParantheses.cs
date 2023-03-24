using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_AlgorithmAndProgrammingProblems.DataStructurePrograms;

public class BalancedParantheses
{
    public void CheckParantheses()
    {
        string list = "(5 + 6) ∗ (7 + 8) / (4 + 3)(5 + 6) ∗(7 + 8) / (4 + 3)";
        string[] words = list.Split(" ");
        ListStack<string> Liststack = new ListStack<string>();
        foreach (var data in words)
        {
            if (data.Equals("("))
                Liststack.Push(data);
            if (data.Equals(")"))
                Liststack.Pop();
        }
        if (Liststack.Peek())
        {
            Console.WriteLine("Arithmetic Expression is balanced");
        }
        else
            Console.WriteLine("Arithmetic Expression is not balanced");
    }
}

