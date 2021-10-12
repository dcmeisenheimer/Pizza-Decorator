using System;

namespace Pizza_Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza jeffsPizza =  new StuffedCrust(){Size = "Large"};
            jeffsPizza = new Cheese(jeffsPizza); // wrap it in cheese
            jeffsPizza = new Sausage(jeffsPizza);

            jeffsPizza.SetSize("Medium"); 

            System.Console.WriteLine(jeffsPizza.GetDescription() + " Cost $" + jeffsPizza.Cost());
        }
    }
}
