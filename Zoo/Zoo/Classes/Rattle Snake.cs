using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interface;

namespace Zoo.Classes
{
    //Derived from Snake & IDiet
    public class Rattle_Snake : Snake, IDiet
    {
        //Properties
        public override bool Venom { get; set; } = true;
        public override int HasLegs { get; set; } = 0;
        public override string Habitat { get; set; } = "Dirt";
        public override bool Parent { get; set; } = false;

        //Methods
        public override string Birth()
        {
            return "I lay eggs";
        }

        public override bool CanSwim()
        {
            return true;
        }

        public override string Movement()
        {
            return "I slither like a sssssnake";
        }

        //Interface Method
        public string Diet()
        {
            return "I eat sssssmall rodentssss and other ssssnakessss";
        }
    }
}
