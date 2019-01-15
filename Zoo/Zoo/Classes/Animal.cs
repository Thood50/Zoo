using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    //Base Class
    public abstract class Animal
    {
        public abstract string Habitat { get; set; }

        public virtual bool Parent { get; set; } = false;

        public virtual string Movement()
        {
            return "I can move.";
        }

        public abstract string Birth();

    }
}
