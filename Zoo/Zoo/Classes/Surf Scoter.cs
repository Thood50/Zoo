using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interface;

namespace Zoo.Classes
{
    //Derived from Duck & IDiet
    public class Surf_Scoter : Duck, IDiet
    {
        //Properties
        public override string Habitat { get; set; }
        public override bool Parent { get; set; }
        public override bool CanFly { get; set; }
        public override string Color { get; set; }

        //Methods
        public override string Movement()
        {
            return "Waddle waddle, till the very next day....";
        }

        public override string Birth()
        {
            return "I lay eggs";
        }

        //Interface Method
        public string Diet()
        {
            return "Bread?";
        }
    }
}
