using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    //Derived from Animal: Base for Feline and Canine
    public abstract class Mammal : Animal
    {
        //Properties
        public virtual bool HasFourLegs { get; set; }

        //Methods
        public virtual bool Climbing()
        {
            return false;
        }
    }
}
