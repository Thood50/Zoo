using System;
using Xunit;
using Zoo.Classes;
using Zoo.Interface;
using Zoo;

namespace TestZoo
{
    public class UnitTest1
    {
        [Fact]
        public void TestSnakeNoiseInterface()
        {
            Rattle_Snake silly = new Rattle_Snake();
            Assert.Equal("sssssssssssss, im a sssslippery sssssnake", silly.Noise());
        }

        [Fact]
        public void TestSnakeDietInterface()
        {
            Rattle_Snake silly = new Rattle_Snake();
            Assert.Equal("I eat sssssmall rodentssss and other ssssnakessss", silly.Diet());
        }

        [Fact]
        public void TestSnakeParentTrue()
        {
            Rattle_Snake silly = new Rattle_Snake();
            bool isFalse = silly.Parent;
            Assert.False(isFalse);
        }

        [Fact]
        public void TestSnakeBecameParent()
        {
            Rattle_Snake silly = new Rattle_Snake();
            silly.Parent = true;
            bool isTrue = silly.Parent;
            Assert.True(isTrue);
        }

        [Fact]
        public void TestGeckoNoiseInterface()
        {
            Gecko silly = new Gecko();
            Assert.Equal("Hi im a lithard, and I have a lithp", silly.Noise());
        }

        [Fact]
        public void TestGeckoDietInterface()
        {
            Gecko silly = new Gecko();
            Assert.Equal("I eat small bugs", silly.Diet());
        }

        [Fact]
        public void TestGeckoParentTrue()
        {
            Gecko silly = new Gecko();
            bool isFalse = silly.Parent;
            Assert.False(isFalse);
        }

        [Fact]
        public void TestGeckoBecameParent()
        {
            Gecko silly = new Gecko();
            silly.Parent = true;
            bool isTrue = silly.Parent;
            Assert.True(isTrue);
        }

        [Fact]
        public void TestJaguarNoisetInterface()
        {
            Jaguar silly = new Jaguar();
            Assert.Equal("Snarl", silly.Noise());
        }

        [Fact]
        public void TestJaguarDietInterface()
        {
            Jaguar silly = new Jaguar();
            Assert.Equal("I eat whatever I can catch", silly.Diet());
        }

        [Fact]
        public void TestJaguarParentTrue()
        {
            Jaguar silly = new Jaguar();
            bool isFalse = silly.Parent;
            Assert.False(isFalse);
        }

        [Fact]
        public void TestJaguarBecameParent()
        {
            Jaguar silly = new Jaguar();
            silly.Parent = true;
            bool isTrue = silly.Parent;
            Assert.True(isTrue);
        }

        [Fact]
        public void TestWolfNoisetInterface()
        {
            Wolf silly = new Wolf();
            Assert.Equal("Hhhooooowwwwwwllllllll", silly.Noise());
        }

        [Fact]
        public void TestWolfDietInterface()
        {
            Wolf silly = new Wolf();
            Assert.Equal("Whatever my pack can corner", silly.Diet());
        }

        [Fact]
        public void TestWolfParentTrue()
        {
            Wolf silly = new Wolf();
            bool isFalse = silly.Parent;
            Assert.False(isFalse);
        }

        [Fact]
        public void TestWolfBecameParent()
        {
            Wolf silly = new Wolf();
            silly.Parent = true;
            bool isTrue = silly.Parent;
            Assert.True(isTrue);
        }

        [Fact]
        public void TestDuckNoisetInterface()
        {
            Surf_Scoter silly = new Surf_Scoter();
            Assert.Equal("Quack", silly.Noise());
        }

        [Fact]
        public void TestDuckDietInterface()
        {
            Surf_Scoter silly = new Surf_Scoter();
            Assert.Equal("Bread?", silly.Diet());
        }

        [Fact]
        public void TestDuckParentTrue()
        {
            Duck silly = new Surf_Scoter();
            bool isFalse = silly.Parent;
            Assert.False(isFalse);
        }

        [Fact]
        public void TestDuckBecameParent()
        {
            Duck silly = new Surf_Scoter();
            silly.Parent = true;
            bool isTrue = silly.Parent;
            Assert.True(isTrue);
        }

        [Fact]
        public void TestErectNoisetInterface()
        {
            Erect_crested silly = new Erect_crested();
            Assert.Equal("Squack", silly.Noise());
        }

        [Fact]
        public void TestErectDietInterface()
        {
            Erect_crested silly = new Erect_crested();
            Assert.Equal("I eat fish?", silly.Diet());
        }

        [Fact]
        public void TestErectParentTrue()
        {
            Erect_crested silly = new Erect_crested();
            bool isFalse = silly.Parent;
            Assert.False(isFalse);
        }

        [Fact]
        public void TestErectBecameParent()
        {
            Erect_crested silly = new Erect_crested();
            silly.Parent = true;
            bool isTrue = silly.Parent;
            Assert.True(isTrue);
        }

        

    }
}
