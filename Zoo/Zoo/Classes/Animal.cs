using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    //Base Class
    public abstract class Animal
    {
        //Properties
        public abstract string Habitat { get; set; }

        public virtual bool Parent { get; set; } = false;

        //Methods
        public virtual string Movement()
        {
            return "I can move.";
        }

        public abstract string Birth();

    }
}
