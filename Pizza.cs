using System;

namespace Pizza_Decorator
{
    public abstract class Pizza
    {
        public string Size{get;set;}
        public string Decscription{get;set;}

        public Pizza()
        {
            Decscription = "Unkown Pizza";
        }

        public virtual string GetDescription()
        {
            return Size + " " + Decscription;
        }

        public virtual void SetSize(string size)
        {
            Size = size;
        }
        public virtual string GetSize()
        {
            return Size;
        }
        public abstract double Cost();
    }
}
