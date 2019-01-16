using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interface;

namespace Zoo.Classes
{
    //Derived from Reptile & INoise: Base class for Rattle Snake
    public abstract class Snake : Reptile, INoise
    {
        //Properties
        public abstract bool Venom { get; set; }

        //Methods

        //Interface Methods
        public string Noise()
        {
            return "sssssssssssss, im a sssslippery sssssnake";
        }
    }
}
