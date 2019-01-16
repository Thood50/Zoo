using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interface;

namespace Zoo.Classes
{
    //Derived from Duck & INoise: and base class for Surf Scoter
    public abstract class Duck : Bird, INoise
    {
        //Properties
        public abstract string Color { get; set; }

        //Methods
        public override string Flying()
        {
            return "I love to fly when im not floating down a river";
        }

        //Interface Method
        public string Noise()
        {
            return "Quack";
        }       

    }
}
