using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedParentheses
{
    class BalancedParenthesis
    {
        static void Main(string[] args)
        {
            Stack<char> par1 = new Stack<char>();
            //Queue<char> par2 = new Queue<char>();
            bool flag = true;

            string input = Console.ReadLine();

            if (input.Length % 2 != 0)
            {
                flag = false;
            }
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '{' || input[i] == '[' || input[i] == '(')

                    par1.Push(input[i]);

                else if (input[i] == '}' || input[i] == ']' || input[i] == ')')
                {
                    switch (input[i])
                    {
                        case '}':
                            if (par1.Count ==0 || par1.Pop() != '{') { flag = false;  break; }
                            break;
                        case ')':
                            if (par1.Count == 0 || par1.Pop() != '(') { flag = false; break; }
                            break;
                        case ']':
                            if (par1.Count == 0 || par1.Pop() != '[') { flag = false; break; }
                            break;
                    }
                }
            }

            Console.WriteLine(flag ? "YES" : "NO");
        }
       /* public static bool checkPar(Stack<char> par1, Queue<char> par2)
        {
            bool flag = true;
            while (par1.Count != 0)
            {
                switch (par1.Pop())
                {
                    case '{':
                        if (par2.Dequeue() != '}')
                        {
                            flag = false;
                        }
                        break;
                    case '[':
                        if (par2.Dequeue() != ']')
                        {
                            flag = false;
                        }
                        break;
                    case '(':
                        if (par2.Dequeue() != ')')
                        {
                            flag = false;
                        }
                        break;
                    case ' ':
                        if (par2.Dequeue() != ' ')
                        {
                            flag = false;
                        }
                        break;
                }
            }
            return flag;
        }
        
        string input = Console.ReadLine();
        Stack<char> par = new Stack<char>();
        int p1 = 0;
        int p2 = 0;
        int p3 = 0;
        bool flag = false;

        foreach (char c in input)
        {
            if (c == '(')
            {
                p1++;
                par.Push(c);
            }
            if (c== '[')
            {
                p2++;
                par.Push(c);
            }
            if (c == '{')
            {
                p3++;
                par.Push(c);
            }
            if (c == ')' && par.Pop() == '(')
            {
                p1--;
            }
            if (c == ']' && par.Pop() == '[')
            {
                p2--;
            }
            if (c == '}' && par.Pop() == '{')
            {
                p3--;
            }                    
        }
        if (p1 != 0 || p2 != 0 || p3 != 0)
        {
            flag = false;
        }
        else
            flag = true;
        Console.WriteLine(flag ? "YES": "NO");
        /*/
    }
}