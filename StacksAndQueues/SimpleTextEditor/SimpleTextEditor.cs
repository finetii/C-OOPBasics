using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace SimpleTextEditor
{
    class SimpleTextEditor
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack<string> strings = new Stack<string>();
            string currentString = "";
            strings.Push(currentString);
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                switch (command[0])
                {
                    case "1":
                        {
                            currentString += command[1];
                            strings.Push(currentString);
                        }
                        break;
                    case "2":
                        {
                            int count = int.Parse(command[1]);
                            StringBuilder str = new StringBuilder();
                            currentString = currentString.Substring(0, currentString.Length - count);
                            strings.Push(currentString);
                        }
                        break;
                    case "3":
                        {
                            int index = int.Parse(command[1]);
                            Console.WriteLine(currentString[index - 1]);
                        }
                        break;
                    case "4":
                        {
                            strings.Pop();
                            currentString = strings.Peek();
                        }
                        break;
                }
            }
        }
    }
}
