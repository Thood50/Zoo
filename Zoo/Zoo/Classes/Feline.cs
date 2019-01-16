using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interface;

namespace Zoo.Classes
{
    //Derived from Mammal & INoise: Base class for Jaguar
    public abstract class Feline : Mammal, INoise
    {
        //Properties
        public virtual bool Domestic { get; set; }

        //Methods
        public override bool Climbing()
        {
            return true;
        }

        //Interface Method
        public string Noise()
        {
            return "Snarl";
        }
    }
}
