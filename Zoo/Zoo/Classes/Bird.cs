using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    //Derived from Animal: Baseclass of Duck and Penguin
    public abstract class Bird : Animal
    {
        //Properties
        public abstract bool CanFly { get; set; }

        //Methods
        public virtual string Flying()
        {
            return "Im flying mommy, im really flying!";
        }
    }
}
