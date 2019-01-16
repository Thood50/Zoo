using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interface;

namespace Zoo.Classes
{
    //Derived from Penguin & IDiet
    public class Erect_crested : Penguin, IDiet
    {
        //Properties
        public override string Habitat { get; set; }
        public override bool Parent { get; set; }
        public override bool CanFly { get; set; }
        public override bool LookLikeSuit { get; set; }

        //Methods
        public override string Movement()
        {
            return "I can waddle and I can slid on MY BELLY!";
        }

        public override string Birth()
        {
            return "I get down with dem eggs yo";
        }

        public override string Swim()
        {
            return "Heck yes I swam with the best of them";
        }

        //Interface Method
        public string Diet()
        {
            return "I eat fish?";
        }
    }
}
