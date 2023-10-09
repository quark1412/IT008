using System;
namespace Lab1_6
{
    internal class Bai1_6
    {
        public interface IThinking
        {
            public void thinking_behavior();
        }
        public interface IIntelligent
        {
            public void IIntelligent_behavior();

        }
        public interface IAbility : IIntelligent, IThinking
        {

        }
        public class mamal
        {
            public string characteristics;
        }
        public class Whale : mamal
        {
            public Whale(string character) 
            {
                characteristics = character;
            }
        }
        public class Human : mamal, IAbility
        {
            public void thinking_behavior()
            { Console.WriteLine("Thinking about you"); }
            public void IIntelligent_behavior()
            { Console.WriteLine("Calculate 1+1 "); }
        }

    }

}

