namespace OOP_Console
{
    public interface IAnimal
    {
        string MakeSound();
    }

    public abstract class Animal : IAnimal
    {
        protected string _name;

        public Animal(string name)
        {
            _name = name;
        }

        public abstract string MakeSound();
    }

    public class Cat : Animal
    {
        public Cat() : base("Cat")
        {
            
        }

        public override string MakeSound()
        {
            return _name + " - Meow";
        }
    }

    public class Dog : Animal
    {
        public Dog() : base("Dog")
        {
            
        }

        public override string MakeSound()
        {
            return _name + " - Bark";
        }
    }

    public class Fox : Animal
    {
        public Fox() : base("Fox")
        {
            
        }

        public override string MakeSound()
        {
            return _name + "Ring ding ding";
        }
    }
}