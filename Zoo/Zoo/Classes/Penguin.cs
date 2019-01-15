using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interface;

namespace Zoo.Classes
{
    //Derived from Bird: Base class of Erect-crested
    public abstract class Penguin : Bird, Noise
    {
        //Properties
        public virtual bool LookLikeSuit { get; set; }

        //Methods
        public abstract string Swim();

        //Instance method
        public string Noise()
        {
            return "Squack";
        }
    }
}
