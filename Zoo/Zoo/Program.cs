using System;
using Zoo.Classes;
using Zoo.Interface;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Surf_Scoter msDuck = new Surf_Scoter();
            Erect_crested dudeErect = new Erect_crested();
            Wolf wolfie = new Wolf();
            Jaguar puss = new Jaguar();
            Gecko larry = new Gecko();
            Rattle_Snake silly = new Rattle_Snake();
            Console.WriteLine("Meet Ms Duck");
            Console.WriteLine(msDuck.Noise());
            Console.WriteLine("Meet Dude Erect");
            Console.WriteLine(dudeErect.Noise());
            Console.WriteLine("Meet wolfie");
            Console.WriteLine(wolfie.Noise());
            Console.WriteLine("Meet da puss");
            Console.WriteLine(wolfie.Noise());
            Console.WriteLine("Im larry the lizard");
            Console.WriteLine(larry.Noise());
            Console.WriteLine("Im silly the snake");
            Console.WriteLine(silly.Noise());
            Console.ReadLine();

        }
    }
}
