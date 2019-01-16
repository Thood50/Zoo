using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interface;

namespace Zoo.Classes
{
    //Derived from Feline & IDiet
    public class Jaguar : Feline, IDiet
    {
        //Properties
        public override string Habitat { get; set; }
        public override bool Parent { get; set; }
        public override bool HasFourLegs { get; set; }
        public override bool Domestic { get; set; }

        //Methods
        public override string Birth()
        {
            return "I grow them in my belly";
        }

        public override string Movement()
        {
            return "Im super fast, neeeeeeuuuuummmmm";
        }

        //Interface Method
        public string Diet()
        {
            return "I eat whatever I can catch";
        }
    }
}
