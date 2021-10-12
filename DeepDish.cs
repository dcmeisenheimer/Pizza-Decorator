using System;

namespace Pizza_Decorator
{
    public class DeepDish :Pizza
    {
        public DeepDish()
        {
            Decscription = "Deep Dish Pizza";
        }
        public override double Cost()
        {
            double cost = 0.0;
            switch(Size)
            {
                case "Small":
                    cost += 6;
                    break;
                case "Medium":
                    cost += 8.5;
                    break;
                case "Large":
                    cost += 11;
                    break;
            }
            return cost;
        }
    }
}
