using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PizzaTime
{
    public class Pizza
    {
        public static SortedDictionary<int, List<string>> pizzasByGroups = new SortedDictionary<int, List<string>>();
        public int group;
        public string name;
        

        public Pizza(int group, string name)
        {
            this.group = group;
            this.name = name;
        }
        public SortedDictionary<int, List<string>> stupidMethod()
        {
            return pizzasByGroups;
        }
        /*public SortedDictionary<int, List<string>> GetPizzas(params int[] groups)
        {
            if (groups.Length == 0)
            {
                return Pizza.pizzasByGroups;
            }
            SortedDictionary<int, List<string>> selectGroups = new SortedDictionary<int, List<string>>();

            foreach (var group in groups)
            {
                List<string> pizzas = Pizza.pizzasByGroups[group];
                selectGroups.Add(group, pizzas);
            }
            return selectGroups;
        }//*/
        
        public static void PrintPizzas()
        {
            foreach (var p in pizzasByGroups)
            {
                Console.WriteLine("{0} - {1}", p.Key, string.Join(", ",(p.Value)));
            }
        }
    }
    class PizzaTime
    {
        static void Main(string[] args)
        {
            MethodInfo[] methods = typeof(Pizza).GetMethods();
            bool containsMethod = methods.Any(m => m.ReturnType.Name.Contains("SortedDictionary"));
            if (!containsMethod)
            {
                throw new Exception();
            }

            string[] rawPizzas = Console.ReadLine().Split();
            string pattern = @"(\d+)(\w+)";
            Regex matcher = new Regex(pattern);
            List<Pizza> pizzas = new List<Pizza>();
            for (int i = 0; i < rawPizzas.Length; i++)
            {
                Match match = matcher.Match(rawPizzas[i]);
                Pizza pizza = new Pizza(int.Parse(match.Groups[1].Value), match.Groups[2].Value);
                if (!Pizza.pizzasByGroups.ContainsKey(int.Parse(match.Groups[1].Value)))
                {
                    Pizza.pizzasByGroups.Add(int.Parse(match.Groups[1].Value), new List<string>());
                }
                Pizza.pizzasByGroups[int.Parse(match.Groups[1].Value)].Add (match.Groups[2].Value);
            }
            rawPizzas = Console.ReadLine().Split();
            for (int i = 0; i < rawPizzas.Length; i++)
            {
                Match match = matcher.Match(rawPizzas[i]);
                Pizza pizza = new Pizza(int.Parse(match.Groups[1].Value), match.Groups[2].Value);
                if (!Pizza.pizzasByGroups.ContainsKey(int.Parse(match.Groups[1].Value)))
                {
                    Pizza.pizzasByGroups.Add(int.Parse(match.Groups[1].Value), new List<string>());
                }
                Pizza.pizzasByGroups[int.Parse(match.Groups[1].Value)].Add(match.Groups[2].Value);
            }
            Pizza d = new Pizza(2, "dsajgfhgds");
            SortedDictionary< int, List<string>> s = d.stupidMethod();
            Pizza.PrintPizzas();
        }
    }
}
