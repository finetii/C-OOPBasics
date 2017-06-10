using System;


namespace PizzaCalories
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza pizza = null;
            string command = Console.ReadLine();

            while(command != "END")
            {
                string[] pizzaInput = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (pizzaInput[0] == "Dough")
                {
                    try
                    {
                        Console.WriteLine("{0:f2}", CreateDough(command).Calories());
                    }
                    catch (ArgumentException ae)
                    {
                        Console.WriteLine(ae.Message);
                        return;
                    }
                }

                else if (pizzaInput[0] == "Topping")
                {
                    try
                    {
                        Console.WriteLine("{0:f2}", CreateTopping(command).Calories());
                    }
                    catch (ArgumentException ae)
                    {
                        Console.WriteLine(ae.Message);
                        return;
                    }
                }
                else
                {
                    int numberOfToppings = int.Parse(pizzaInput[2]);
                    try
                    {
                        pizza = new Pizza(pizzaInput[1], numberOfToppings);
                    }
                    catch (ArgumentException ae)
                    {
                        Console.WriteLine(ae.Message);
                        return;
                    }
                    command = Console.ReadLine();
                        try
                        {
                            pizza.Dough = CreateDough(command);
                        }
                        catch (ArgumentException ae)
                        {
                            Console.WriteLine(ae.Message);
                            return;
                        }
                        for (int i = 0; i < numberOfToppings; i++)
                        {
                            command = Console.ReadLine();
                            try
                            {
                                pizza.AddTopping(CreateTopping(command));
                            }
                            catch (ArgumentException ae)
                            {
                                Console.WriteLine(ae.Message);
                                return;
                            }
                    } 
                    Console.WriteLine("{0} – {1:f2} Calories.", pizza.Name, pizza.CalculateCalories());
                }        
                command = Console.ReadLine();
            } 
        }

        static Dough CreateDough(string command)
        {
            Dough dough = null;
            string[] doughInput = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            try
            {
                dough = new Dough(doughInput[1], doughInput[2], double.Parse(doughInput[3]));
            }
            catch (ArgumentException ae)
            {
                throw ae;
            }
            return dough;
        }

        static Topping CreateTopping(string command)
        {
            Topping topping = null;
            string[] toppingInput = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            try
            {
                topping = new Topping(toppingInput[1], double.Parse(toppingInput[2]));
            }
            catch (ArgumentException ae)
            {
                throw ae;
            }
            return topping;
        }
        
    }
}
