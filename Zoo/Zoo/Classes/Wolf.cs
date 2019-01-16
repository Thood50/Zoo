using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interface;

namespace Zoo.Classes
{
    //Derived from Canine & IDiet
    public class Wolf : Canine, IDiet
    {
        //Properties
        public override bool MansBestFriend { get; set; }
        public override string Habitat { get; set; }
        public override bool Parent { get; set; }
        public override bool HasFourLegs { get; set; }

        //Methods
        public override string Birth()
        {
            return "I gestate things in my belly";
        }

        public override string Movement()
        {
            return "Quite fast, faster then most";
        }

        //Interface method
        public string Diet()
        {
            return "Whatever my pack can corner";
        }
    }
}
