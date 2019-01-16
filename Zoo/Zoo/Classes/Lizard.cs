using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interface;

namespace Zoo.Classes
{
    //Derived from reptile & INoise
    public abstract class Lizard : Reptile, INoise
    {
        //Properties
        public virtual bool Venom { get; set; }

        //Methods

        //Instance Method
        public string Noise()
        {
            return "Hi im a lithard, and I have a lithp";
        }
    }
}
