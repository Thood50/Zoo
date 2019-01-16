using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    //Derived from Animal: Base for Snake & Lizard
    public abstract class Reptile : Animal 
    {
        //Properties
        public abstract int HasLegs { get; set; }

        //Methods
        public virtual bool CanSwim()
        {
            return true;
        }
    }
}
