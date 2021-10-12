using System;

namespace Pizza_Decorator
{
    public class StuffedCrust : Pizza
    {
        public StuffedCrust()
        {
            Decscription = "Stuffed Crust Pizza";
        }
        public override double Cost()
        {
            double cost = 0.0;
            switch(Size)
            {
                case "Small":
                    cost += 7;
                    break;
                case "Medium":
                    cost += 9.5;
                    break;
                case "Large":
                    cost += 12;
                    break;
            }
            return cost;
        }
    }
}
