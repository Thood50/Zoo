using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interface;

namespace Zoo.Classes
{
    //Derived from Lizard &0 IDiet
    public class Gecko : Lizard, IDiet
    {
        //Properties
        public override int HasLegs { get; set; } = 4;
        public override string Habitat { get; set; } = "forest and high tree volumn enviroments";
        public override bool Parent { get; set; } = false;

        //Methods
        public override string Birth()
        {
            return "I gestate my young";
        }

        public override bool CanSwim()
        {
            return true;
        }

        public override string Movement()
        {
            return "I wiggle my way to the finish line";
        }

        //Interface Method
        public string Diet()
        {
            return "I eat small bugs";
        }       
    }
}
