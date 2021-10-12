using System;

namespace Pizza_Decorator
{
    public class Original : Pizza
    {
        public Original()
        {
            Decscription = "Original Pizza";
        }
        public override double Cost()
        {
            double cost = 0.0;
            switch(Size)
            {
                case "Small":
                    cost += 5;
                    break;
                case "Medium":
                    cost += 7.5;
                    break;
                case "Large":
                    cost += 10;
                    break;
            }
            return cost;
        }
    }
}
