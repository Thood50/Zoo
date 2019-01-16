using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interface;

namespace Zoo.Classes
{
    //Derived from Mammal & INoise: base class for Wolf
    public abstract class Canine : Mammal, INoise
    {
        //Properties
        public abstract bool MansBestFriend { get; set; }

        //Methods
        public override bool Climbing()
        {
            return false;
        }

        //Interface Method
        public string Noise()
        {
            return "Hhhooooowwwwwwllllllll";
        }
    }
}
